# MouseSimulation
This static class gives you the ability to move the player's mouse cursor and simulate a mouse click. This usually is not recommended, but it is really useful for controller support in desktop games.

> **Warning**
>
> This class only works on Windows and Ubuntu (or any other linux distro that uses X11).
> It will **not work** on Mac OS X. 
> I hope to add support for Mac OS X in the future, but I currently don't have access to a Mac. 

```cs
using UnityEngine;

// Initialize the class (optional)
MouseSimulation.Initialize();

// Move the mouse to the center of the screen!
MouseSimulation.Move(new(Screen.width / 2f, Screen.height / 2f));

// Click!
MouseSimulation.Click(MouseSimulation.Buttons.LEFT_DOWN);
MouseSimulation.Click(MouseSimulation.Buttons.LEFT_UP);

// Clean up (recommended)
MouseSimulation.Destroy();
```

## Installation Guide
To install MouseSimulation, clone this repository and put the [`MouseSimulation.cs`](./MouseSimulation.cs) file into your Unity project.

Make sure that you are `using UnityEngine;`.

## Reference
### `bool MouseSimulation.Supported { get; }`
A property that is `true` if mouse simulation is supported on the platform and `false` otherwise. This value is not constant and changes if an error occurs.<br/>
<br/>
**Example**
```cs
if (MouseSimulation.Supported) {
	// Mouse simulation is supported
} else {
	// Mouse simulation is not supported
}
```
<hr/>

### `enum MouseSimulation.Button`
An enum containing different click types. The values of the enum changes depending on the platform.

Values are:
```
LEFT_DOWN,
LEFT_UP,
MIDDLE_DOWN,
MIDDLE_UP,
RIGHT_DOWN,
RIGHT_UP
```
<hr/>

### `MouseSimulation.Initialize()`
A method that initializes `MouseSimulation`. This doesn't have to be called manually unless you want to see if there are errors. Returns whether or not the initialization was successful.<br/>
<br/>
**Example**
```cs
if (!MouseSimulation.Initialize()) {
	// There was an error
}
```
<hr/>

### `MouseSimulation.Destroy()`
A clean up method that should be called before the application quits.<br/>
<br/>
**Example**
```cs
private void OnApplicationClose() {
	MouseSimulation.OnApplicationQuit();
}
```
<hr/>

### `MouseSimulation.Move(Vector2 position)`
Moves the mouse to the specified screen position. Returns whether or not the operation was successful.<br/>
<br/>
**Example**
```cs
// Moves the mouse to where the mouse is.
// In other words, it just keeps the mouse still.
MouseSimulation.Move(Input.mousePosition);

// Moves the mouse to the bottom left of the screen.
MouseSimulation.Move(Vector2.Zero);
```
<hr/>

### `MouseSimulation.Click(MouseSimulation.Button button)`
Presses or releases the specified mouse button. Returns whether or not the operation was successful.<br/>
<br/>
**Example**
```cs
// Left click
// Some delay between these events is probably a good idea.
MouseSimulation.Click(MouseSimulation.Buttons.LEFT_DOWN);
MouseSimulation.Click(MouseSimulation.Buttons.LEFT_UP);

// Right click
MouseSimulation.Click(MouseSimulation.Buttons.RIGHT_DOWN);
MouseSimulation.Click(MouseSimulation.Buttons.RIGHT_UP);
```
<hr/>