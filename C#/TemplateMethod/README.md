The Template Method Pattern defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm’s structure.

### Template Method Pattern:
![image](https://github.com/user-attachments/assets/2d3368c7-2194-4c35-94b4-235cfb79b539)

### With hook:
![image](https://github.com/user-attachments/assets/700e53a4-f341-46f8-a087-2e40be35de46)

### Template Method Pattern Diagram:
![image](https://github.com/user-attachments/assets/d72fa6f5-bddc-4a4c-9eb9-eb3aa6e4c1de)

### With hook:
![image](https://github.com/user-attachments/assets/2443e1c7-75f3-42f9-a01a-d7d85735327c)

### The Hollywood Principle: Don't call us, we'll call you
![image](https://github.com/user-attachments/assets/f31983f0-6015-46dc-904b-22c702715ae8)

### Chapter End notes:
![image](https://github.com/user-attachments/assets/ac06fa82-f70d-42e5-a7b0-ce8bff873d0f)

### Bullet Points:
- A template method defines the steps of an algorithm, deferring to subclasses for the implementation of those steps.
- The Template Method Pattern gives us an important technique for code reuse.
- The template method’s abstract class may define concrete methods, abstract methods, and hooks.
- Abstract methods are implemented by subclasses.
- Hooks are methods that do nothing or default behavior in the abstract class, but may be overridden in the subclass.
- To prevent subclasses from changing the algorithm in the template method, declare the template method as final.
- The Hollywood Principle guides us to put decision making in high-level modules that can decide how and when to call low-level modules.
- You’ll see lots of uses of the Template Method Pattern in real-world code, but (as with any pattern) don’t expect it all to be designed “by the book.”
- The Strategy and Template Method Patterns both encapsulate algorithms, the first by composition and the other by inheritance.
- Factory Method is a specialization of Template Method.


