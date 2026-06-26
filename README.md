# LunaLib
A utility library to make my life easier, use it if you want.

## Features:
Features of LunaLib, and what they do.

### Json
`using LunaLib.Json;` <br>
`Serializer.Save(Dictionary<string, object> data, string path)` This saves a dictionary to the path (if path doesn't exist then it makes it) <br>
`Serializer.Load(string path)` returns dictionary of path <br>

### Math
`using LunaLib.Math;` <br>
`Simple.`
- `Add(params object[] nums)`
- `Subtract(params object[] nums)`
- `Multiply(params object[] nums)`
- `Divide(params object[] nums)`
<br>

`Randomness.CoinFlip()` returns a 50/50 chance either it landed on true or false <br>
`Randomness.OneIn(int number)` 1/number chance to return true <br>

<EOF>