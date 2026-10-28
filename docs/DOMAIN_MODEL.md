# Domain Model

This document describes the planned model. It is allowed to evolve, but any schema or relationship change must update this file.

## Core Concepts

StreamForge separates catalog metadata from playable media. A title may exist before a valid video is uploaded and processed.

## Entities

### User

Represents an authenticated account managed through ASP.NET Core Identity.

Key concepts:

- Identity user id.
- Display name.
- Roles: User, Subscriber, Admin.
- Watch history and watchlist.
- Subscription state.

### Profile

Optional future entity for multiple viewer profiles under one account.

V1 can defer this unless it becomes useful for watch progress separation.

### Title

Base catalog item for something that can appear in browse/search.

Fields:

- Id.
- Name.
- Slug.
- Description.
- Release year.
- Maturity rating.
- Poster path.
- Trailer media asset.
- Content type: Movie or Series.
- Availability: Free or Premium.
- Publish status.
- Created/updated timestamps.

### Movie

Represents a title with one primary playable media asset.

Relationships:

- One Title.
- One primary MediaAsset.

### Series

Represents episodic content.

Relationships:

- One Title.
- Many Seasons.

### Season

Groups episodes for a series.

Fields:

- Season number.
- Name.
- Description.

Relationships:

- One Series.
- Many Episodes.

### Episode

Represents one playable unit in a season.

Fields:

- Episode number.
- Name.
- Description.
- Release date.

Relationships:

- One Season.
- One primary MediaAsset.

### Genre

Reusable category for catalog filtering.

Relationships:

- Many Titles through a join table.

### MediaAsset

Represents uploaded and processed media.

Fields:

- Id.
- Original file path.
- HLS manifest path.
- Thumbnail path.
- Duration.
- Status: Uploaded, Queued, Processing, Playable, Failed.
- Failure reason.
- Created/updated timestamps.

### MediaProcessingJob

Tracks background work for a media asset.

Fields:

- Id.
- MediaAssetId.
- Status.
- Attempts.
- Last error.
- Queued at.
- Started at.
- Completed at.

### Subscription

Represents local subscription state synced from Stripe test mode.

Fields:

- UserId.
- Stripe customer id.
- Stripe subscription id.
- Plan.
- Status.
- Current period end.
- Cancel at period end.

### WatchProgress

Tracks where a user stopped watching.

Fields:

- UserId.
- MediaAssetId.
- Position seconds.
- Completed flag.
- Last watched at.

### WatchlistItem

Tracks titles a user wants to watch later.

Fields:

- UserId.
- TitleId.
- Added at.

### Rating

Optional V1 feature for simple feedback.

Fields:

- UserId.
- TitleId.
- Score.
- Review text.
- Created at.

## Important Rules

- A title cannot be published for playback unless its required media is playable.
- Premium content requires active subscription access.
- Admin users can manage content but should still use normal playback rules unless explicitly bypassed for preview.
- Failed media jobs should keep enough error detail for debugging.
- Watch progress belongs to a user and a media asset.
