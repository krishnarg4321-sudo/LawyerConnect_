# LegalConnect

LegalConnect is a .NET-only legal services marketplace built around the **Verdant Chamber / Legal Atlas** experience: a calm, trustworthy interface for discovering verified lawyers, booking consultations, and organizing case work.

## Initial scaffold

- `LegalConnect.Api` — ASP.NET Core API host
- `LegalConnect.Blazor` — Blazor Web App host with the initial Legal Atlas landing experience
- `LegalConnect.Core` — domain entities and shared contracts
- `LegalConnect.Application` — application services and use-case abstractions
- `LegalConnect.Infrastructure` — EF Core persistence foundation
- `LegalConnect.Tests` — xUnit test project

## Requirements

- .NET 8 SDK
- SQL Server or LocalDB for the persistence phase

## Run

```bash
dotnet restore LegalConnect.sln
dotnet build LegalConnect.sln
dotnet run --project src/LegalConnect.Api
dotnet run --project src/LegalConnect.Blazor
```

The first commit intentionally contains the clean solution foundation. Upcoming phases add Identity, migrations, lawyer discovery, booking, payments, SignalR chat, and Azure integrations behind interfaces. Development integrations must remain safe and must never present AI output as legal advice.
