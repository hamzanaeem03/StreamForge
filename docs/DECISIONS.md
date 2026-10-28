# Decisions

This file records architecture decisions. Add new entries when a decision meaningfully affects project direction.

## ADR-001: Use ASP.NET Core MVC/Razor For The Main App

Status: Accepted.

Decision: StreamForge will use ASP.NET Core MVC/Razor for the main user and admin app.

Reason:

- The user wants to learn .NET deeply for job readiness.
- MVC/Razor teaches routing, controllers, views, model binding, validation, auth, and server-rendered architecture.
- It complements the user's existing MERN background by exposing a different full-stack model.

Consequences:

- The first UI will not be React.
- Frontend behavior should be progressively enhanced only where useful.
- View models and Razor views become important learning artifacts.

## ADR-002: Use Dockerized FFmpeg Worker

Status: Accepted.

Decision: Video processing will run in a Dockerized worker using FFmpeg.

Reason:

- FFmpeg is not installed on the local machine.
- Docker makes media processing reproducible.
- A worker teaches background processing and system boundaries.

Consequences:

- Local development depends on Docker.
- Media jobs need persistent storage shared between app and worker.
- The worker should report processing success and failure to the database.

## ADR-003: Use Stripe Test Mode For Billing

Status: Accepted.

Decision: Subscription billing will use Stripe test mode.

Reason:

- It teaches real payment integration patterns without real money.
- Webhooks and subscription state are valuable job skills.
- It supports realistic premium-content access rules.

Consequences:

- Secrets must not be committed.
- Webhook handling must be testable.
- Local subscription state must be synced from Stripe events.

## ADR-004: Use SQL Server With EF Core

Status: Accepted.

Decision: SQL Server is the relational database and EF Core is the ORM.

Reason:

- SQL Server is common in .NET jobs.
- EF Core migrations teach practical schema evolution.
- The domain is relational: users, titles, genres, subscriptions, and watch progress.

Consequences:

- Migrations are required for schema changes.
- Query performance should be considered as catalog features grow.
- Docs must track domain and schema changes.

## ADR-005: Use Local Mounted Storage For V1 Media Files

Status: Accepted.

Decision: V1 stores uploads and processed media in local mounted storage.

Reason:

- It avoids cloud account setup during early learning.
- It keeps the media pipeline visible and debuggable.
- It can later be replaced by cloud storage.

Consequences:

- File paths and storage conventions must be documented.
- Large media files should not be committed to source control.
- Cloud deployment requires a later storage decision.

## ADR-006: Use Docker Compose As The Default Local Environment

Status: Accepted.

Decision: Docker Compose will orchestrate local services.

Reason:

- The project needs SQL Server, Redis, web app, worker, and shared storage.
- Compose makes the setup easier to reproduce.
- It mirrors real multi-service development.

Consequences:

- README setup must include Docker requirements.
- Service configuration should come from environment variables.
- Local-only shortcuts should not become hidden dependencies.
