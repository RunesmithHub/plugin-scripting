using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ScriptingLanguages.Languages;

/// <summary>Clojure: its files, highlighting, comments and brackets.</summary>
public sealed class ClojureLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Clojure { get; } = new("clojure", "Clojure")
    {
        Extensions = [".clj", ".cljs", ".cljc", ".cljx", ".clojure", ".edn"],
        ScopeName = "source.clojure",
        LineComment = ";;",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition ClojureGrammar { get; } = GrammarFiles.Find("source.clojure", "clojure/clojure.tmLanguage.json");
}
