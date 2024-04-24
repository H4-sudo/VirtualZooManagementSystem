using System;
using System.Media;

namespace VirtualZooManagementSystem
{
    public abstract class Animal : IFeedable, IMovable, ISleepable, ISoundable, IThirsty
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract int HungerLevel { get; }

        public abstract int ThirstLevel { get; }
        
        public abstract int EnergyLevel { get; }

        public abstract void Eat();
        public abstract void Energy();
        public abstract void Hunger();
        public abstract void IsHungry();
        public abstract void IsThirsty();
        public abstract void MakeSound();
        public abstract void Move();
        public abstract void Sleep();
        public abstract void Stop();
        public abstract void StopSound();
        public abstract void Thirst();
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

    public class Lion : Animal
    {
        int hunger = 10;
        int thirst = 20;
        int energy = 100;

        public override int HungerLevel
        {
            get { return hunger; }
        }

        public override int ThirstLevel
        {
            get { return thirst; }
        }

        public override int EnergyLevel
        {
            get { return energy; }
        }

        public override void Hunger()
        {
            Random random = new Random();
            hunger += random.Next(1, 10);
            if (hunger > 50)
            {
                this.IsHungry();
            } else if (hunger > 100)
            {
                energy = 10;
            }
        }

        public override void IsHungry()
        {
            energy--;
        }

        public override void Eat()
        {
            hunger -= 10;
        }

        public override void Move()
        {
            energy--;
            thirst++;
            hunger++;

        }

        public override void Energy()
        {
            energy++;
        }

        public override void Stop()
        {
            energy++;
        }

        public override void Sleep()
        {
            energy += 10;
        }

        public override void Thirst()
        {
            thirst++;
        }

        public override void IsThirsty()
        {
            if (thirst > 50)
            {
                energy--;
            } else if (thirst > 100)
            {
                energy = 10;
            }
        }

        public override void MakeSound()
        {
            SoundPlayer sound = new SoundPlayer("lion-roar.wav");
            sound.Play();
        }

        public override void StopSound()
        {
            Console.WriteLine("...");
        }

    }

    public class Elephant : Animal
    {
        int hunger = 10;
        int thirst = 20;
        int energy = 100;

        public override int HungerLevel
        {
            get { return hunger; }
        }

        public override int ThirstLevel
        {
            get { return thirst; }
        }

        public override int EnergyLevel
        {
            get { return energy; }
        }

        public override void Hunger()
        {
            Random random = new Random();
            hunger += random.Next(1, 10);
            if (hunger > 50)
            {
                this.IsHungry();
            } else if (hunger > 100)
            {
                energy = 10;
            }
        }

        public override void IsHungry()
        {
            energy--;
        }

        public override void Eat()
        {
            hunger -= 10;
        }

        public override void Move()
        {
            energy--;
            thirst++;
            hunger++;

        }

        public override void Energy()
        {
            energy++;
        }

        public override void Stop()
        {
            energy++;
        }

        public override void Sleep()
        {
            energy += 10;
        }

        public override void Thirst()
        {
            thirst++;
        }

        public override void IsThirsty()
        {
            if (thirst > 50)
            {
                energy--;
            } else if (thirst > 100)
            {
                energy = 10;
            }
        }

        public override void MakeSound()
        {
            SoundPlayer sound = new SoundPlayer("elephant.wav");
            sound.Play();
        }

        public override void StopSound()
        {
            Console.WriteLine("...");
        }

    }

    public class Parrot : Animal
    {
        int hunger = 10;
        int thirst = 20;
        int energy = 100;
        public override int HungerLevel
        {
            get { return hunger; }
        }

        public override int ThirstLevel
        {
            get { return thirst; }
        }

        public override int EnergyLevel
        {
            get { return energy; }
        }

        public override void Hunger()
        {
            Random random = new Random();
            hunger += random.Next(1, 10);
            if (hunger > 50)
            {
                this.IsHungry();
            } else if (hunger > 100)
            {
                energy = 10;
            }
        }

        public override void IsHungry()
        {
            energy--;
        }

        public override void Eat()
        {
            hunger -= 10;
        }

        public override void Move()
        {
            energy--;
            thirst++;
            hunger++;

        }

        public override void Energy()
        {
            energy++;
        }

        public override void Stop()
        {
            energy++;
        }

        public override void Sleep()
        {
            energy += 10;
        }

        public override void Thirst()
        {
            thirst++;
        }

        public override void IsThirsty()
        {
            if (thirst > 50)
            {
                energy--;
            } else if (thirst > 100)
            {
                energy = 10;
            }
        }

        public override void MakeSound()
        {
            SoundPlayer sound = new SoundPlayer("parrot.wav");
            sound.Play();
        }

        public override void StopSound()
        {
            Console.WriteLine("...");
        }

    }

    public class Turtle : Animal
    {
        int hunger = 10;
        int thirst = 20;
        int energy = 100;

        public override int HungerLevel
        {
            get { return hunger; }
        }

        public override int ThirstLevel
        {
            get { return thirst; }
        }

        public override int EnergyLevel
        {
            get { return energy; }
        }

        public override void Hunger()
        {
            Random random = new Random();
            hunger += random.Next(1, 10);
            if (hunger > 50)
            {
                this.IsHungry();
            } else if (hunger > 100)
            {
                energy = 10;
            }
        }

        public override void IsHungry()
        {
            energy--;
        }

        public override void Eat()
        {
            hunger -= 10;
        }

        public override void Move()
        {
            energy--;
            thirst++;
            hunger++;

        }

        public override void Energy()
        {
            energy++;
        }

        public override void Stop()
        {
            energy++;
        }

        public override void Sleep()
        {
            energy += 10;
        }

        public override void Thirst()
        {
            thirst++;
        }

        public override void IsThirsty()
        {
            if (thirst > 50)
            {
                energy--;
            } else if (thirst > 100)
            {
                energy = 10;
            }
        }

        public override void MakeSound()
        {
            SoundPlayer sound = new SoundPlayer("turtle.wav");
            sound.Play();
        }

        public override void StopSound()
        {
            Console.WriteLine("...");
        }

    }

}

