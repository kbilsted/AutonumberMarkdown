using System;

namespace AutonumberMarkdown
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Need parameters. Syntax:\nAutonumberMarkdown <filename>");
                return;
            }
            var path = args[0];

            var filerepo = new FileRepository();
            var renumerationLogic = new Renumerator();

            var newfile = renumerationLogic.ProcessFile(filerepo.Readfile(path));
            filerepo.SaveFileWithBackup(path, newfile);
        }
    }
}
