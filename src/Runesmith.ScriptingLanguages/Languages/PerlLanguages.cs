using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ScriptingLanguages.Languages;

/// <summary>Perl and Perl 6: their files, highlighting, comments and brackets.</summary>
public sealed class PerlLanguages
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Perl { get; } = new("perl", "Perl")
    {
        Extensions = [".pl", ".pm", ".pod", ".t", ".PL", ".psgi"],
        ScopeName = "source.perl",
        LineComment = "#",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Perl6 { get; } = new("perl6", "Perl 6")
    {
        Extensions = [".p6", ".pl6", ".pm6", ".nqp"],
        ScopeName = "source.perl.6",
        LineComment = "#",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition PerlGrammar { get; } = GrammarFiles.Find("source.perl", "perl/perl.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition Perl6Grammar { get; } = GrammarFiles.Find("source.perl.6", "perl/perl6.tmLanguage.json");
}
