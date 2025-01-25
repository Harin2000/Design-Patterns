The Factory Method Pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

### Factory Method Pattern:
![image](https://github.com/user-attachments/assets/a15b2671-ced1-44c3-be5b-49be05914866)

![image](https://github.com/user-attachments/assets/39c157d8-1a9b-4792-8452-81311038e9d3)

### Dependency Inversion Principle:
![image](https://github.com/user-attachments/assets/f310210e-8e5a-415d-8c8b-cd1806fec430)

Depend on abstractions. Do not depend on the concrete classes.
![image](https://github.com/user-attachments/assets/a0ba7618-a0f4-4013-8ddf-0dc89988b7fa)

A few guidelines to help you follow the Principle...
1. No variable should hold a reference to a concrete class.
2. No class should derive from a concrete class.
3. No method should override an implemented method of any of its base classes.

