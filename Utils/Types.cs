namespace AsarSharp.Utils
{
    public static class Types
    {
        public class ArchivingOptions
        {
            /**
             * <summary>Match against the file name of the path.</summary>
             */
            public bool MatchBasename { get; init; } = false;

            /**
             * <summary>List of globs for file names to exclude from packing.</summary>
             */
            public string[] Unpack { get; init; } = null;
    
            // public string[] UnpackDir { get; init; } = null;
        }
    }
}
