public class HomteTheaterFacade{
    Amplifier amp;
    Tuner tuner;
    StreamingPlayer player;
    Projector projector;
    TheaterLights lightss;
    Screen screen;
    PopcornPopper popper;

    public HomteTheaterFacade(Amplifier amp, Tuner tuner, StreamingPlayer player,
    Projector projector, Screen screen, TheaterLights lights, PopcornPopper popper){
        this.amp = amp;
        this.tuner = tuner;
        this.player = player;
        this.projector = projector;
        this.screen = screen;
        this.lightss = lights;
        this.popper = popper;
    }

    public void watchMovie(string movie){
        Console.WriteLine("영화 볼 준비 중");
        popper.on();
        popper.pop();
        lightss.dim(10);
        screen.down();
        projector.on();
        projector.wideScreenMode();
        amp.on();
        amp.setStreamingPlayer(player);
        amp.setSurroundSound();
        amp.setVolume(5);
        player.on();
        player.play(movie);
    } 

    public void endMovie(){
        Console.WriteLine("홈시어터 종료 중");
        popper.off();
        lightss.on();
        screen.up();
        projector.off();
        amp.off();
        player.stop();
        player.off();
    }
}