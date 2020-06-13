# TempFolder
Using
```
using (var temp = TempFolderFactory.Create()) {
  var tempPath = temp.Path;
  
  <do something>
}
```

Temp folder will be deleted automatically after using block exit
