# Project Brief

## Product Vision

StreamForge is an OTT-style streaming platform where users can browse content, subscribe, and watch processed video. Admin users can manage a catalog, upload media, publish titles, and monitor transcoding status.

This is a learning project first and a portfolio project second. Every feature should teach a practical .NET skill that appears in real jobs: MVC, Razor views, EF Core, Identity, background work, SQL modeling, auth, payments, tests, Docker, and production-minded architecture.

## Target Users

- Visitor: can browse public catalog pages, view title details, and sign up.
- Registered user: can manage a profile, add titles to a watchlist, and watch free content.
- Subscriber: can watch premium content and continue from saved progress.
- Admin: can create and manage content, upload videos, publish titles, and review processing state.

## Core User Flows

- Visitor registers, logs in, and browses the catalog.
- User searches or filters content by title, genre, type, release year, and availability.
- User subscribes through Stripe test checkout and gains access to premium playback.
- Admin creates a movie or series, adds metadata, uploads video, and waits for processing.
- Media worker transcodes the upload to HLS and marks it playable.
- Subscriber watches video, leaves, and resumes from saved progress.

## In Scope For V1

- MVC/Razor web app with server-rendered pages.
- Catalog pages for movies and series.
- Admin content management.
- Video upload and background media processing.
- HLS playback from locally stored processed files.
- ASP.NET Core Identity authentication.
- Role-based authorization for users, subscribers, and admins.
- Stripe test mode checkout and webhook handling.
- EF Core with SQL Server.
- Redis where it provides clear learning value.
- Docker Compose for local development.
- Focused automated tests for important business behavior.

## Out Of Scope For V1

- Global CDN delivery.
- DRM.
- Multi-region scaling.
- Native mobile apps.
- Live streaming.
- Real payment processing outside Stripe test mode.
- Complex recommendation algorithms.
- Cloud deployment as a required milestone.

## Success Criteria

- A fresh developer or LLM can understand the project from the docs alone.
- A user can subscribe in test mode and watch protected content.
- An admin can upload a video and see it become playable after processing.
- The project can run locally through documented setup.
- Important workflows have automated tests.
- The README explains the architecture well enough for interview discussion.
