# LunaLib
A utility library to make my life easier, use it if you want. <br>
[Releases](https://github.com/aidenh1613-commits/LunaLib/releases)

## Features:
Features of LunaLib, and what they do.

### Json
Make sure you have `Newtonsoft.Json` package in your project or you'll get an error! <br>
<br>
`using LunaLib.Json;` <br>
`Serializer.Save(Dictionary<string, object> data, string path)` This saves a dictionary to the path (if path doesn't exist then it makes it) <br>
`Serializer.Load(string path)` returns dictionary stored at path <br>

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

### Text
`using LunaLib.Text;` <br>
`ColorConsole.WriteLine(string text, ConsoleColor color)` and `ColorConsole.Write(string text, ConsoleColor color)` Like the normal Console.Write and Console.WriteLine except you can put color in the second param and do it all within one line! <br>

#### TranslationsKeeper:
This is a class that allows you to read a standard language file and get anything from it. <br>
Example of usage: <br>
Here is the example language file I'm using for this example:
```json
{
	"Program.Hello": "Hai, $%s!"
}
```
And here is the code to use this:
```csharp
TranslationsKeeper translations = new("lang/en_us.json". "lang/en_us.json"); // makes new translations from file en_us.json and the same fallback. the fallback should be the main translation file in case the current doesn't have the current key
Console.WriteLine(translations.GetTranslation("Program.Hello", ["David"])); // where that "$%s" was is replaced with "David"
// output is: Hai, David!
```
Pretty simple.

<EOF>
