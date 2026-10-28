# LLM Handoff

This is the first file an LLM should read after `README.md`.

## Project Identity

Project name: StreamForge.

Purpose: help the user learn .NET deeply enough to work on .NET systems professionally, while building a serious OTT-style portfolio project.

Main app style: ASP.NET Core MVC/Razor, not React.

Current status: documentation foundation only. No application code exists yet unless `docs/PROGRESS.md` says otherwise.

## Required Reading Order

1. `README.md`
2. `docs/LLM_HANDOFF.md`
3. `docs/PROJECT_BRIEF.md`
4. `docs/ARCHITECTURE.md`
5. `docs/IMPLEMENTATION_GUIDE.md`
6. Relevant feature/domain docs for the task

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

The next implementation step is to create the solution skeleton:

- MVC web app.
- Domain/application/infrastructure libraries.
- Worker project.
- Test project.
- Docker Compose with SQL Server and Redis.

After the skeleton, build catalog/domain basics before Stripe or FFmpeg.

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
