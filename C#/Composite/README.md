The Composite Pattern allows you to compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.

### Post Iterator State:
![image](https://github.com/user-attachments/assets/31da5874-75eb-431f-93cd-5149bbd7472d)

### What do we need?
![image](https://github.com/user-attachments/assets/3c8167b7-ef2e-4d2d-bfc9-e92a9ca9fa5e)

### Composite Pattern:
![image](https://github.com/user-attachments/assets/1c98e0bf-bfb8-49ac-b76f-aae6eec89e96)

### Here:
![image](https://github.com/user-attachments/assets/9c8311eb-9543-4b8e-bb7f-f63ccece4c05)

### Print method:
![image](https://github.com/user-attachments/assets/fd3c868e-9b21-4280-b90d-bf3ddb76adc6)

### Trade-off:
We could say that the Composite Pattern takes the Single Responsibility Principle and trades it for transparency.

### Chapter End Notes:
![image](https://github.com/user-attachments/assets/d29c857b-5b19-4104-ab39-70cfeb4960ab)

### Bullet Points:
- An Iterator allows access to an aggregate’s elements without exposing its internal structure.
- An Iterator takes the job of iterating over an aggregate and encapsulates it in another object.
- When using an Iterator, we relieve the aggregate of the responsibility of supporting operations for traversing its data.
- An Iterator provides a common interface for traversing the items of an aggregate, allowing you to use polymorphism when writing code that makes use of the items of the aggregate.
- The Iterable interface provides a means of getting an iterator and enables Java’s enchanced for loop.
- We should strive to assign only one responsibility to each class.
- The Composite Pattern allows clients to treat composites and individual objects uniformly.
- A Component is any object in a Composite structure. Components may be other composites or leaves.
- There are many design tradeoffs in implementing Composite. You need to balance transparency and safety with your needs.
