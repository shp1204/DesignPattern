public class NoQuarterState : MachineState{
    GumballMachine gumballMachine;

    public NoQuarterState(GumballMachine gumballMachine){
        this.gumballMachine = gumballMachine;
    }

    public override void InsertQuarter(){
        Console.WriteLine("동전을 넣었습니다.");
        gumballMachine.SetState(gumballMachine.GetHasQuarterState());
    }

    public override void EjectQuarter(){
        Console.WriteLine("동전을 넣어주세요.");
    }

    public override void TurnCrank(){
        Console.WriteLine("동전을 넣어주세요.");
    }

    public override void Dispense(){
        Console.WriteLine("동전을 넣어주세요.");
    }
}

public class HasQuarterState : MachineState {
    GumballMachine gumballMachine;

    public HasQuarterState(GumballMachine gumballMachine){
        this.gumballMachine = gumballMachine;
    }

    public override void InsertQuarter(){
        Console.WriteLine("동전은 한 개만 넣어주세요");
    }

    public override void EjectQuarter(){
        Console.WriteLine("동전이 반환됩니다.");
        gumballMachine.SetState(gumballMachine.GetNoQuarterState());
    }

    public override void TurnCrank(){
        Console.WriteLine("손잡이를 돌리셨습니다.");
        gumballMachine.SetState(gumballMachine.GetSoldState());
    }

    public override void Dispense(){
        Console.WriteLine("알맹이를 내보낼 수 없습니다.");
    }
}

public class SoldState : MachineState {
    GumballMachine gumballMachine;

    public SoldState(GumballMachine gumballMachine){
        this.gumballMachine = gumballMachine;
    }

    public override void InsertQuarter(){
        Console.WriteLine("알맹이를 내보내고 있습니다.");
    }

    public override void EjectQuarter(){
        Console.WriteLine("이미 알맹이를 뽑았습니다.");  
    }

    public override void TurnCrank(){
        Console.WriteLine("손잡이는 한번만 돌려주세요."); 
    }

    public override void Dispense(){
        gumballMachine.ReleaseBall();
        if(gumballMachine.GetCount() > 0 ){
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }else{
            Console.WriteLine("더 이상 알맹이가 없습니다.");
            gumballMachine.SetState(gumballMachine.GetSoldOutState());
        }
    }
}

public class SoldOutState : MachineState {
    GumballMachine gumballMachine;

    public SoldOutState(GumballMachine gumballMachine){
        this.gumballMachine = gumballMachine;
    }

    public override void InsertQuarter(){
        Console.WriteLine("매진되었습니다.");
    }

    public override void EjectQuarter(){
        Console.WriteLine("동전을 넣지 않았습니다. 동전이 반환되지 않습니다.");
    }

    public override void TurnCrank(){
        Console.WriteLine("매진되었습니다.");
    }

    public override void Dispense(){
        Console.WriteLine("알맹이를 내보낼 수 없습니다.");
    }
}