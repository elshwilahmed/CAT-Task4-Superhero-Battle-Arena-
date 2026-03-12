namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseHero[] heroes = new BaseHero[3];
            heroes[0] = new Warrior(25, 150, "Ranger");
            heroes[1] = new Mage(40, 80, "Gandalf");
            heroes[2] = new Archer(30, 100, "Legolas");

            Console.WriteLine("\nHeroes: ");
            foreach (var h in heroes)
            {
                h.Introduce();
            }

            Console.WriteLine("\n=== Battle Starts! ===");
            Console.WriteLine($"{heroes[0].Name} VS {heroes[1].Name}");
            heroes[0].Attack();
            heroes[1].Health -= heroes[0].Power;
            if (heroes[1].Health <= 0)
            {
                Console.WriteLine($"{heroes[1].Name} has been defeated!");
            }
            else
            {
                heroes[1].Heal();
                Console.WriteLine($"{heroes[1].Name} health = {heroes[1].Health}");
            }

        }
    }
    public abstract class BaseHero
    {
        private int health;
        private int power;
        public int Power
        {
            set { power = value; }
            get { return power; }
        }
        public int Health
        {
            set { health = value; }
            get { return health; }
        }
        public string Name { get; set; }

        public BaseHero(int power, int health, string name)
        {
            Power = power;
            Health = health;
            Name = name;
        }

        public abstract void Attack();
        public void Introduce()
        {
            Console.WriteLine($"I'm {Name}! My Health is {Health} and My power is {Power}");

        }
        public void Heal()
        {
            Health += 20;
        }
        public void Heal(int val)
        {
            Health += val;
        }
    }
    public class Warrior : BaseHero
    {
        public Warrior(int power, int health, string name) : base(power, health, name)
        {
            Console.WriteLine($"A new warrior named {name} ");
        }
        public override void Attack()
        {
            Console.WriteLine($"Warrior {Name} swings a giant sword for {Power} damage!");
        }
    }
    public class Mage : BaseHero
    {
        public Mage(int power, int health, string name) : base(power, health, name)
        {
            Console.WriteLine($"A new Mage named {name} ");
        }
        public override void Attack()
        {
            Console.WriteLine($"Mage {Name} casts a fireball for {Power} damage!");
        }
    }
    public class Archer : BaseHero
    {
        public Archer(int power, int health, string name) : base(power, health, name)
        {
            Console.WriteLine($"A new Archer named {name} ");
        }
        public override void Attack()
        {
            Console.WriteLine($"Archer {Name} shoots a piercing arrow for {Power} damage!");
        }

    }

}
