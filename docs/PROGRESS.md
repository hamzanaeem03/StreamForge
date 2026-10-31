# Progress

Use this checklist to keep future sessions aligned.

## Completed

- [x] Created documentation-first project structure.
- [x] Defined StreamForge product direction.
- [x] Defined learning roadmap.
- [x] Defined initial architecture direction.
- [x] Recorded initial architecture decisions.
- [x] Created .NET solution skeleton with MVC web app, domain/application/infrastructure libraries, worker, and test project.
- [x] Added initial Docker Compose file with SQL Server and Redis.

- [x] Added LLM teaching guidance, learning resources, and `docs/LEARNING_NOTES.md`.

## In Progress

- Nothing yet. Next session starts with the first item under Next Up.

## Next Up

- [ ] Add initial catalog/domain entities (`Title`, `Genre`, `Movie`, `Series`, `Season`, `Episode`).
- [ ] Add EF Core persistence setup (`DbContext`, SQL Server connection, first migration).
- [ ] Add seed data for catalog development.

## Later

- [ ] Add ASP.NET Core Identity.
- [ ] Add admin catalog CRUD.
- [ ] Add media upload.
- [ ] Add FFmpeg worker processing.
- [ ] Add HLS playback.
- [ ] Add Stripe test checkout.
- [ ] Add watchlist and watch progress.
- [ ] Add integration tests.
- [ ] Add portfolio README polish and screenshots.

## Notes For Future Sessions

- Implemented so far: docs plus an empty solution skeleton (projects build, one placeholder test passes). No domain entities, database, or features exist yet.
- Update this file after every meaningful completed task.
- If implementation changes the plan, update the relevant docs before marking work complete.
