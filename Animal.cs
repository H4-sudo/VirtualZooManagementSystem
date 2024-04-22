using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZooManagementSystem
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }
        
    }
    public interface IFeedable
    {
        void IsHungry();
        void Eat();
        void Hunger();
        void Energy();
    }

    public interface IMovable
    {
        void Move();
        void Energy();
        void Stop();
    }

    public interface ISleepable
    {
        void Energy();
        void Sleep();
    }

    public interface ISoundable
    {
        void MakeSound();
        void StopSound();
    }

    public interface IThirsty
    {
        void Thirst();
        void IsThirsty();
    }

    public class Lion : Animal, IFeedable, IMovable, ISleepable, ISoundable, IThirsty
    {
        int hunger = 10;
        int thirst = 20;
        int energy = 100;
        public void Hunger()
        {
            Random random = new Random();
            hunger += random.Next(1, 10);
            if (hunger > 50)
            {
                this.IsHungry();
            } else if (hunger > 100)
            {
                this.IsAlive = false;
            }
        }

        public void IsHungry()
        {
            energy--;
        }

        public void Eat()
        {
            hunger -= 10;
        }

        public void Move()
        {
            energy--;
            thirst++;
            hunger++;

        }

        public void Energy()
        {
            energy++;
        }

        public void Stop()
        {
            energy++;
        }

        public void Sleep()
        {
            energy += 10;
        }

        public void Thirst()
        {
            thirst++;
        }

        public void IsThirsty()
        {
            if (thirst > 50)
            {
                energy--;
            } else if (thirst > 100)
            {
                this.IsAlive = false;
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("Roar");
        }

        public void StopSound()
        {
            Console.WriteLine("...");
        }

    }

    public class Elephant : Animal, IFeedable, IMovable, ISleepable, ISoundable, IThirsty
    {
        int hunger = 10;
        int thirst = 20;
        int energy = 100;
        public void Hunger()
        {
            Random random = new Random();
            hunger += random.Next(1, 10);
            if (hunger > 50)
            {
                this.IsHungry();
            } else if (hunger > 100)
            {
                this.IsAlive = false;
            }
        }

        public void IsHungry()
        {
            energy--;
        }

        public void Eat()
        {
            hunger -= 10;
        }

        public void Move()
        {
            energy--;
            thirst++;
            hunger++;

        }

        public void Energy()
        {
            energy++;
        }

        public void Stop()
        {
            energy++;
        }

        public void Sleep()
        {
            energy += 10;
        }

        public void Thirst()
        {
            thirst++;
        }

        public void IsThirsty()
        {
            if (thirst > 50)
            {
                energy--;
            } else if (thirst > 100)
            {
                this.IsAlive = false;
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("Trumpet");
        }

        public void StopSound()
        {
            Console.WriteLine("...");
        }

    }

    public class Parrot : Animal, IFeedable, IMovable, ISleepable, ISoundable, IThirsty
    {
        int hunger = 10;
        int thirst = 20;
        int energy = 100;
        public void Hunger()
        {
            Random random = new Random();
            hunger += random.Next(1, 10);
            if (hunger > 50)
            {
                this.IsHungry();
            } else if (hunger > 100)
            {
                this.IsAlive = false;
            }
        }

        public void IsHungry()
        {
            energy--;
        }

        public void Eat()
        {
            hunger -= 10;
        }

        public void Move()
        {
            energy--;
            thirst++;
            hunger++;

        }

        public void Fly()
        {
            energy--;
            thirst++;
            hunger++;
        }

        public void Speak()
        {
            energy--;
            thirst++;
            hunger++;
        }

        public void Energy()
        {
            energy++;
        }

        public void Stop()
        {
            energy++;
        }

        public void Sleep()
        {
            energy += 10;
        }

        public void Thirst()
        {
            thirst++;
        }

        public void IsThirsty()
        {
            if (thirst > 50)
            {
                energy--;
            } else if (thirst > 100)
            {
                this.IsAlive = false;
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("Chirp");
        }

        public void StopSound()
        {
            Console.WriteLine("...");
        }

    }

    public class Turtle : Animal, IFeedable, IMovable, ISleepable, ISoundable, IThirsty
    {
        int hunger = 10;
        int thirst = 20;
        int energy = 100;
        public void Hunger()
        {
            Random random = new Random();
            hunger += random.Next(1, 10);
            if (hunger > 50)
            {
                this.IsHungry();
            } else if (hunger > 100)
            {
                this.IsAlive = false;
            }
        }

        public void IsHungry()
        {
            energy--;
        }

        public void Eat()
        {
            hunger -= 10;
        }

        public void Move()
        {
            energy--;
            thirst++;
            hunger++;

        }

        public void Energy()
        {
            energy++;
        }

        public void Stop()
        {
            energy++;
        }

        public void Sleep()
        {
            energy += 10;
        }

        public void Thirst()
        {
            thirst++;
        }

        public void IsThirsty()
        {
            if (thirst > 50)
            {
                energy--;
            } else if (thirst > 100)
            {
                this.IsAlive = false;
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("...");
        }

        public void StopSound()
        {
            Console.WriteLine("...");
        }

    }

}

