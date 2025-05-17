Car Rental System Project Plan

/CarRentalSystem - Folder Structure
│
├── /Domain         # Core business entities and logic (Car, User, Rental, etc.)
│
├── /Services       # Business services (RentalService, CarService, PricingService, etc.)
│
├── /Persistence    # Data access and storage (repositories, data context, etc.)
│
├── /UI             # Console UI logic (menus, views, input/output handling)
│
├── Program.cs      # Application entry point
│
├── /Docs           # Documentation (ProjectPlan.md, MaintananceRules.md, etc.)
│
└── README.md

General Criteria for Each Phase
•	Follow SOLID principles.
•	Keep classes and methods focused and well-named.
•	Write clear, descriptive commit messages.
•	Refactor code as needed for maintainability.
•	Document any design decisions in the README or a docs/ folder.

Phase 1: Project Setup
•	[X] Initialize a new Git repository.
•	[X] Set up the solution and main project in Visual Studio.
•	[X] Define the initial folder structure (Domain, Services, Persistence, UI).
---
Phase 2: Domain Modeling
•	[ ] Create core domain classes: Car, User, Rental.
•	[ ] Ensure each class has a single responsibility (SRP).
•	[ ] Use clear, descriptive names and properties.
---
Phase 3: Car Selection Interface
•	[ ] Create a new branch: feature/car-selection-ui.
•	[ ] Implement a console-based car selection menu in a dedicated UI class.
•	[ ] Keep UI logic separate from business logic.
•	[ ] Commit: feat: add car selection interface.
---
Phase 4: Car Availability Management
•	[ ] Create a new branch: feature/car-availability.
•	[ ] Implement logic to track car availability and prevent double bookings.
•	[ ] Use a service class (e.g., CarService) for this logic.
•	[ ] Commit: feat: add car availability tracking.
---
Phase 5: Rental Price Calculation
•	[ ] Create a new branch: feature/rental-price-calculation.
•	[ ] Implement dynamic price calculation based on car type and duration.
•	[ ] Use interfaces/abstractions for pricing strategies (Open/Closed Principle).
•	[ ] Commit: feat: implement rental price calculation.
---
Phase 6: Persistence Layer
•	[ ] Create a new branch: feature/database-integration.
•	[ ] Define repository interfaces (e.g., ICarRepository).
•	[ ] Implement an in-memory or file-based repository for now.
•	[ ] Commit: feat: add repository pattern for persistence.
---
Phase 7: User Account Management
•	[ ] Create a new branch: feature/user-account-management.
•	[ ] Implement user registration and login.
•	[ ] Store user data securely.
•	[ ] Commit: feat: add user account management.
---
Phase 8: Payment Integration
•	[ ] Create a new branch: feature/payment-integration.
•	[ ] Simulate payment processing.
•	[ ] Keep payment logic decoupled from other services.
•	[ ] Commit: feat: add payment integration.
---
Phase 9: Rental History & Error Handling
•	[ ] Create a new branch: feature/rental-history-error-handling.
•	[ ] Implement rental history tracking for users.
•	[ ] Add robust error handling and user feedback.
•	[ ] Commit: feat: add rental history and error handling.
---
