# Implementation Guide

This guide tells future implementers how to build StreamForge without guessing.

## Build Order

1. Create the solution skeleton.
2. Add domain entities and EF Core persistence.
3. Add MVC catalog pages with seed data.
4. Add ASP.NET Core Identity and roles.
5. Add admin CRUD for catalog metadata.
6. Add upload storage and media asset tracking.
7. Add media worker and FFmpeg processing.
8. Add playback and access checks.
9. Add Stripe test checkout and webhooks.
10. Add watchlist and watch progress.
11. Add tests, Docker Compose polish, and README setup instructions.

Do not start with Stripe or FFmpeg before the catalog, auth, and data model are stable.

## Coding Conventions

- Use clear, boring names over clever abstractions.
- Prefer view models for Razor views.
- Keep controllers thin when business logic becomes non-trivial.
- Keep EF Core entities in the domain or data model area consistently once the first code is created.
- Use async database calls.
- Validate inputs at the MVC boundary and in business services when rules are important.
- Do not store video bytes in SQL Server.
- Do not hard-code secrets. Use user secrets or environment variables.

## Folder Guidance

Planned solution:

- `src/StreamForge.Web`
- `src/StreamForge.Domain`
- `src/StreamForge.Application`
- `src/StreamForge.Infrastructure`
- `src/StreamForge.Worker`
- `tests/StreamForge.Tests`

If this structure is simplified, update `docs/ARCHITECTURE.md` and this file.

## Feature Workflow

For every feature:

1. Confirm expected behavior in `docs/FEATURE_SPEC.md`.
2. Update `docs/DOMAIN_MODEL.md` if data changes.
3. Implement the smallest useful version.
4. Add focused tests for business rules or risky paths.
5. Update `docs/PROGRESS.md`.
6. Add a decision record if the feature introduces a major architecture choice.

## Testing Expectations

- Unit test business rules that can break silently.
- Integration test important MVC and auth flows.
- Test Stripe webhooks with fixture-like payloads.
- Test media processing status transitions even if FFmpeg itself is not fully run in unit tests.

## Learning Notes

When learning from tutorials, do not copy blindly. Translate the concept into StreamForge.

Examples:

- A tutorial CRUD screen becomes admin title or genre management.
- A tutorial auth lesson becomes User/Subscriber/Admin access.
- A tutorial file upload becomes poster or video upload.
- A tutorial background job becomes media processing.

## Definition Of Done

A feature is done when:

- It works locally.
- Important behavior is tested or manually documented.
- Docs are updated.
- Errors are understandable.
- The feature can be explained in interview language.
