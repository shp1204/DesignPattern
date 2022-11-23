public class GumballMachine{
    MachineState soldOutState;
    MachineState noQuarterState;
    MachineState hasQuarterState;
    MachineState soldState;

    MachineState state;
    int Count = 0;

    public GumballMachine(int count){
        soldOutState = new SoldOutState(this);
        noQuarterState = new NoQuarterState(this);
        hasQuarterState = new HasQuarterState(this);
        soldState = new SoldState(this);

        this.Count = count;
        if(count > 0){
            state = noQuarterState;
        }else{
            state = soldOutState;
        }
    }

    public void InsertQuarter(){
        state.InsertQuarter();
    }

    public void EjectQuarter(){
        state.EjectQuarter();
    }

    public void TurnCrank(){
        state.TurnCrank();
        state.Dispense();
    }

    public void SetState(MachineState state){
        this.state = state;
    }

    public void ReleaseBall(){
        Console.WriteLine("알맹이를 내보내고 있습니다.");
        if(Count > 0){
            Count = Count -1;
        }
    }

    public int GetCount(){
        return Count;
    }

    public MachineState GetHasQuarterState(){
        return hasQuarterState;
    }

    public MachineState GetNoQuarterState(){
        return noQuarterState;
    }

    public MachineState GetSoldState(){
        return soldState;
    }

    public MachineState GetSoldOutState(){
        return soldOutState;
    }
}