using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ScriptingLanguages.Languages;

/// <summary>Ruby: its files, highlighting, comments and brackets.</summary>
public sealed class RubyLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Ruby { get; } = new("ruby", "Ruby")
    {
        Extensions = [".rb", ".rbx", ".rjs", ".gemspec", ".rake", ".ru", ".erb", ".podspec", ".rbi"],
        FileNames =
        [
            "rakefile", "gemfile", "guardfile", "podfile", "capfile", "cheffile", "hobofile", "vagrantfile", "appraisals", "rantfile",
            "berksfile", "berksfile.lock", "thorfile", "puppetfile", "dangerfile", "brewfile", "fastfile", "appfile", "deliverfile",
            "matchfile", "scanfile", "snapfile", "gymfile",
        ],
        ScopeName = "source.ruby",
        LineComment = "#",
        BlockComment = ("=begin", "=end"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition RubyGrammar { get; } = GrammarFiles.Find("source.ruby", "ruby/ruby.tmLanguage.json");
}
