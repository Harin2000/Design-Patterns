using Command.Commands;
using Command.VendorClasses;

namespace Command
{
    internal class RemoteLoader
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("Garage");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOnCommand = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOffCommand = new LightOffCommand(kitchenLight);

            CeilingFanMedOnCommand ceilingFanMedOnCommand = new CeilingFanMedOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUpCommand = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDownCommand = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

            remoteControl.onCommands[0] = livingRoomLightOnCommand;
            remoteControl.offCommands[0] = livingRoomLightOffCommand;

            remoteControl.onCommands[1] = kitchenLightOnCommand;
            remoteControl.offCommands[1] = kitchenLightOffCommand;

            remoteControl.onCommands[2] = ceilingFanMedOnCommand;
            remoteControl.offCommands[2] = ceilingFanOffCommand;

            remoteControl.onCommands[3] = garageDoorUpCommand;
            remoteControl.offCommands[3] = garageDoorDownCommand;

            remoteControl.onCommands[4] = stereoOnWithCdCommand;
            remoteControl.offCommands[4] = stereoOffCommand;

            Console.WriteLine(remoteControl);
            Console.WriteLine();

            remoteControl.OnPushed(0); remoteControl.OffPushed(0);
            remoteControl.OnPushed(1); remoteControl.OffPushed(1);
            remoteControl.OnPushed(2); remoteControl.OffPushed(2);
            remoteControl.OnPushed(3); remoteControl.OffPushed(3);
            remoteControl.OnPushed(4); remoteControl.OffPushed(4);
            Console.WriteLine("\nTesting the undo operation now...");


            remoteControl.Undo();
            remoteControl.OffPushed(4);

            CeilingFanHighOnCommand ceilingFanHighOnCommand = new CeilingFanHighOnCommand(ceilingFan);
            remoteControl.onCommands[5] = ceilingFanHighOnCommand;
            remoteControl.offCommands[5] = ceilingFanOffCommand;

            remoteControl.OnPushed(2); remoteControl.OnPushed(5); remoteControl.OffPushed(2); remoteControl.Undo();
            Console.WriteLine($"GetSpeed() should return High, i.e. 3: {ceilingFan.GetSpeed()}");

            remoteControl.OnPushed(2); remoteControl.Undo();
            Console.WriteLine($"GetSpeed() should return High again, i.e. 3: {ceilingFan.GetSpeed()}");

            // NOTE: If ICommand were to only have a single method, we can assign Remote Control's
            // slots with lambda => All the concrete command objects can be reomved in that case.
        }
    }
}
