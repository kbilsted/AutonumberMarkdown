using System.IO;
using System.Text;

namespace AutonumberMarkdown
{
    class FileRepository
    {
        public string[] Readfile(string path)
        {
            var lines = File.ReadAllLines(path, Encoding.UTF8);
            return lines;
        }

        public void SaveFileWithBackup(string path, string[] content)
        {
            File.Move(path, path + ".bak");
            File.WriteAllLines(path, content, Encoding.UTF8);
        }
    }
}