# Feature Spec

This document defines expected behavior. When behavior changes, update this file.

## Authentication

- Visitors can register and log in.
- Registered users receive the `User` role by default.
- Admin users are seeded or assigned manually during development.
- Subscriber access comes from subscription state, not manual role assignment alone.

## Catalog

- Visitors and users can browse published titles.
- Catalog supports movies and series.
- Catalog supports filtering by genre, content type, release year, and availability.
- Search matches title names and descriptions.
- Unpublished titles are hidden from non-admin users.
- Title detail pages show metadata, poster, genres, trailer if available, and available playback actions.

## Admin Content Management

- Admins can create, edit, publish, unpublish, and archive titles.
- Admins can manage genres.
- Admins can create series, seasons, and episodes.
- Admins can upload poster images and video files.
- Admin pages must show media processing state.
- Admins should see validation errors clearly.

## Media Upload And Processing

- Uploaded videos are stored as original files in local mounted storage.
- Uploading media creates or updates a MediaAsset.
- A processing job is queued after upload.
- The worker processes media with FFmpeg.
- Successful processing produces HLS output and at least one thumbnail.
- Failed processing records the failure reason.
- Playback is blocked until processing succeeds.

## Playback

- Free content can be watched by authenticated users.
- Premium content requires an active subscription.
- Playback page uses generated HLS output.
- Playback saves watch progress.
- Returning users can resume from the last saved position.
- Unauthorized users are redirected to login or subscription flow depending on the case.

## Subscriptions

- Users can start Stripe test checkout from the app.
- Stripe webhook events update local subscription state.
- Active subscriptions unlock premium content.
- Canceled, expired, or failed subscription states remove premium access.
- The app should avoid calling Stripe during every playback request.

## Watchlist

- Authenticated users can add and remove published titles from a watchlist.
- Watchlist pages show only currently viewable titles.
- Removing an item does not affect watch progress.

## Watch History

- Playback updates progress periodically or on important player events.
- A title with progress appears in continue-watching views.
- Completed titles can remain in history but should not dominate continue-watching.

## Search And Filtering

- Search and filters should work together.
- Empty search should return normal catalog results.
- Invalid filter values should fail gracefully and show normal catalog results or validation feedback.

## Errors And Edge Cases

- Missing media shows a clear admin-facing issue and no user playback action.
- Failed media processing should be visible to admins.
- Deleted or unpublished titles should not appear in user catalog pages.
- Webhook failures should be logged and testable.
