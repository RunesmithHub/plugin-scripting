using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ScriptingLanguages.Languages;

/// <summary>Python: its files, highlighting, comments and brackets.</summary>
public sealed class PythonLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Python { get; } = new("python", "Python")
    {
        Extensions = [".py", ".rpy", ".pyw", ".cpy", ".gyp", ".gypi", ".pyi", ".ipy", ".pyt"],
        FileNames = ["Snakefile", "SConstruct", "SConscript"],
        ScopeName = "source.python",
        LineComment = "#",
        BlockComment = ("\"\"\"", "\"\"\""),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition PythonGrammar { get; } = GrammarFiles.Find("source.python", "python/MagicPython.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition SourceRegexpPythonGrammar { get; } = GrammarFiles.Find("source.regexp.python", "python/MagicRegExp.tmLanguage.json");
}
