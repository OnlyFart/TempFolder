using System.IO;
using NUnit.Framework;

namespace TempFolder.Tests {
    public class TempFolderFactoryTests {
        [Test]
        public void CreateDefaultTest() {
            var path = string.Empty;
            
            using (var temp = TempFolderFactory.Create()) {
                path = temp.Path;
                Assert.IsTrue(Directory.Exists(path));
            }
            
            Assert.IsFalse(Directory.Exists(path));
        }
        
        [Test]
        public void CreateByPathTest() {
            var path = "Test";

            if (Directory.Exists(path)) {
                Directory.Delete(path, true);
            }
            
            using (var temp = TempFolderFactory.Create(path)) {
                path = temp.Path;
                Assert.IsTrue(Directory.Exists(path));
            }
            
            Assert.IsFalse(Directory.Exists(path));
        }
    }
}
