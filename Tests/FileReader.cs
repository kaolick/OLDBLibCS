using System.IO;
using NUnit.Framework;

namespace OLDBLibCS.Tests
{
    public static class FileReader
    {
        public static string ReadTextFromFile(string fileName)
        {
            var testDirectoryPath = TestContext.CurrentContext.TestDirectory;
            var resourcesPath = Path.Combine(testDirectoryPath, "../../Resources");
            var filePath = Path.Combine(resourcesPath, fileName);

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"No file for path {filePath} found!");

            var text = File.ReadAllText(filePath);
            return text;
        }
    }
}
