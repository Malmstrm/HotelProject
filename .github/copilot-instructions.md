# 🚀 System Context: HotelProject Development

**Core Objective:** Building a professional Hotel Management System using .NET 9 (Clean Architecture) and Angular.

**Tech Stack:**

- **Backend:** .NET 9 Web API, Entity Framework Core (MSSQL).

- **Architecture:** Clean Architecture (Domain, Application, Infrastructure, API).

- **Patterns:** Repository Pattern, Service Layer, Builder Pattern (for bookings), Global Exception Handling, AutoMapper, FluentValidation.

- **Frontend:** Angular (Mobile-first for Guests, Dashboard-centric for Staff).


**Git Workflow (Strict):**

- **Main branch:** Production-ready code.

- **Develop branch:** Main integration branch.

- **Feature branches:** `feature/hotel-[ticket-nr]-[description]`.


**Project Milestones & Current Progress:**

1. **M1: Foundation:** Entities (Room, Guest, Booking), DbContext, Migrations.

2. **M2: Application Logic:** DTOs, Mapping, FluentValidation, BookingService, BookingBuilder, Global Exception Middleware.

3. **M3: API:** Controllers, Dependency Injection, Swagger.


**Instructions for AI Assistant:**

- **Code:** Always provide code in **English**.

- **Explanation:** Always provide explanations and guidance in **Swedish**.

- **Context:** Be mindful of the "Miss Persson" scenario (Multi-room/complex bookings).

- **Tone:** Technical, peer-to-peer, supportive, and organized.
