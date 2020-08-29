# EliteAsians Unity Extensions
This is a pack of scripts that contain extension methods that adds more functionality to existing Unity classes such as `Vector2` and `Vector3`. So far, this repository is quite small, but I will be adding different extensions over time.

## Extensions
- [VectorExtensions](https://github.com/EliteAsian123/EliteAsians-Unity-Extensions/blob/master/VectorExtensions.md) (Contains extension methods for `Vector2` and `Vector3`)

## Examples
Here are some examples of what this pack can do:

```cs
Vector3 myVector = new Vector3(1.4f, -56f, 0.642f);

myVector = myVector.AddX(0.6f).AddY(6f); // Adds 0.6f to X, and 6f to Y

Debug.Log(myVector); // Outputs "(2, -50, 0.642)"
Debug.Log(myVector.Invert()); // Outputs "(-2, 50, -0.642)"

Debug.Log(myVector.WithZ(0f)); // Outputs "(2, -50, 0)"

Vector3Int myVectorInt = myVector.ToVector3Int(); // Converts the Vector3 to a Vector3Int
```

## How to Install
To install these to your Unity project, simply clone this repository and plop the extension you like (any `.cs` file) into your project. That's it!

## License
This project uses a [MIT License](https://github.com/EliteAsian123/EliteAsians-Unity-Extensions/blob/master/LICENSE). Basically, you can use this in your game without permission, and you can modify as much as you want.

## Feature Requests and Issues
If you find an issue, or want to request a feature, create an issue in the [issues tab](https://github.com/EliteAsian123/EliteAsians-Unity-Extensions/issues).
