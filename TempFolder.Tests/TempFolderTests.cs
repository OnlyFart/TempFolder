using System.IO;
using NUnit.Framework;

namespace TempFolder.Tests {
    public class TempFolderTests {
        [Test]
        public void Test() {
            var directory = Directory.CreateDirectory("Test");

            using (var tempFolder = new TempFolder(directory.FullName)) {
                
            }
            
            Assert.False(Directory.Exists(directory.FullName));
        }
    }
}
