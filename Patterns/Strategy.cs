namespace Patterns;
public class Strategy{
    public static void Run()
    {
        //RobotA
        Unit unit = new RobotA(new Walk(), new Fork());
        unit.Move();
        unit.Attack();
    
        //RobotB
        unit = new RobotB(new Jump(), new Fire());
        unit.Move();
        unit.Attack();
        Console.ReadKey();
    }   

    abstract class MoveBehavior
    {
        public abstract void Move();
    }

    class Walk : MoveBehavior{
        public override void Move(){
            Console.WriteLine("Walking . . .");
        }
    }

    class Jump : MoveBehavior{
        public override void Move(){
            Console.WriteLine("J ! u ! m ! p ! ");
        }
    }

    abstract class AttackBehavior{
        public abstract void Attack();
    }

    class Fork : AttackBehavior{
        public override void Attack(){
            Console.WriteLine("f~~~~~~~ork");
        }
    }

    class Fire : AttackBehavior{
        public override void Attack(){
            Console.WriteLine("f~~i~~~r~~e");
        }
    }

    class Unit{
        private MoveBehavior move;
        private AttackBehavior attack;

        public Unit(MoveBehavior move, AttackBehavior attack){
            this.move = move;
            this.attack = attack;
        }

        public void Move(){
            move.Move();
        }

        public void Attack(){
            attack.Attack();
        }
    }
    class RobotA : Unit{
        public RobotA(MoveBehavior move, AttackBehavior attack) : base(move, attack){}
    }

    class RobotB : Unit{
        public RobotB(MoveBehavior move, AttackBehavior attack) : base(move, attack){}
    }
}