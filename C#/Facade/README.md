The Facade Pattern provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.

### Initial State:
![image](https://github.com/user-attachments/assets/b79007ea-1cfc-4ba5-82e4-ab491918b9d6)

### Facade Pattern Idea:
![image](https://github.com/user-attachments/assets/c022b5f1-5a1e-4a5c-8864-905554dca942)

### Facade Pattern Diagram:
![image](https://github.com/user-attachments/assets/e48ac224-3af8-4de9-a0bf-49bdf3dc3f28)

### The Principle of Least Knowledge:
![image](https://github.com/user-attachments/assets/82ec3caa-b309-4eb8-905e-03b5f4bd4bcd)

The principle provides some guidelines: take any object, and from any method in that object, invoke only methods that belong to:
- The object itself.
- Objects passed in as a parameter to the method.
- Any object the method creates or instantiates.
- Any components of the object.
![image](https://github.com/user-attachments/assets/48f6696f-c005-4d05-a0ce-34b5be194b70)

Hacking your way:
![image](https://github.com/user-attachments/assets/8a620762-a638-4f51-ae41-80f9f0ac38cc)

### Chapter End notes:
![image](https://github.com/user-attachments/assets/59f8c4a9-6858-4f49-9c8e-99edd0596ed9)

### Bullet Points:
- When you need to use an existing class and its interface is not the one you need, use an adapter.
- When you need to simplify and unify a large interface or complex set of interfaces, use a facade.
- An adapter changes an interface into one a client expects.
- A facade decouples a client from a complex subsystem.
- Implementing an adapter may require little work or a great deal of work depending on the size and complexity of the target interface.
- Implementing a facade requires that we compose the facade with its subsystem and use delegation to perform the work of the facade.
- There are two forms of the Adapter Pattern: object and class adapters. Class adapters require multiple inheritance.
- You can implement more than one facade for a subsystem.
- An adapter wraps an object to change its interface, a decorator wraps an object to add new behaviors and responsibilities, and a facade “wraps” a set of objects to simplify.

