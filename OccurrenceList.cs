namespace System.Collections.Generic {
	/// <summary>
	/// Stores the number of times <c>T</c> occurs. Occurrences can easily be added and manipulated.
	/// </summary>
	public class OccurrenceList<T> : IEnumerable, IEnumerable<KeyValuePair<T, int>> {
		/*
		 *	OccurrenceList
		 */

		/// <summary>
		/// A dictionary that stores the actual occurrences.
		/// </summary>
		private Dictionary<T, int> occurrences = new();

		/// <summary>
		/// Adds an occurence or multiple occurences to the list.
		/// </summary>
		/// <param name="item">The key or item that has an occurence.</param>
		/// <param name="count">The number of occurences that should be added.</param>
		public void Add(T item, int count = 1) {
			if (occurrences.ContainsKey(item)) {
				occurrences[item] += count;
			} else {
				occurrences[item] = count;
			}
		}

		/// <summary>
		/// Removes an occurence or multiple occurences to the list.
		/// </summary>
		/// <param name="item">The key or item that has an occurence.</param>
		/// <param name="count">The number of occurences that should be removed.</param>
		public void Remove(T item, int count = 1) {
			Add(item, -count);
		}

		/// <summary>
		/// Sets the number of times an that <c>item</c> occurs to zero.<br/>
		/// This does not remove it from the list. See: <see cref="RemoveAllZeros"/>
		/// </summary>
		/// <param name="item">The key or item in which the occurences should be set to zero.</param>
		public void RemoveAll(T item) {
			occurrences[item] = 0;
		}

		/// <summary>
		/// Removes all of the items where the number of times it occurs is zero.
		/// </summary>
		public void RemoveAllZeros() {
			foreach (KeyValuePair<T, int> pair in new Dictionary<T, int>(occurrences)) {
				if (pair.Value == 0) {
					occurrences.Remove(pair.Key);
				}
			}
		}

		/// <returns>
		/// The number of times that <c>item</c> occurs. If <c>item</c> is not in the list, it will return <c>0</c>.
		/// </returns>
		/// <param name="item">The key or item to check.</param>
		public int GetCount(T item) {
			return occurrences.ContainsKey(item) ? occurrences[item] : 0;
		}

		/// <returns>
		/// The occurence list in dictionary form.
		/// </returns>
		public Dictionary<T, int> ToDictionary() {
			return new Dictionary<T, int>(occurrences);
		}

		public IEnumerator GetEnumerator() {
			return occurrences.GetEnumerator();
		}

		IEnumerator<KeyValuePair<T, int>> IEnumerable<KeyValuePair<T, int>>.GetEnumerator() {
			return occurrences.GetEnumerator();
		}
	}
}
