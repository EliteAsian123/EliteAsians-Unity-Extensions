# ListExtensions
This extension class adds additional functionality to the `IList<T>` interface. This is implemented in `List<T>`, arrays and others.

```cs
// Pick

int[] array = new int[] { 1, 2, 3, 4, 5 };

Debug.Log(arr.Pick()); // Outputs a random element of this array (example: "3")

// Shuffle

arr.Shuffle(); // Shuffles/randomizes the array

foreach (int i in arr) { // Outputs the shuffled/randomized array (example: "2 3 5 1 4")
	Debug.Log(i);
}

// These also works with List<T>!

List<int> list = new List<int>() { 10, 20, 30, 40, 50 };

Debug.Log(list.Pick()); // Outputs a random element of this list (example: "50")
```

## Installation Guide
To install ListExtensions, clone this repository and put the [`ListExtensions.cs`](https://github.com/EliteAsian123/EliteAsians-Unity-Extensions/blob/master/ListExtensions.cs) file into your Unity project. That's it!

## Reference
### `IList.Shuffle()`
Shuffles the `IList` using Unity's random class. This DOES modify the `IList`.<br />
<br />
**Example**
```cs
int[] myArray = new int[] { 1, 2, 3 };
myArray.Shuffle();

foreach (int i in myArray) { // Prints out the array but shuffled/randomized (example: "3 1 2")
	Debug.Log(i);
}
```
<hr />

### `IList.Shuffle(System.Random random)`
Shuffles the `IList` using `System.Random`. This DOES modify the `IList`.<br />
<br />
**Example**
```cs
int[] myArray = new int[] { 1, 2, 3 };
myArray.Shuffle(new System.Random());

foreach (int i in myArray) { // Prints out the array but shuffled/randomized (example: "3 1 2")
	Debug.Log(i);
}
```
<hr />

### `IList.Pick()`
Picks a randoms element of the `IList` using Unity's random class. Does not modify the `IList`.<br />
<br />
**Example**
```cs
int[] myArray = new int[] { 1, 2, 3 };
myArray.Pick(); // returns "1", "2", or "3"
```
<hr />

### `IList.Pick(System.Random random)`
Picks a randoms element of the `IList` using `System.Random`. Does not modify the `IList`.<br />
<br />
**Example**
```cs
int[] myArray = new int[] { 1, 2, 3 };
myArray.Pick(new System.Random()); // returns "1", "2", or "3"
```