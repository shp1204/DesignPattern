public class Amplifier{
    public void on(){
        Console.WriteLine("amplifier on");
    }

    public void off(){
        Console.WriteLine("amplifier off");
    }

    public void setStreamingPlayer(StreamingPlayer player){
        Console.WriteLine("amplifier setStreamingPlayer");
    }

    public void setStereoSound(){
        Console.WriteLine("amplifier setStereoSound");
    }

    public void setSurroundSound(){
        Console.WriteLine("amplifier setSurroundSound");
    }

    public void setTuner(){
        Console.WriteLine("amplifier setTuner");
    }

    public void setVolume(int volume){
        Console.WriteLine($"amplifier setVolume {volume}");
    }
}

public class StreamingPlayer{
    public void on(){
        Console.WriteLine("StreamingPlayer on");
    }

    public void off(){
        Console.WriteLine("StreamingPlayer off");
    }

    public void pause(){
        Console.WriteLine("StreamingPlayer pause");
    }

    public void play(string movie){
        Console.WriteLine($"StreamingPlayer play {movie}");
    }

    public void setSurroundSound(){
        Console.WriteLine("StreamingPlayer setSurroundSound");
    }

    public void setTwoChannelAudio(){
        Console.WriteLine("StreamingPlayer setTwoChannelAudio");
    }

    public void stop(){
        Console.WriteLine("StreamingPlayer stop");
    }
}

public class Projector{
    public void on(){
        Console.WriteLine("projector on");
    }

    public void off(){
        Console.WriteLine("projector off");
    }

    public void tvMode(){
        Console.WriteLine("projector tvMode");
    }

    public void wideScreenMode(){
        Console.WriteLine("projector wideScreenMode");
    }
}

public class TheaterLights{
    public void on(){
        Console.WriteLine("TheaterLights on");
    }

    public void off(){
        Console.WriteLine("TheaterLights off");
    }

    public void dim(int dim){
        Console.WriteLine($"TheaterLights dim {dim}");
    }
}

public class PopcornPopper{
    public void on(){
        Console.WriteLine("PopcornPopper on");
    }

    public void off(){
        Console.WriteLine("PopcornPopper off");
    }

    public void pop(){
        Console.WriteLine("PopcornPopper pop");
    }
}

public class Screen{
    public void up(){
        Console.WriteLine("Screen up");
    }

    public void down(){
        Console.WriteLine("Screen down");
    }
}

public class Tuner{
    public void on(){
        Console.WriteLine("Tuner on");
    }

    public void off(){
        Console.WriteLine("Tuner off");
    }

    public void setAm(){
        Console.WriteLine("Tuner setAm");
    }

    public void setFm(){
        Console.WriteLine("Tuner setFm");
    }

    public void setFrequency(){
        Console.WriteLine("Tuner setFrequency");
    }
}

