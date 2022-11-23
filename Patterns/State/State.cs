public class State{
    public static void Run(){
        GumballMachine machine = new GumballMachine(5);

        Console.WriteLine(machine);
        Console.WriteLine($"남은 개수 : {machine.GetCount()}개");

        machine.InsertQuarter();
        machine.TurnCrank();

        Console.WriteLine(machine);
        Console.WriteLine($"남은 개수 : {machine.GetCount()}개");

        machine.InsertQuarter();
        machine.EjectQuarter();
        machine.TurnCrank();

        Console.WriteLine(machine);
        Console.WriteLine($"남은 개수 : {machine.GetCount()}개");

        machine.InsertQuarter();
        machine.TurnCrank();
        machine.InsertQuarter();
        machine.TurnCrank();
        machine.EjectQuarter();

        Console.WriteLine(machine);
        Console.WriteLine($"남은 개수 : {machine.GetCount()}개");

        machine.InsertQuarter();
        machine.InsertQuarter();
        machine.TurnCrank();
        machine.InsertQuarter();
        machine.TurnCrank();
        machine.InsertQuarter();
        machine.TurnCrank();

        Console.WriteLine(machine);
        Console.WriteLine($"남은 개수 : {machine.GetCount()}개");
    }
}