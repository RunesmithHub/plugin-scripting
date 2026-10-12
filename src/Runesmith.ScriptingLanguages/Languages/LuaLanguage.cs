using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ScriptingLanguages.Languages;

/// <summary>Lua: its files, highlighting, comments and brackets.</summary>
public sealed class LuaLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Lua { get; } = new("lua", "Lua")
    {
        Extensions = [".lua"],
        ScopeName = "source.lua",
        LineComment = "--",
        BlockComment = ("--[[", "]]"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition LuaGrammar { get; } = GrammarFiles.Find("source.lua", "lua/lua.tmLanguage.json");
}
