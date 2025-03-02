The Command Pattern encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.

## Task:
![image](https://github.com/user-attachments/assets/12fb440d-ab68-4639-aa1d-567038d45497)
![image](https://github.com/user-attachments/assets/12ccfe65-55f7-464a-80c0-4daf6347e0c6)

## Command Pattern:
![image](https://github.com/user-attachments/assets/dc61735e-e0ab-4426-9a9c-e25fcf9b418c)
![image](https://github.com/user-attachments/assets/7792ae04-53f9-4ef6-a6c2-15022d3280d4)
![image](https://github.com/user-attachments/assets/de44904d-2e57-4073-83ea-4e324c08cf53)

![image](https://github.com/user-attachments/assets/6618671b-d306-4588-9f8b-3dfed0a462f5)

![image](https://github.com/user-attachments/assets/371e5f7a-541b-41f2-b8a6-6588a2d5edac)

## Honorable Mention:
public class NoCommand implements Command {
    public void execute() { }
}

The NoCommand object is an example of a null object. A null object is useful when you don’t have a meaningful object to return, and yet you want to remove the responsibility for handling null from the client. For instance, in our remote control we didn’t have a meaningful object to assign to each slot out of the box, so we provided a NoCommand object that acts as a surrogate and does nothing when its execute() method is called.

You’ll find uses for Null Objects in conjunction with many Design Patterns, and sometimes you’ll even see “Null Object” listed as a Design Pattern.

## Serious Coding: The updated code, using lambda expressions:
![image](https://github.com/user-attachments/assets/e68bd284-0b8b-412c-8970-c4710ea126d6)

Once we’ve replaced the concrete commands with lambda expressions, we can delete all those concrete command classes (LightOnCommand, LightOffCommand, HottubOnCommand, HottubOffCommand, etc.). If you do this for every concrete command, you’ll reduce the total number of classes in the remote control application from 22 to 9.

Note that you can only do this if your Command interface has one abstract method. As soon as we add a second abstract method, the lambda shorthand no longer works.

## Macro Command:
![image](https://github.com/user-attachments/assets/c9a7afcd-ed9f-48a6-8243-7245e4e41a88)

## Uses of the Command Pattern:
### Queuing requests:
![image](https://github.com/user-attachments/assets/031b6719-db07-4221-a3d3-10da1c2fbda7)

### Logging requests:
![image](https://github.com/user-attachments/assets/f50d5cd8-e15a-4b3f-86f7-052c1aa62b1e)
![image](https://github.com/user-attachments/assets/15a12daa-a240-498c-a1d7-5e699a7c6d9e)

## Chapter End Notes:
![image](https://github.com/user-attachments/assets/4275c161-a4e3-49d2-bdee-8ccc0647f58c)

## Bullet Points:
- The Command Pattern decouples an object making a request from the one that knows how to perform it.
- A Command object is at the center of this decoupling and encapsulates a receiver with an action (or set of actions).
- An invoker makes a request of a Command object by calling its execute() method, which invokes those actions on the receiver.
- Invokers can be parameterized with Commands, even dynamically at runtime.
- Commands may support undo by implementing an undo() method that restores the object to its previous state before the execute() method was last called.
- MacroCommands are a simple extension of the Command Pattern that allow multiple commands to be invoked. Likewise, MacroCommands can easily support undo().
- In practice, it’s not uncommon for “smart” Command objects to implement the request themselves rather than delegating to a receiver.
- Commands may also be used to implement logging and transactional systems.
