public class GumballMachine{
    private static int SOLD_OUT = 0;
    private static int NO_QUARTER = 1;
    private static int HAS_QUARTER = 2;
    private static int SOLD = 3;
    private int state = SOLD_OUT;
    public int Count = 0;

    public GumballMachine(int count){
        this.Count = count;
        if(count > 0 ){
            state = NO_QUARTER;
        }
    }

    public void InsertQuarter(){
        if(state == HAS_QUARTER){
            Console.WriteLine("동전은 한 개만 넣어주세요");
        } else if (state == NO_QUARTER){
            state = HAS_QUARTER;
            Console.WriteLine("동전이 투입되었습니다.");
        } else if(state == SOLD_OUT){
            Console.WriteLine("매진되었습니다.");
        } else if(state == SOLD){
            Console.WriteLine("알맹이를 내보내고 있습니다.");
        }
    }

    public void EjectQuarter(){
        if(state == HAS_QUARTER){
            Console.WriteLine("동전이 반환됩니다.");
        } else if (state == NO_QUARTER){
            state = HAS_QUARTER;
            Console.WriteLine("동전을 넣어주세요.");
        } else if(state == SOLD_OUT){
            Console.WriteLine("동전을 넣지 않았습니다. 동전이 반환되지 않습니다.");
        } else if(state == SOLD){
            Console.WriteLine("이미 알맹이를 뽑았습니다.");            
        }
    }

    public void TurnCrank(){
        if(state == SOLD){
            Console.WriteLine("손잡이는 한번만 돌려주세요.");            
        }else if (state == NO_QUARTER){
            Console.WriteLine("동전을 넣어주세요.");
        } else if(state == SOLD_OUT){
            Console.WriteLine("매진되었습니다.");
        } else if(state == HAS_QUARTER){
            Console.WriteLine("손잡이를 돌리셨습니다.");
            state = SOLD;
            dispense();
        }
    }

    public void dispense(){
        if(state == SOLD){
            Console.WriteLine("알맹이를 내보내고 있습니다.");
            Count = Count - 1;
            if(Count == 0){
                Console.WriteLine("더 이상 알맹이가 없습니다.");
                state = SOLD_OUT;
            } else{
                state = NO_QUARTER;
            }
        } else if(state == NO_QUARTER){
            Console.WriteLine("동전을 넣어주세요");
        } else if(state == SOLD_OUT){
            Console.WriteLine("매진입니다.");
        } else if(state == HAS_QUARTER){
            Console.WriteLine("알맹이를 내보낼 수 없습니다.");
        }
    }
}