using System;

namespace AutonumberMarkdown
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Need parameters. Syntax:\nAutonumberMarkdown [--sectionsOnly] [--makeToc] <filename>");
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

	        bool makeToc = false;
	        if (args[argP] == "--makeToc")
	        {
		        makeToc = true;
		        argP++;
	        }

			var path = args[argP];

			var filerepo = new FileRepository();
	        var newfile = renumerationLogic.ProcessFile(filerepo.Readfile(path));

	        if (makeToc)
	        {
		        var content = string.Join("\n", newfile);
		        var newToc = new TocCreator().Execute(content);
		        newfile = new TocContentReplacer()
			        .TryReplaceToc(content, newToc)
			        .Split('\n');
	        }

            filerepo.SaveFileWithBackup(path, newfile);
        }
    }
}
