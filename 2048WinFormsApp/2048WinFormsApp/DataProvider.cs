using System.Text;

namespace _2048WinFormsApp
{
    public static class DataProvider
    {
        public static string Rules = "rules.txt";
        public static string Results = "results.json";
        static string PathDirectory = $@"..\..\..\..\data";

        public static void ExistsDirectory()
        {
            if (!Directory.Exists(PathDirectory))
            {
                Directory.CreateDirectory(PathDirectory);
            }
        }
        public static void ExistsFile(string fileName)
        {
            ExistsDirectory();
            if (!File.Exists($@"{PathDirectory}\{fileName}"))
            {
                using (File.Create($@"{PathDirectory}\{fileName}")) { }
            }
        }
        /// <summary>
        /// Writes or Rewrites data in file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="value"></param>
        /// <param name="append">"true" - Append data, "false" - Rewrite data</param>
        public static void Write(string fileName, string value, bool append)
        {
            ExistsDirectory();
            ExistsFile(fileName);
            using (var writer = new StreamWriter($@"{PathDirectory}\{fileName}", append, Encoding.UTF8))
            {
                writer.WriteLine(value);
            }
        }
        public static string ReadAll(string fileName)
        {
            ExistsDirectory();
            ExistsFile(fileName);
            using (var reader = new StreamReader($@"{PathDirectory}\{fileName}", Encoding.UTF8))
            {
                var fileData = reader.ReadToEnd();
                return fileData;
            }
        }
        public static void ShowText(string fileName, string title)
        {
            var text = ReadAll(fileName);
            MessageBox.Show(text, title, MessageBoxButtons.OK);
        }
    }
}