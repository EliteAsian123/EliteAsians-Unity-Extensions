#if UNITY_STANDALONE_LINUX
using System;
#endif

using System.Runtime.InteropServices;

namespace UnityEngine {
	/// <summary>
	/// A static class used for simulating mouse input.<br/>
	/// </summary>
	/// <remarks>
	/// Currently only supported on Windows and X11 based linux platforms.
	/// </remarks>
	public static class MouseSimulation {
		private static bool initialized = false;
		private static bool failed = false;

#if UNITY_STANDALONE_LINUX
		private static IntPtr display;
		private static uint window;
#endif

		/// <value>
		/// Whether or not mouse simulation is supported on this platform.
		/// </value>
		public static bool Supported {
			get {
#if UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX
				return !failed;
#else
				return false;
#endif
			}
		}

		/// <summary>
		/// An enum containing different click types.
		/// </summary>
		/// <remarks>
		/// This is a dummy enum if mouse simulation is not supported.
		/// </remarks>
		public enum Button {
#if UNITY_STANDALONE_WIN
			LEFT_DOWN = 0x2,
			LEFT_UP = 0x4,
			MIDDLE_DOWN = 0x20,
			MIDDLE_UP = 0x40,
			RIGHT_DOWN = 0x8,
			RIGHT_UP = 0x10,
#elif UNITY_STANDALONE_LINUX
			LEFT_DOWN = 0b001,
			LEFT_UP = 0b101,
			MIDDLE_DOWN = 0b010,
			MIDDLE_UP = 0b110,
			RIGHT_DOWN = 0b011,
			RIGHT_UP = 0b111,
#else
			LEFT_DOWN,
			LEFT_UP,
			MIDDLE_DOWN,
			MIDDLE_UP,
			RIGHT_DOWN,
			RIGHT_UP,
#endif
		}

#if UNITY_STANDALONE_WIN

		[StructLayout(LayoutKind.Sequential)]
		private struct Point {
			public int x;
			public int y;
		}

		[DllImport("user32.dll")]
		private static extern bool SetCursorPos(int x, int y);

		[DllImport("user32.dll")]
		private static extern bool GetCursorPos(out Point lpPoint);

		[DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

#elif UNITY_STANDALONE_LINUX

		[DllImport("libX11", CharSet = CharSet.Unicode)]
		private static extern IntPtr XOpenDisplay(string display_name);

		[DllImport("libX11")]
		private static extern void XCloseDisplay(IntPtr display);

		[DllImport("libX11")]
		private static extern uint XRootWindow(IntPtr display, int screen);

		[DllImport("libX11")]
		private static extern int XDefaultScreen(IntPtr display);

		[DllImport("libX11")]
		private static extern void XWarpPointer(IntPtr display, uint src_w, uint dest_w, int src_x, int src_y, uint src_width,
			uint src_height, int dest_x, int dest_y);

		[DllImport("libX11")]
		private static extern void XQueryPointer(IntPtr display, uint w, out uint root_return, out uint child_return,
			out int root_x_return, out int root_y_return, out int win_x_return, out int win_y_return, out uint mask_return);

		[DllImport("libXtst")]
		private static extern int XTestFakeButtonEvent(IntPtr display, uint button, bool press, IntPtr time);

		[DllImport("libX11")]
		private static extern void XFlush(IntPtr display);

#endif

		/// <summary>
		/// Doesn't have to be called manually unless you want to see if there are errors.
		/// </summary>
		/// <returns>
		/// Whether or not the initialization was successful.
		/// </returns>
		public static bool Initialize() {
			initialized = true;

#if UNITY_STANDALONE_WIN
			
			// Nothing!

#elif UNITY_STANDALONE_LINUX

			try {
				display = XOpenDisplay(null);
				window = XRootWindow(display, XDefaultScreen(display));
			} catch {
				failed = true;
			}

#else
			
			failed = true;

#endif

			if (failed) {
				Debug.LogError("MouseSimulation is not supported on this platform!");
			}

			return !failed;
		}

		/// <summary>
		/// Needs to be called when the application quits.
		/// </summary>
		public static void Destroy() {
#if UNITY_STANDALONE_LINUX

			try {
				XCloseDisplay(display);
			} catch {
				Debug.LogError("Failed to close display!");
			}

#endif
		}

		/// <summary>
		/// Moves the mouse to the specified position in Unity screen space.
		/// </summary>
		/// <param name="position">The new mouse position.</param>
		/// <returns>
		/// Whether or not the operation was successful.
		/// </returns>
		public static bool Move(Vector2 position) {
			if (!initialized && !Initialize()) {
				return false;
			}

#if UNITY_STANDALONE_WIN

			try {
				// Get the REAL mouse position (convert origin to bottom-left)
				GetCursorPos(out Point point);
				Vector2 realPosition = new(point.x, Screen.height - point.y);

				// Get the unity mouse position
				Vector2 unityPosition = Input.mousePosition;

				// Get the difference
				Vector2 diff = realPosition - unityPosition;

				// Set to correct location (convert origin back to top-left)
				Vector2 setPosition = position + diff;
				SetCursorPos((int) setPosition.x, Screen.height - (int) setPosition.y);
			} catch {
				failed = true;
				return false;
			}

			return true;

#elif UNITY_STANDALONE_LINUX

			try {
				// Get the REAL mouse position (convert origin to bottom-left)
				XQueryPointer(display, window, out uint _, out _, out int x, out int y, out _, out _, out _);
				Vector2 realPosition = new(x, Screen.height - y);

				// Get the unity mouse position
				Vector2 unityPosition = Input.mousePosition;

				// Get the difference
				Vector2 diff = realPosition - unityPosition;

				// Set to correct location (convert origin back to top-left)
				Vector2 setPosition = position + diff;
				XWarpPointer(display, 0, window, 0, 0, 0, 0, (int) setPosition.x, Screen.height - (int) setPosition.y);
				XFlush(display);
			} catch {
				failed = true;
				return false;
			}

			return true;

#else

			return false;

#endif
		}

		/// <summary>
		/// Simulates a mouse click.
		/// </summary>
		/// <param name="button">The mouse button and its state.</param>
		/// <returns>
		/// Whether or not the operation was successful.
		/// </returns>
		public static bool Click(Button button) {
			if (!initialized && !Initialize()) {
				return false;
			}

#if UNITY_STANDALONE_WIN

			try {
				mouse_event((int) button, 0, 0, 0, 0);
			} catch {
				failed = true;
				return false;
			}

			return true;

#elif UNITY_STANDALONE_LINUX

			try {
				bool press = (uint) button >> 2 != 0b1;

				if (XTestFakeButtonEvent(display, (uint) button & 0b11, press, IntPtr.Zero) == 0) {
					throw new Exception();
				}
				XFlush(display);
			} catch {
				failed = true;
				return false;
			}

			return true;

#else
			
			return false;

#endif
		}
	}
}