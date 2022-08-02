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
using AsarExtractor extractor = new(pathToArchive, pathToWhereToExtract)
extractor.Extract();
```

# Options
### Archiving


##### `ArchivingOptions` in namespace `AsarSharp.Utils.Types`
</table>
<table>
<th>Option</th>
<th>Type</th>
<th>What it does</th>
<tr>
<td><code>MatchBasename</code></td>
<td>bool</td>
<td>Match against the filename of the path. So basically, for <code>path/to/file.txt</code>, <code>*.txt</code> will match.</td>
<tr>
<td><code>Unpack</code></td>
<td>string[]</td>
<td>List of globs to match against every file archived. It represents the argument received from the <code>--unpack</code> flag from asar.</td>
</tr>
</table>

### Remarks
- This library logs additional data when built in debug mode.
- Because symlinks require admin privileges in order to be created, it's not suitable for this library to ask for such
privileges in order to run. Therefore, every symlink will be replaced with the file or directory it points to.

## Contact
If you want to contact the original developer of this library, here's their Discord server: https://discord.gg/Bd2JnFB