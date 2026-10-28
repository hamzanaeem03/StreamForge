# StreamForge

StreamForge is a documentation-first learning project for becoming job-ready with .NET by building an advanced OTT-style streaming platform.

The app will be built with ASP.NET Core MVC/Razor, EF Core, SQL Server, ASP.NET Core Identity, Docker Compose, Redis, Stripe test mode, and a Dockerized FFmpeg media worker. The goal is not to clone Netflix at internet scale. The goal is to learn the architecture, workflows, and engineering habits used in real .NET systems.

## Current Status

Status: documentation foundation only.

No application code has been created yet. Future sessions should start by reading this file and `docs/LLM_HANDOFF.md`.

## Project Goals

- Learn modern .NET through a serious, portfolio-grade project.
- Build a real media platform with upload, processing, playback, subscriptions, admin workflows, and user features.
- Preserve enough context that any LLM or engineer can resume work without relying on chat history.
- Produce a project that can be discussed confidently in job interviews.

## Planned Tech Stack

- Backend/UI: ASP.NET Core MVC/Razor on .NET 10
- Data: SQL Server with EF Core migrations
- Auth: ASP.NET Core Identity with roles
- Billing: Stripe test mode
- Media: Dockerized FFmpeg worker producing HLS output
- Cache/coordination: Redis where useful
- Local environment: Docker Compose
- Tests: xUnit plus ASP.NET Core integration tests

## Documentation Map

- `docs/PROJECT_BRIEF.md`: product vision, users, feature scope, and success criteria.
- `docs/LEARNING_ROADMAP.md`: week-by-week learning path tied to StreamForge features.
- `docs/ARCHITECTURE.md`: system design and service boundaries.
- `docs/DOMAIN_MODEL.md`: core entities and relationships.
- `docs/FEATURE_SPEC.md`: expected behavior by feature area.
- `docs/IMPLEMENTATION_GUIDE.md`: build order, conventions, and feature workflow.
- `docs/LLM_HANDOFF.md`: required reading and instructions for future LLM sessions.
- `docs/DECISIONS.md`: architecture decision records.
- `docs/PROGRESS.md`: project progress checklist.

## Documentation Rules

- Start every future session by reading `README.md` and `docs/LLM_HANDOFF.md`.
- Update `docs/DECISIONS.md` when a major technical decision changes.
- Update `docs/PROGRESS.md` whenever work is completed.
- Update `docs/DOMAIN_MODEL.md` when entities, relationships, or schema decisions change.
- Update `docs/FEATURE_SPEC.md` when user-facing behavior changes.
- Keep docs direct, specific, and readable by both humans and LLMs.

## First Implementation Milestone

The first coding milestone will create the solution skeleton:

- MVC web app
- Domain/application class library
- Infrastructure/data class library
- Worker project for media processing
- Test project
- Docker Compose with SQL Server and Redis

See `docs/IMPLEMENTATION_GUIDE.md` for the build order.
