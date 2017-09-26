using System.Text.RegularExpressions;

namespace AutonumberMarkdown
{
    class Renumerator
    {
        static readonly RegexOptions options = RegexOptions.Multiline | RegexOptions.Compiled | RegexOptions.CultureInvariant;
        static readonly Regex SectionMarkerRegex = new Regex("^(?<level>#+)( |\t)+(\\d|\\.)*\\s+(?<title>.*)",  options);

        int chapter;
        int section;
        int subsection;
        int sub2section;
        int sub3section;

        public string[] ProcessFile(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                var match = SectionMarkerRegex.Match(line);
                if (match.Success)
                {
                    lines[i] = SectionMarkerRegex.Replace(line, m =>
                    {
                        var level = m.Groups["level"].Value;
                        var title = m.Groups["title"].Value;

                        switch (level)
                        {
                            case "#":
                                return $"{level} {Nextchapter()} {title}";
                            case "##":
                                return $"{level} {Nextsection()} {title}";
                            case "###":
                                return $"{level} {Nextsubsection()} {title}";
                            case "####":
                                return $"{level} {Nextsub2section()} {title}";
                            case "#####":
                                return $"{level} {Nextsub3section()} {title}";
                            default:
                                return line;
                        }
                    });
                }
            }

            return lines;
        }

        string Nextchapter()
        {
            section = 0;
            subsection = 0;
            sub2section = 0;
            sub3section = 0;
            var res = ++chapter + ".";
            return res;
        }

        string Nextsection()
        {
            subsection = 0;
            sub2section = 0;
            sub3section = 0;
            return $"{chapter}.{++section}";
        }

        string Nextsubsection()
        {
            sub2section = 0;
            sub3section = 0;
            return $"{chapter}.{section}.{++subsection}";
        }

        string Nextsub2section()
        {
            sub3section = 0;
            return $"{chapter}.{section}.{subsection}.{++sub2section}";
        }

        string Nextsub3section()
        {
            return $"{chapter}.{section}.{subsection}.{sub2section}.{++sub3section}";
        }
    }
}