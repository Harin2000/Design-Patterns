The Singleton Pattern ensures a class has only one instance, and provides a global point of access to it.

### Singleton Pattern:
![image](https://github.com/user-attachments/assets/2b295577-6d6a-4282-893a-7431e24fe103)

### Ways to handle Singleton according to the book (Java):
1. Make the method synchronized. If the performance of getInstance() isn’t critical to your application.
2. Move to an eagerly created instance rather than a lazily created one.
![image](https://github.com/user-attachments/assets/ea2fe3cd-bb0a-4ac2-ae16-78ea1f5ce890)
3. Use “double-checked locking” to reduce the use of synchronization in getInstance().
![image](https://github.com/user-attachments/assets/0b064c07-dc24-4910-afee-17945452cfef)
4. Many of the problems we’ve discussed—worrying about synchronization, class loading issues, reflection, and serialization/deserialization issues—can all be solved by using an enum to create your Singleton. Here’s how you’d do that:
![image](https://github.com/user-attachments/assets/c33426fa-d54a-42e6-9f30-f2d70bf2c101)

### Chapter end notes:
![image](https://github.com/user-attachments/assets/6b45ce4e-e5cf-4245-a420-81238f6571d4)

### Bullet Points:
1. The Singleton Pattern ensures you have at most one instance of a class in your application.
2. The Singleton Pattern also provides a global access point to that instance.
3. Java’s implementation of the Singleton Pattern makes use of a private constructor, a static method combined with a static variable.
4. Examine your performance and resource constraints and carefully choose an appropriate Singleton implementation for multithreaded applications (and we should consider all applications multithreaded!).
5. Beware of the double-checked locking implementation; it isn’t thread safe in versions before Java 5.
6. Be careful if you are using multiple class loaders; this could defeat the Singleton implementation and result in multiple instances.
7. You can use Java’s enums to simplify your Singleton implementation.

### C# Implementation: Check code

