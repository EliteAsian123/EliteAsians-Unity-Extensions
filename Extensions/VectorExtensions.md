# VectorExtensions
This extension class adds additional functionality to the `Vector2`, `Vector3`, `Vector2Int` and `Vector3Int` classes. Here are some quick examples of what it can do:

```cs
// Simple Vector to VectorInt conversions

Vector2 vector2 = new Vector2(2f, 4.2f);

vector2.ToVector2Int(); // returns Vector2Int(2, 4);

Vector3 vector3 = new Vector3(5.2f, 3f, -1f);

vector3.ToVector3Int(); // returns Vector3Int(5, 3, -1);

// With and Add

Vector3 ourVector = new Vector3(4.3f, -3.5f, 0.2f);

ourVector.WithX(41f); // returns Vector3(41f, -3.5f, 0.2f);
ourVector.WithZ(84f); // returns Vector3(4.3f, -3.5f, 84f);

ourVector.AddX(100f); // returns Vector3(104.3f, -3.5f, 0.2f);
ourVector.AddY(100f); // returns Vector3(4.3f, 96.5f, 0.2f);

// Invert

Vector2 myVector = new Vector2(1f, 1f);

myVector.Invert(); // returns Vector2(-1f, -1f);

myVector.InvertX(); // returns Vector2(-1f, 1f);
myVector.InvertY(); // returns Vector2(1f, -1f);
```

## Installation Guide
To install VectorExtensions, clone this repository and put the [`VectorExtensions.cs`](./VectorExtensions.cs) file into your Unity project. That's it!

## Reference
### `Vector2.WithX(float x)`
Replaces the X component of a Vector2 with the specified value (`x`).<br />
<br />
**Example**
```cs
Vector2 myVector = new Vector2(1f, 1f);
myVector.WithX(8f); // returns Vector2(8f, 1f);
```
<hr />

### `Vector2.WithY(float y)`
Replaces the Y component of a Vector2 with the specified value (`y`).<br />
<br />
**Example**
```cs
Vector2 myVector = new Vector2(1f, 1f);
myVector.WithY(8f); // returns Vector2(1f, 8f);
```
<hr />

### `Vector2.AddX(float x)`
Adds to the X component of a Vector2 with the specified value (`x`).<br />
<br />
**Example**
```cs
Vector2 myVector = new Vector2(2f, 2f);
myVector.AddX(8f); // returns Vector2(10f, 2f);
```
<hr />

### `Vector2.AddY(float y)`
Adds to the Y component of a Vector2 with the specified value (`y`).<br />
<br />
**Example**
```cs
Vector2 myVector = new Vector2(2f, 2f);
myVector.AddY(8f); // returns Vector2(2f, 10f);
```
<hr />

### `Vector2.InvertX()`
Inverts the X component of a Vector2.<br />
<br />
**Example**
```cs
Vector2 myVector = new Vector2(2f, 2f);
myVector.InvertX(); // returns Vector2(-2f, 2f);
```
<hr />

### `Vector2.InvertY()`
Inverts the Y component of a Vector2.<br />
<br />
**Example**
```cs
Vector2 myVector = new Vector2(2f, 2f);
myVector.InvertY(); // returns Vector2(2f, -2f);
```
<hr />

### `Vector2.Invert()`
Inverts both the X and the Y component of a Vector2.<br />
<br />
**Example**
```cs
Vector2 myVector = new Vector2(2f, 2f);
myVector.Invert(); // returns Vector2(-2f, -2f);
```
<hr />

### `Vector3.WithX(float x)`
Replaces the X component of a Vector3 with the specified value (`x`).<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(1f, 1f, 1f);
myVector.WithX(8f); // returns Vector3(8f, 1f, 1f);
```
<hr />

### `Vector3.WithY(float y)`
Replaces the Y component of a Vector3 with the specified value (`y`).<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(1f, 1f, 1f);
myVector.WithY(8f); // returns Vector3(1f, 8f, 1f);
```
<hr />

### `Vector3.WithZ(float z)`
Replaces the Z component of a Vector3 with the specified value (`z`).<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(1f, 1f, 1f);
myVector.WithZ(8f); // returns Vector3(1f, 1f, 8f);
```
<hr />

### `Vector3.AddX(float x)`
Adds to the X component of a Vector3 with the specified value (`x`).<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(2f, 2f, 2f);
myVector.AddX(8f); // returns Vector3(10f, 2f, 2f);
```
<hr />

### `Vector3.AddY(float y)`
Adds to the Y component of a Vector3 with the specified value (`y`).<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(2f, 2f, 2f);
myVector.AddY(8f); // returns Vector3(2f, 10f, 2f);
```
<hr />

### `Vector3.AddZ(float z)`
Adds to the Z component of a Vector3 with the specified value (`z`).<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(2f, 2f, 2f);
myVector.AddZ(8f); // returns Vector3(2f, 2f, 10f);
```
<hr />

### `Vector3.InvertX()`
Inverts the X component of a Vector3.<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(2f, 2f, 2f);
myVector.InvertX(); // returns Vector3(-2f, 2f, 2f);
```
<hr />

### `Vector3.InvertY()`
Inverts the Y component of a Vector3.<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(2f, 2f, 2f);
myVector.InvertY(); // returns Vector3(2f, -2f, 2f);
```
<hr />

### `Vector3.InvertZ()`
Inverts the Z component of a Vector3.<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(2f, 2f, 2f);
myVector.InvertZ(); // returns Vector3(2f, 2f, -2f);
```
<hr />

### `Vector3.Invert()`
Inverts the X, Y and Z components of a Vector3.<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(2f, 2f, 2f);
myVector.Invert(); // returns Vector3(-2f, -2f, -2f);
```
<hr />

### `Vector2Int.WithX(int x)`
Replaces the X component of a Vector2Int with the specified value (`x`).<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(1, 1);
myVector.WithX(8); // returns Vector2Int(8, 1);
```
<hr />

### `Vector2Int.WithY(int y)`
Replaces the Y component of a Vector2Int with the specified value (`y`).<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(1, 1);
myVector.WithY(8); // returns Vector2Int(1, 8);
```
<hr />

### `Vector2Int.AddX(int x)`
Adds to the X component of a Vector2Int with the specified value (`x`).<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(2, 2);
myVector.AddX(8); // returns Vector2Int(10, 2);
```
<hr />

### `Vector2Int.AddY(int y)`
Adds to the Y component of a Vector2Int with the specified value (`y`).<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(2, 2);
myVector.AddY(8); // returns Vector2Int(2, 10);
```
<hr />

### `Vector2Int.InvertX()`
Inverts the X component of a Vector2Int.<br />
<br />
**Example**
```cs
Vector2Int myVector = newVector2IntVector2(2, 2);
myVector.InvertX(); // returns Vector2Int(-2, 2);
```
<hr />

### `Vector2Int.InvertY()`
Inverts the Y component of a Vector2Int.<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(2, 2);
myVector.InvertY(); // returns Vector2Int(2, -2);
```
<hr />

### `Vector2Int.Invert()`
Inverts both the X and the Y component of a Vector2Int.<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(2, 2);
myVector.Invert(); // returns Vector2Int(-2, -2);
```
<hr />

### `Vector3Int.WithX(int x)`
Replaces the X component of a Vector3Int with the specified value (`x`).<br />
<br />
**Example**
```cs
Vector3Int myVector = new Vector3Int(1, 1, 1);
myVector.WithX(8); // returns Vector3Int(8, 1, 1);
```
<hr />

### `Vector3Int.WithY(int y)`
Replaces the Y component of a Vector3Int with the specified value (`y`).<br />
<br />
**Example**
```cs
Vector3Int myVector = new Vector3Int(1, 1, 1);
myVector.WithY(8); // returns Vector3Int(1, 8, 1);
```
<hr />

### `Vector3Int.WithZ(int z)`
Replaces the Z component of a Vector3Int with the specified value (`z`).<br />
<br />
**Example**
```cs
Vector3Int myVector = new Vector3Int(1, 1, 1);
myVector.WithZ(8); // returns Vector3Int(1, 1, 8);
```
<hr />

### `Vector3Int.AddX(int x)`
Adds to the X component of a Vector3Int with the specified value (`x`).<br />
<br />
**Example**
```cs
Vector3Int myVector = new Vector3Int(2, 2, 2);
myVector.AddX(8); // returns Vector3Int(10, 2, 2);
```
<hr />

### `Vector3Int.AddY(int y)`
Adds to the Y component of a Vector3Int with the specified value (`y`).<br />
<br />
**Example**
```cs
Vector3Int myVector = new Vector3Int(2, 2, 2);
myVector.AddY(8); // returns Vector3Int(2, 10, 2);
```
<hr />

### `Vector3Int.AddZ(int z)`
Adds to the Z component of a Vector3Int with the specified value (`z`).<br />
<br />
**Example**
```cs
Vector3Int myVector = new Vector3Int(2, 2, 2);
myVector.AddZ(8); // returns Vector3Int(2, 2, 10);
```
<hr />

### `Vector3Int.InvertX()`
Inverts the X component of a Vector3Int.<br />
<br />
**Example**
```cs
Vector3Int myVector = Vector3Int Vector3(2, 2, 2);
myVector.InvertX(); // returns Vector3Int(-2, 2, 2);
```
<hr />

### `Vector3Int.InvertY()`
Inverts the Y component of a Vector3Int.<br />
<br />
**Example**
```cs
Vector3Int myVector = new Vector3Int(2, 2, 2);
myVector.InvertY(); // returns Vector3Int(2, -2, 2);
```
<hr />

### `Vector3Int.InvertZ()`
Inverts the Z component of a Vector3Int.<br />
<br />
**Example**
```cs
Vector3Int myVector = new Vector3Int(2, 2, 2);
myVector.InvertZ(); // returns Vector3Int(2, 2, -2);
```
<hr />

### `Vector3Int.Invert()`
Inverts the X, Y and Z components of a Vector3Int.<br />
<br />
**Example**
```cs
Vector3Int myVector = new Vector3Int(2, 2, 2);
myVector.Invert(); // returns Vector3Int(-2, -2, -2);
```
<hr />

### `Vector2Int.ToVector3()`
Converts a Vector2Int into a Vector3.<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(1, 4);
myVector.ToVector3(); // returns Vector3(1f, 4f, 0f);
```
<hr />

### `Vector3Int.ToVector3()`
Converts a Vector3Int into a Vector3.<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(1, 4, -5);
myVector.ToVector3(); // returns Vector3(1f, 4f, -5f);
```
<hr />

### `Vector2Int.ToVector2()`
Converts a Vector2Int into a Vector2.<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(1, 4);
myVector.ToVector2(); // returns Vector2(1f, 4f);
```
<hr />

### `Vector3Int.ToVector2()`
Converts a Vector3Int into a Vector2.<br />
<br />
**Example**
```cs
Vector2Int myVector = new Vector2Int(1, 4, -5);
myVector.ToVector2(); // returns Vector2(1f, 4f);
```
<hr />

### `Vector3.ToVector3Int()`
Converts a Vector3 into a Vector3Int.<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(-2.3f, 5f, 7f);
myVector.ToVector3Int(); // returns Vector3Int(-2, 5, 7);
```
<hr />

### `Vector2.ToVector3Int()`
Converts a Vector2 into a Vector3Int.<br />
<br />
**Example**
```cs
Vector2 myVector = new Vector2(-2.3f, 5f);
myVector.ToVector3Int(); // returns Vector3Int(-2, 5, 0);
```
<hr />

### `Vector3.ToVector2Int()`
Converts a Vector3 into a Vector2Int.<br />
<br />
**Example**
```cs
Vector3 myVector = new Vector3(-2.3f, 5f, 7f);
myVector.ToVector2Int(); // returns Vector2Int(-2, 5);
```
<hr />

### `Vector2.ToVector2Int()`
Converts a Vector2 into a Vector2Int.<br />
<br />
**Example**
```cs
Vector2 myVector = new Vector2(-2.3f, 5f);
myVector.ToVector2Int(); // returns Vector2Int(-2, 5);
```
