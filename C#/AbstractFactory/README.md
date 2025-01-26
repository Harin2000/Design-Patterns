The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

### Abstract Factory Pattern:
![image](https://github.com/user-attachments/assets/84f3301b-3029-4e66-aa00-92f4c2d4a99d)

![image](https://github.com/user-attachments/assets/17fa33a1-32b0-41ea-873a-c2e3d0786b89)

### Comparing Factory Method & Abstract Factory:
![image](https://github.com/user-attachments/assets/b2d8f35b-1ca1-40a1-9da2-ab4e2dd82a56)

![image](https://github.com/user-attachments/assets/366df121-8ae9-4a09-a64f-a6f9023956bc)

### Chapter end notes:
![image](https://github.com/user-attachments/assets/47f24a74-b01e-4f22-b49a-c18da9c9b160)

### Bullet Points:
1. All factories encapsulate object creation.
2. Simple Factory, while not a bona fide design pattern, is a simple way to decouple your clients from concrete classes.
3. Factory Method relies on inheritance: object creation is delegated to subclasses, which implement the factory method to create objects.
4. Abstract Factory relies on object composition: object creation is implemented in methods exposed in the factory interface.
5. All factory patterns promote loose coupling by reducing the dependency of your application on concrete classes.
6. The intent of Factory Method is to allow a class to defer instantiation to its subclasses.
7. The intent of Abstract Factory is to create families of related objects without having to depend on their concrete classes.
8. The Dependency Inversion Principle guides us to avoid dependencies on concrete types and to strive for abstractions.
9. Factories are a powerful technique for coding to abstractions, not concrete classes.
