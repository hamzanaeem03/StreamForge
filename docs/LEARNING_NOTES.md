# Learning Notes

The user's working notes while learning .NET through StreamForge. Keep entries short. LLMs should add to this file when a new difference or concept comes up, and prompt the user to write the interview explanations in their own words.

## .NET 6 (Playlist) vs .NET 10 (This Repo)

| Playlist (.NET 6) | This repo (.NET 10) | Notes |
|---|---|---|
| `app.UseStaticFiles()` | `app.MapStaticAssets()` + `.WithStaticAssets()` | Newer static file handling with build-time compression and fingerprinting. |
| `.sln` solution file | `.slnx` solution file | Same purpose, simpler XML format. `dotnet` CLI commands work the same. |
| Some videos may show `Startup.cs` | Everything lives in `Program.cs` | Minimal hosting model. `ConfigureServices` becomes `builder.Services...`; `Configure` becomes `app.Use...`. |
| EF Core 6 packages | EF Core 10 packages | Match package versions to `net10.0`. Core APIs (`DbContext`, migrations, LINQ queries) are the same. |
| Older C# features | C# 14 | Feel free to use `required` members, primary constructors, collection expressions, file-scoped namespaces. |

Add rows here as new differences show up.

## Concepts Learned

Format: concept, one-line explanation, where it's used in StreamForge.

- _(empty: add entries as you learn)_

## Interview Explanations

For each completed feature, write 3-5 sentences in your own words: what it does, how it works, and one tradeoff you made.

- _(empty: add after each feature)_
