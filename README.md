# TempFolder

[![NuGet version (TempFolder)](https://img.shields.io/nuget/v/TempFolder.svg?style=flat-square)](https://www.nuget.org/packages/TempFolder/)

Using
```csharp
using (var temp = TempFolderFactory.Create()) {
  var tempPath = temp.Path;
  
  <do something>
}
```

Temp folder will be deleted automatically after using block exit
