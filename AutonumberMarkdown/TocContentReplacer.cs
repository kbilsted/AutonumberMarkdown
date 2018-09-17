using System.Text.RegularExpressions;

namespace AutonumberMarkdown
{
	public class TocContentReplacer
	{
		static readonly string title = @"(T|t)able (O|o)f (C|c)ontent\s*(\r?\n)+";
		static readonly string tocline = @"(\s*\*[^\n]*\n)*";

		static readonly Regex TocRex = new Regex(title + tocline, RegexOptions.Singleline | RegexOptions.Compiled);

		public string TryReplaceToc(string content, string newToc)
		{
			var match = TocRex.Match(content);
			if (!match.Success)
				return null;

			return content.Substring(0, match.Index)
			       + newToc
			       + content.Substring(match.Index + match.Length);
		}
	}
}