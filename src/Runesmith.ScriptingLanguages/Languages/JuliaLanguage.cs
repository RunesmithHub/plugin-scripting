using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ScriptingLanguages.Languages;

/// <summary>Julia: its files, highlighting, comments and brackets.</summary>
public sealed class JuliaLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Julia { get; } = new("julia", "Julia")
    {
        Extensions = [".jl"],
        ScopeName = "source.julia",
        LineComment = "#",
        BlockComment = ("#=", "=#"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition JuliaGrammar { get; } = GrammarFiles.Find("source.julia", "julia/julia.tmLanguage.json");
}
