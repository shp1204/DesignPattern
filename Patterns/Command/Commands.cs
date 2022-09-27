public interface Command {
    public void execute();
}

public class NoCommand : Command{
    public void execute(){}
}

public class LightOnCommand : Command{
    Light light;
    public LightOnCommand(Light light){
        this.light = light;
    }
    public void execute(){
        light.on();
    }
}

public class LightOffCommand : Command{
    Light light;
    public LightOffCommand(Light light){
        this.light = light;
    }
    public void execute(){
        light.off();
    }
}

public class StereoOnWithCDCommand : Command{
    Stereo stereo;
    public StereoOnWithCDCommand(Stereo stereo){
        this.stereo = stereo;
    }

    public void execute(){
        stereo.on();
        stereo.setCD();
        stereo.setVolume(11);
    }
}

public class StereoOffWithCDCommand : Command{
    Stereo stereo;
    public StereoOffWithCDCommand(Stereo stereo){
        this.stereo = stereo;
    }

    public void execute(){
        stereo.off();
    }
}