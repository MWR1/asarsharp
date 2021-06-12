
namespace AsarSharp.Utils
{
    class Constants
    {
        public enum ArchivingStep
        {
            TemporaryFileCreation = 0,
            DirectoryStructureCreation = 1,
            ArchiveCreation = 2,
            ArchiveHeaderWrite = 3,
            ArchiveContentsWrite = 4,
        }

        public enum ExtractionStep
        {
            ArchiveHeaderFetch = 0,
            DirectoryStructureFetch = 1,
            ExtractionDataFetchSuccess = 2,
            ActualExtraction = 3,
            SymlinkHandling = 4,
            ExtractionSuccess = 5
        }

        private static readonly string[] _archivingSteps = {
            "Creating temporary file for holding the archive data...",
            "Creating the directory structure and writing the file contents to the temporary file (may take a while)...",
            "Creating archive...",
            "Writing the archive header...",
            "Writing the archive contents (may take a while)...",
        };

        private static readonly string[] _extractionSteps =
        {
            "Getting archive data...",
            "Getting folder structure...",
            "All data needed for extraction has been obtained.",
            "Extracting...",
            "Handling symlinks...",
            "The archive has been successfully extracted!",
        };

        public static string GetStep(ArchivingStep step) => _archivingSteps[(ushort)step];
        public static string GetStep(ExtractionStep step) => _extractionSteps[(ushort)step];

        public class AsarExceptions
        {
            public const string insufficientHeaderBytes = "The header of this archive doesn't have the required amount of bytes.";
            public const string invalidArchiveFilePath = "The path to the archive is not an .asar file. It must end in .asar";
            public const string failedTypeConversion = "Could not convert the file offset from string to uint.";
            public const string archiveDirectoryMissing = "The given directory path from which to create the archive doesn't exist.";
            public const string archiveFileMissing = "The archive file from which to extract the files doesn't exist.";
            public const string symlinkMissing = "There's a symbolic link in this archive that points to a file or directory that doesn't exist.";
        }
    }
}
