•	What are the main "things" (nouns) in your system?
Think about the real-world objects and concepts your system needs to represent. Where would you define these in your project?
•	How will you separate the logic that "does things" from the objects themselves?
Consider which parts of your code will represent data and which will handle operations or workflows.
•	If you want to change how data is stored (e.g., from in-memory to a database), how can you make that change easy?
What kind of abstraction or interface might help here?
•	How will you keep the code that interacts with the user (input/output) separate from your business logic?
Why might this separation be useful for testing or future changes?
•	When you add new features (like payment or user accounts), how can you do so without modifying lots of existing code?
What design choices help you extend your system easily?
•	For each class or component, ask:
•	Does it have a single, clear responsibility?
•	Is it easy to test in isolation?
•	Is it dependent on abstractions rather than concrete implementations?