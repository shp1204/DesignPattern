public class CommandMethod{
    public static void Run(){
        RemoteControl remoteControl = new RemoteControl();
        Light livingRoomLignt = new Light();
        Light kitchenLignt = new Light();
        Stereo stereo = new Stereo();

        LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLignt);
        LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLignt);
        LightOnCommand kitchenLigntOn = new LightOnCommand(kitchenLignt);
        LightOffCommand kitchenLigntOff = new LightOffCommand(kitchenLignt);
        StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
        StereoOffWithCDCommand stereoOffWithCD = new StereoOffWithCDCommand(stereo);

        remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
        remoteControl.setCommand(1, kitchenLigntOn, kitchenLigntOff);
        remoteControl.setCommand(2, stereoOnWithCD, stereoOffWithCD);

        remoteControl.onButtonWasPushed(0);
        remoteControl.offButtonWasPushed(0);
        remoteControl.undoButtonWasPushed();
        Console.WriteLine("---");
        remoteControl.onButtonWasPushed(1);
        remoteControl.offButtonWasPushed(1);
        Console.WriteLine("---");
        remoteControl.onButtonWasPushed(2);
        remoteControl.offButtonWasPushed(2);
        remoteControl.undoButtonWasPushed();
    }
}