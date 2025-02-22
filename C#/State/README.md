The State Pattern allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

## State Diagram:
![image](https://github.com/user-attachments/assets/5e6824f7-3476-49c9-8016-4e95f05766ec)

## Initial Implementation:
![image](https://github.com/user-attachments/assets/c636e580-629c-4753-8fb3-4c0125f86ff3)
![image](https://github.com/user-attachments/assets/f8a2f3a6-102a-4203-ba38-db8c8011c287)

## Change:
![image](https://github.com/user-attachments/assets/f410a08f-2fa6-4ff3-a76c-0b949144b535)

## Implementing State pattern:
![image](https://github.com/user-attachments/assets/bb4d0dc2-83c1-442a-ad88-fb41240d67c9)

Working of State pattern:
![image](https://github.com/user-attachments/assets/cdcc5395-4a5e-4c7e-84fd-d44c899d52bd)

## State Pattern Diagram:
![image](https://github.com/user-attachments/assets/16016e38-d2dd-40c5-9f24-3ba489b60fa7)

## Chapter End Notes:
![image](https://github.com/user-attachments/assets/3053b256-2d19-4bd3-9cf1-4706cc1bd956)

## Bullet Points:
- The State Pattern allows an object to have many different behaviors that are based on its internal state.
- Unlike a procedural state machine, the State Pattern represents each state as a full-blown class.
- The Context gets its behavior by delegating to the current state object it is composed with.
- By encapsulating each state into a class, we localize any changes that will need to be made.
- The State and Strategy Patterns have the same class diagram, but they differ in intent.
- The Strategy Pattern typically configures Context classes with a behavior or algorithm.
- The State Pattern allows a Context to change its behavior as the state of the Context changes.
- State transitions can be controlled by the State classes or by the Context classes.
- Using the State Pattern will typically result in a greater number of classes in your design.
- State classes may be shared among Context instances.


