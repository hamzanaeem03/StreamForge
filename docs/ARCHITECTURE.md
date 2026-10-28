# Architecture

## System Overview

StreamForge is a modular ASP.NET Core MVC application supported by a media-processing worker and local infrastructure services.

Primary components:

- Web app: ASP.NET Core MVC/Razor UI, auth, catalog, admin, billing, playback.
- Domain/application layer: business rules and use-case services.
- Infrastructure layer: EF Core, SQL Server access, Stripe integration, file storage, Redis integration.
- Media worker: background process that runs FFmpeg against uploaded media.
- SQL Server: relational source of truth.
- Redis: cache and lightweight coordination where useful.
- Local storage: original uploads, generated HLS files, posters, and thumbnails.

## Application Boundaries

The MVC web app should handle HTTP concerns: routing, model binding, validation display, view rendering, auth policies, and redirects.

Business decisions should live outside controllers when they are reused or non-trivial. Examples:

- Whether a user can watch a title.
- Whether a title can be published.
- Whether a media asset is playable.
- How subscription state maps to content access.

Infrastructure concerns should not leak into views. Views should receive view models, not EF entities by default.

## Planned Solution Shape

Initial solution layout:

- `src/StreamForge.Web`: MVC/Razor app.
- `src/StreamForge.Application`: use cases, DTOs, interfaces, business services.
- `src/StreamForge.Domain`: entities, enums, domain rules.
- `src/StreamForge.Infrastructure`: EF Core, storage, Stripe, Redis, external adapters.
- `src/StreamForge.Worker`: media-processing worker.
- `tests/StreamForge.Tests`: unit and integration tests.

This layout may be adjusted if it becomes too heavy, but the docs must be updated first.

## Data Storage

SQL Server is the source of truth for users, catalog metadata, subscriptions, watch progress, and media processing status.

EF Core migrations should be used for schema changes. Schema changes must be reflected in `docs/DOMAIN_MODEL.md`.

## Media Storage

Local mounted storage is the v1 storage mechanism.

Expected storage areas:

- Original uploads.
- Processed HLS output.
- Poster images.
- Thumbnail images.

The app should store file paths and processing metadata in SQL Server. Large binary files should not be stored in the database.

## Media Processing

The media worker receives or polls pending media-processing jobs. It uses FFmpeg inside Docker to:

- Inspect the uploaded file.
- Generate HLS output.
- Generate thumbnails.
- Record duration and processing metadata.
- Mark success or failure in the database.

Playback must only be available when the media asset status is playable.

## Authentication And Authorization

ASP.NET Core Identity is used for accounts.

Planned roles:

- `User`: default registered user.
- `Subscriber`: user with active subscription access.
- `Admin`: can manage catalog and media.

Authorization should be policy-based where rules become more complex than a simple role check.

## Billing

Stripe test mode is used for subscription checkout and webhook learning.

The local database should store subscription state needed for access checks. Stripe remains the payment source, but the app should not call Stripe on every playback request.

## Docker Compose

Docker Compose is the default local environment target.

Expected services:

- Web app.
- SQL Server.
- Redis.
- Media worker.
- Optional local storage volume.

Cloud deployment is a later phase and not required for v1.
