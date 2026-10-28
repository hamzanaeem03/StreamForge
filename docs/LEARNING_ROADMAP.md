# Learning Roadmap

This roadmap assumes 5-7 focused hours per week. Each week should produce either working code, written notes, tests, or all three.

## Phase 1: .NET Foundations

### Week 1: C# For Experienced Web Developers

- Learn C# project structure, namespaces, classes, records, interfaces, nullable reference types, collections, and LINQ.
- Compare C# async/await with JavaScript async/await.
- Practice by modeling simple StreamForge domain objects in small exercises.

### Week 2: ASP.NET Core MVC Basics

- Learn MVC routing, controllers, actions, Razor views, layouts, tag helpers, model binding, and validation.
- Build the first static catalog pages.
- Document differences from MERN request handling.

## Phase 2: Data And Domain

### Week 3: EF Core And SQL Server

- Learn DbContext, DbSet, migrations, relationships, indexes, and seed data.
- Implement early models for titles, genres, movies, series, seasons, and episodes.

### Week 4: Application Structure

- Split responsibilities into web, domain/application, infrastructure, worker, and tests.
- Learn dependency injection and configuration.
- Add service classes only where they clarify business behavior.

## Phase 3: Identity And Catalog

### Week 5: Authentication And Roles

- Add ASP.NET Core Identity.
- Implement roles: User, Subscriber, Admin.
- Protect admin pages and premium content.

### Week 6: Catalog Experience

- Add browse, details, search, filters, and pagination.
- Add watchlist and basic ratings.
- Write tests for catalog visibility rules.

## Phase 4: Admin And Media

### Week 7: Admin Workflows

- Build admin CRUD for titles, metadata, genres, seasons, and episodes.
- Add publish/unpublish behavior and validation.

### Week 8: Uploads And Storage

- Add upload forms for original media and posters.
- Store uploads in local mounted storage.
- Track processing status in the database.

### Week 9: FFmpeg Worker

- Add Dockerized FFmpeg worker.
- Process original video into HLS output.
- Generate thumbnails and duration metadata.
- Mark media playable only after successful processing.

## Phase 5: Subscriptions And Playback

### Week 10: Stripe Test Mode

- Add checkout flow for subscription plans.
- Add webhook endpoint and signature validation.
- Sync subscription status to the local database.

### Week 11: Protected Playback

- Add HLS playback page.
- Enforce access rules for free and premium content.
- Save and resume watch progress.

## Phase 6: Production Habits

### Week 12: Testing Strategy

- Add unit tests for business rules.
- Add integration tests for MVC routes, auth, catalog, and Stripe webhook behavior.

### Week 13: Docker Compose

- Make local services reproducible with Docker Compose.
- Include SQL Server, Redis, web app, worker, and storage mounts.

### Week 14: Observability And Errors

- Add structured logging.
- Add user-friendly error pages.
- Log media processing failures clearly.

## Phase 7: Portfolio Polish

### Week 15: Documentation And Demo Data

- Improve README setup.
- Add demo credentials and seed data.
- Capture screenshots or GIFs.

### Week 16: Interview Prep

- Write architecture notes for interviews.
- Prepare explanations for tradeoffs.
- Review common .NET, SQL, MVC, EF Core, auth, and system design questions.
