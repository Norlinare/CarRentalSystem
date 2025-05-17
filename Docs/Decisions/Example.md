# Use Repository Pattern for Data Access

**Date:** 2025-05-17  
**Status:** Accepted

**Context:**  
We need a way to abstract data access so that we can switch between in-memory and database storage without changing business logic.

**Decision:**  
We will implement the Repository pattern for all data access. Each entity (e.g., Car, User) will have its own repository interface and implementation.

**Consequences:**  
+ Business logic is decoupled from data storage.
+ Easier to test and maintain.
- Slightly more boilerplate code.

**Rationale:**  
This approach follows SOLID principles and supports future scalability.

**Related Documents:**  
- [ProjectPlan.md](./ProjectPlan.md)
