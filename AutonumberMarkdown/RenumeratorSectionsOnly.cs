using System.Text.RegularExpressions;

namespace AutonumberMarkdown
{
	class RenumeratorSectionsOnly : IRenumerator
	{
		static readonly RegexOptions options = RegexOptions.Multiline | RegexOptions.Compiled | RegexOptions.CultureInvariant;
		static readonly Regex SectionMarkerRegex = new Regex("^(?<level>#+)\\s+(\\d|\\.)*\\s*(?<title>.*)", options);

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

		string Nextsection()
		{
			subsection = 0;
			sub2section = 0;
			sub3section = 0;
			return $"{++section}.";
		}

		string Nextsubsection()
		{
			sub2section = 0;
			sub3section = 0;
			return $"{section}.{++subsection}.";
		}

		string Nextsub2section()
		{
			sub3section = 0;
			return $"{section}.{subsection}.{++sub2section}.";
		}

		string Nextsub3section()
		{
			return $"{section}.{subsection}.{sub2section}.{++sub3section}.";
		}
	}
}