# 🚀 System Context: HotelProject Development

**Core Objective:** Building a professional Hotel Management System using .NET 8 (Clean Architecture) and Angular.

**Tech Stack:**

- **Backend:** .NET 8 Web API, Entity Framework Core (MSSQL).

- **Architecture:** Clean Architecture (Domain, Application, Infrastructure, API).

- **Patterns:** Repository Pattern, Service Layer, Builder Pattern (for bookings), Global Exception Handling, AutoMapper, FluentValidation.

- **Frontend:** Angular (Mobile-first for Guests, Dashboard-centric for Staff).


**Git Workflow (Strict):**

- **Main branch:** Production-ready code.

- **Develop branch:** Main integration branch.

- **Feature branches:** `feature/hotel-[ticket-nr]-[description]`.

- **Command Pattern:** Always use chained commands: `git checkout develop && git pull origin develop && git checkout -b feature/...`


**Project Milestones & Current Progress:**

1. **M1: Foundation:** Entities (Room, Guest, Booking), DbContext, Migrations.

2. **M2: Application Logic:** DTOs, Mapping, FluentValidation, BookingService, BookingBuilder, Global Exception Middleware.

3. **M3: API:** Controllers, Dependency Injection, Swagger.


**Instructions for AI Assistant:**

- **Code:** Always provide code in **English**.

- **Explanation:** Always provide explanations and guidance in **Swedish**.

- **Context:** Be mindful of the "Miss Persson" scenario (Multi-room/complex bookings).

- **Tone:** Technical, peer-to-peer, supportive, and organized.


---

### Hur du använder denna:

Varje gång du startar en ny chatt, skriver du bara:

> _"Hej! Här är kontexten för mitt projekt som vi ska jobba på nu: [Klistra in texten ovan]"_

Då vet boten direkt:

1. Vilka lager den ska skriva kod i (Clean Architecture).

2. Vilka patterns vi kommit överens om (t.ex. Builder Pattern).

3. Att den ska förklara på svenska men koda på engelska.


**Är du nöjd med den sammanfattningen, eller vill du lägga till något specifikt om t.ex. hur vi ska hantera prissättning eller rabattkoder innan vi stänger den här "planeringsfasen"?**