# AsarSharp
A simple library that lets you archive and extract asar files, in C#.

# Usage
This library exposes 2 disposable classes: `AsarArchiver` and `AsarExtractor`.

#### 📚 Archiving a directory/file 
```
using AsarArchiver archiver = new(pathToDirectoryOrFile, pathToArchive);
archiver.Archive();
```

#### 💥 Extracting an archive 
```
using AsarExtractor extractor = new(pathToArchive, pathToExtractLocation)
extractor.Extract();
```

### Remarks
This library logs additional data when built in debug mode.

## Contact
If you want to contact the original developer of this library, here's their Discord server: https://discord.gg/Bd2JnFB