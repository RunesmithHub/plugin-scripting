# Scripting Languages for Runesmith

The official Scripting Languages plugin for [Runesmith](https://github.com/RunesmithHub/Runesmith), `runesmith.scripting`. Runesmith knows no language by
itself; this plugin brings the basics of scripting languages: which files are theirs, their highlighting, their comments for **Toggle Comment**, and
the brackets the editor matches and closes.

Python, Ruby, Perl, Perl 6, Lua, R, Julia, Clojure.

It brings highlighting only. Completion, problems and builds for a language come from that language's own plugin. Where one of these
languages holds code of another, such as a script in a page, that code is highlighted when the plugin of its language is installed.

## Install

Install **Scripting Languages** from Runesmith's plugin manager (**Tools › Plugins**), or from its page on the plugin hub,
https://hub.runesmith.dev. It needs Runesmith with plugin API 0.2.0 or newer, and no capabilities.

## Build

You need the .NET SDK version in `global.json`. The Runesmith packages come from the plugin hub's feed, which `nuget.config` sets up.

```sh
dotnet build plugin-scripting.slnx -warnaserror
dotnet format plugin-scripting.slnx --verify-no-changes
dotnet test --solution plugin-scripting.slnx
```

`dotnet build src/Runesmith.ScriptingLanguages -t:InstallPlugin` installs your build into Runesmith's plugins folder; restart Runesmith to load it.

| Folder | What is there |
| --- | --- |
| `src/Runesmith.ScriptingLanguages/Languages` | One class per family of languages, with a `LanguageDefinition` for each language and a `GrammarDefinition` for each grammar. |
| `src/Runesmith.ScriptingLanguages/grammars` | The TextMate grammar files, one folder per family, copied beside the assembly when the plugin builds. |
| `tests/Runesmith.ScriptingLanguages.Tests` | Tests that every language has its grammar and that the highlighting engine reads each one. |

To add a language, add its grammar file and a class beside the others. A language that grows a plugin of its own, with an analyzer or a
build, belongs in that plugin, with its grammar.

## License

Apache-2.0. See [LICENSE](LICENSE) and [NOTICE](NOTICE). The grammars come from the extensions of Visual Studio Code and are MIT
licensed; [THIRD-PARTY-NOTICES.md](THIRD-PARTY-NOTICES.md) has the details.
