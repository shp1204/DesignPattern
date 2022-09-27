public class Stereo{
    
    public Stereo(){}
    public void on(){
        Console.WriteLine("Stereo - on");
    }
    public void off(){
        Console.WriteLine("Stereo - off");
    }
    public void setCD(){
        Console.WriteLine("Stereo - setCd");
    }
    public void setDvd(){
        Console.WriteLine("Stereo - setDvd");
    }
    public void setRadio(){
        Console.WriteLine("Stereo - setRadio");
    }
    public void setVolume(int volume){
        Console.WriteLine("Stereo - setVolume : " + volume.ToString());
    }
}