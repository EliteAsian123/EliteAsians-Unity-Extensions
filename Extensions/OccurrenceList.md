# OccurrenceList
This class is a list that stores how many times an `item` occurs. In other words, it is an easily manipulatable dictionary of `T` and `int`.

```cs
// Create the OccurrenceList
OccurrenceList<string> occurrences = new OccurrenceList<string>();

// Add occurrences!
occurrences.Add("hello");
occurrences.Add("world");
occurrences.Add("hello");
occurrences.Add("there", 24); // Add 24 of these

// Get occurrences
occurrences.GetCount("hello"); // returns 2
occurrences.GetCount("world"); // returns 1
occurrences.GetCount("there"); // returns 24

// Remove some occurrences
occurrences.Remove("hello");
occurrences.GetCount("hello"); // returns 1



// Make an awesome list
List<string> list = new List<string>();
list.Add("hello");
list.AddRange(new string[] { "world", "foo", "hello" });

// Create an OccurrenceList from that list
OccurrenceList<string> moreOccurrences = OccurrenceList<string>.CreateFromEnumerable(list);

// Get occurrences
moreOccurrences.GetCount("hello"); // returns 2
moreOccurrences.GetCount("world"); // returns 1
moreOccurrences.GetCount("hello there!"); // returns 0

```

## Installation Guide
To install OccurrenceList, clone this repository and put the [`OccurrenceList.cs`](./OccurrenceList.cs) file into your Unity project.<br />
Make sure that you are `using System.Collections.Generic;`.

## Reference
### `OccurrenceList<T>.Add(T item, int count = 1)`
Adds an (or of `count`) occurrence(s) to the list. Automatically creates an entry if it isn't in the list.<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = new OccurrenceList<string>();

occurrences.Add("hello"); // Adds 1 occurrence of "hello"
occurrences.Add("hello", 2); // Adds 2 occurrences of "hello"
```
<hr />

### `OccurrenceList<T>.Remove(T item, int count = 1, bool removeIfZero = false)`
Removes an (or of `count`) occurrence(s) from the list. Does not remove the entry from the list if the count is zero unless `removeIfZero` is true.<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = new OccurrenceList<string>();
occurrences.Add("hello", 32);

occurrences.Remove("hello"); // Sets the occurrences of "hello" to 31
occurrences.Remove("hello", 2); // Sets the occurrences of "hello" to 29
```
<hr />

### `OccurrenceList<T>.RemoveAll(T item, bool removeFromList = false)`
Sets the amount of occurences of a specific item to zero. Does not remove the entry from the list unless `removeFromList` is true.<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = new OccurrenceList<string>();
occurrences.Add("hello", 53);

occurrences.RemoveAll("hello"); // Sets the occurrences of "hello" to 0
```
<hr />

### `OccurrenceList<T>.RemoveAllZeros()`
Removes all entries from the list where the number of occurences is equal to 0. This can be useful when looping with `foreach`, or when converting into dictionaries.<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = new OccurrenceList<string>();
occurrences.Add("hello", 53);
occurrences.Add("world", 24);

occurrences.RemoveAll("hello"); // "hello" to 0

occurrences.RemoveAllZeros(); // Removes all entries equal to 0 (so "hello")
// "hello" is no longer in the list (if used in enumeration)
```
<hr />

### `OccurrenceList<T>.GetCount(T item)`
Gets the number of times `item` occurs.<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = new OccurrenceList<string>();
occurrences.Add("hello", 53);

occurrences.GetCount("hello"); // returns 53
```
<hr />

### `OccurrenceList<T>.IsEmpty()`
Returns whether or not the `OccurrenceList<T>` has any items in it. All entries with a count of 0 are disregarded.<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = new OccurrenceList<string>();
occurrences.Add("hello", 32);

occurrences.IsEmpty(); // returns false

occurrences.RemoveAll("hello");

occurrences.IsEmpty(); // returns true
```
<hr />

### `OccurrenceList<T>.GetFirst()`
Returns the first element in the `OccurrenceList<T>` in `KeyValuePair<T, int>` form. Throws a `IndexOutOfRangeException` if the `OccurrenceList<t>` is empty.<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = new OccurrenceList<string>();
occurrences.Add("hello", 32);
occurrences.Add("world", 24);

occurrences.GetFirst(); // returns KeyValuePair<"hello", 32>
```
<hr />

### `OccurrenceList<T>.ToDictionary()`
Converts the `OccurrenceList<T>` to a `Dictionary<T,int>`<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = new OccurrenceList<string>();
occurrences.Add("hello", 53);
occurrences.Add("world", 32);

occurrences.ToDictionary(); /* returns
{
	{ "hello", 53 },
	{ "world", 32 }
}
*/
```
<hr />

### `OccurrenceList<T>.Clear()`
Clears the `OccurrenceList<T>`. This *completely removes* all elements in the `OccurenceList<T>`.<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = new OccurrenceList<string>();
occurrences.Add("hello", 53);
occurrences.Add("world", 32);

occurences.Clear();

occurrences.IsEmpty(); // returns true
```
<hr />

### `static OccurrenceList<T> CreateFromEnumerable(IEnumerable enumerable)`
Creates an `OccurrenceList<T>` from the provided `IEnumerable`.<br />
<br />
**Example**
```cs
OccurrenceList<string> occurrences = OccurrenceList<string>.CreateFromEnumerable(new string[] { 
	"hello", 
	"world", 
	"hello", 
	"there", 
	"hello" 
});

occurrences.GetCount("hello"); // returns 3
occurrences.GetCount("world"); // returns 1
```
