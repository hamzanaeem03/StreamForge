# LLM Handoff

This is the first file an LLM should read after `README.md`.

## Project Identity

Project name: StreamForge.

Purpose: help the user learn .NET deeply enough to work on .NET systems professionally, while building a serious OTT-style portfolio project.

Main app style: ASP.NET Core MVC/Razor, not React.

Current status: documentation foundation plus an empty .NET solution skeleton that builds. No domain entities or features yet. Check `docs/PROGRESS.md` before assuming what exists.

## Required Reading Order

1. `README.md`
2. `docs/LLM_HANDOFF.md`
3. `docs/PROJECT_BRIEF.md`
4. `docs/ARCHITECTURE.md`
5. `docs/IMPLEMENTATION_GUIDE.md`
6. `docs/PROGRESS.md`
7. Relevant feature/domain docs for the task

## Learning Resources

- Main video course: "ASP.NET CORE 6 TUTORIALS" YouTube playlist: https://www.youtube.com/playlist?list=PLp_RsiLZjwQQ7CxVhnM4G8i5veEClNPfX
- The playlist targets .NET 6, but this repo uses .NET 10 (LTS). Concepts carry over; some syntax and templates differ.
- When playlist code and modern .NET disagree, official Microsoft Learn docs and current `dotnet new` templates win.
- Known differences are recorded in `docs/LEARNING_NOTES.md`. Add new ones there when you hit them.

## How To Teach The User

Default teaching style (the user can change this):

1. Before a feature, explain the concept briefly and map it to Node/MERN where useful (for example, `DbContext` is roughly a Mongoose connection plus models; EF Core migrations are like Prisma migrate).
2. Tell the user which playlist topic covers it, if any.
3. Let the user write the code. Give small, specific steps, and give hints before full solutions.
4. Review the user's code like a senior developer reviewing a PR: correctness, naming, .NET conventions, and why.
5. Write code directly only when the user asks, or for boilerplate with no learning value. When you do, explain the non-obvious lines.
6. After a feature, ask 2-3 interview-style questions about it and have the user add a short explanation to `docs/LEARNING_NOTES.md`.

## How To Help The User

- Treat this as a learning project, not just a code-generation task.
- Explain .NET concepts by connecting them to the user's Node/MERN background when helpful.
- Prefer implementing small, complete slices over huge unfinished scaffolds.
- Keep docs updated as part of any meaningful change.
- Do not assume chat history is available.
- Do not change project direction without updating the docs.

## Current Technical Direction

- .NET 10.
- ASP.NET Core MVC/Razor.
- EF Core with SQL Server.
- ASP.NET Core Identity.
- Docker Compose local environment.
- Dockerized FFmpeg worker.
- Redis for useful caching or coordination.
- Stripe test mode for subscriptions.
- Local mounted storage for uploaded and processed media.

## Current Build Priority

The next implementation step is to add the first domain model draft and EF Core persistence.

Build catalog/domain basics before Stripe or FFmpeg.

## Important Constraints

- Documentation is part of the product.
- Major decisions go in `docs/DECISIONS.md`.
- Completed work goes in `docs/PROGRESS.md`.
- Domain/schema changes go in `docs/DOMAIN_MODEL.md`.
- Behavior changes go in `docs/FEATURE_SPEC.md`.
- Cloud deployment is later, not required for v1.

## Open Questions

These can be decided later when implementation reaches them:

- Whether to use SQL Server directly on host or only through Docker Compose.
- Exact job coordination mechanism for the media worker.
- Whether Redis is needed in v1 beyond learning and caching.
- Exact video player library for HLS playback.
- Whether viewer profiles are included in v1.

## Style Preference

Keep implementation guidance practical and job-focused. The user wants confidence working on .NET, JS-based, and Python-based systems, with .NET as the main growth area.
