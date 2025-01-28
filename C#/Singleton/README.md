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

### C# Implementation: Check code

