using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ScriptingLanguages.Languages;

/// <summary>R: its files, highlighting, comments and brackets.</summary>
public sealed class RLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition R { get; } = new("r", "R")
    {
        Extensions = [".r", ".rhistory", ".rprofile", ".rt"],
        ScopeName = "source.r",
        LineComment = "#",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition RGrammar { get; } = GrammarFiles.Find("source.r", "r/r.tmLanguage.json");
}
