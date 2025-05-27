# Set up structure for folder structure

**Date:** 2025-05-24  
**Status:** Accepted

**Context:**  
I need a way to organize our project files and directories to ensure clarity and maintainability as the project grows. A well-defined folder structure will help developers navigate the codebase easily.

**Decision:**  
I will implement a modular folder structure that separates concerns and groups related files together. The main directories will include:
- `/`: Contains all core data files.
  - `Docs/`: Documentation for the project and decisions made.
  - `Domain/`: Contains domain models only, no logic.
  - `Persistence/`: Contains Repositories (interfaces and storage control).
  - `Services/`: Business Logic (methods for pricing, renting and availability ect).
  - `UI/`: Console View and Menu Logic.

**Consequences:**  
+ Clear separation of concerns, making it easier to locate files.
+ Each module can evolve independently, allowing for easier updates and maintenance.
+ New developers can quickly understand the project structure.
- Potential for some initial overhead in setting up the structure.
- Requires discipline to maintain the structure as the project evolves.

**Rationale:**  
This structure aligns with best practices for software development, promoting modularity and maintainability. It allows for clear boundaries between different parts of the application, which is essential for a scalable project.

**Related Documents:**  
- [ProjectPlan.md](./ProjectPlan.md)
