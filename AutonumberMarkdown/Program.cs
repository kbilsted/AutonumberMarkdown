using System;

namespace AutonumberMarkdown
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Need parameters. Syntax:\nAutonumberMarkdown [--sectionsOnly] <filename>");
                return;
            }

	        IRenumerator renumerationLogic;
	        int argP = 0;
	        if (args[argP] == "--sectionsOnly")
	        {
		        argP++;
				renumerationLogic = new RenumeratorSectionsOnly();
			}
	        else
	        {
				renumerationLogic = new Renumerator();
			}

	        var path = args[argP];

			var filerepo = new FileRepository();
	        var newfile = renumerationLogic.ProcessFile(filerepo.Readfile(path));
            filerepo.SaveFileWithBackup(path, newfile);
        }
    }
}
