# TestDriven.Net 4

## The latest build of TestDriven.Net 4.0-beta3 is available: http://testdriven.net/download.aspx - [release notes](https://github.com/jcansdale/TestDriven.Net-Issues/blob/master/ReleaseNotes.md)

### It includes support for .NET Core 1.0 and Visual Studio 2017 RC versons.

![Test With](images/testwith.png)

project.json / .xproj support works as follows:

- `'Run Test(s)'` and `'Test With > Debugger'` will run or debug using the first framework defined in `project.json`
- `'Test With > .NET Core'` will run using the first defined .NET Core framework (e.g. `netcoreapp1.0`) 
- `'Test With > .NET Framework'` will use the first non-Core framework defined in `project.json` (e.g. `net35` or `net451`)
- If a `testRunner` is defined, .NET Core and .NET Framework tests will be executed using `dotnet-test-xunit` or `-nunit`.

I've added some example .NET Core and multi-framework projects to this repo:
https://github.com/jcansdale/TestDriven.Net-Issues/tree/master/ExampleProjects/xproj
 
I'm using this repository for issue tracking.

Feel free to add [issues](https://twitter.com/jcansdale), feature [suggestions](https://twitter.com/jcansdale) or tweet me!

Jamie Cansdale

![Follow Jamie](https://img.shields.io/twitter/follow/jcansdale.svg?style=social)
