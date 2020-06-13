using System.IO;

namespace TempFolder {
    public static class TempFolderFactory {
        /// <summary>
        /// Create temporary folder in the current user's temporary folder
        /// </summary>
        /// <returns>New instance of temporary folder</returns>
        public static TempFolder Create() {
            var path = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName())).FullName;
            return Create(path);
        }
        
        /// <summary>
        /// Create temporary folder by path
        /// </summary>
        /// <param name="path">Temporary folder path</param>
        /// <returns>New instance of temporary folder</returns>
        public static TempFolder Create(string path) {
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            
            return new TempFolder(path);
        }
    }
}
