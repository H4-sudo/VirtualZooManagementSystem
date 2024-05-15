using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZooManagementFA3
{
    public abstract class Animal : IFeedable, IMovable, ISleepable, IThirsty
    {
        protected int hunger = 10;
        protected int thirst = 20;
        protected int energy = 100;
        protected Random random = new Random();

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public abstract int HungerLevel { get; }

        public abstract int ThirstLevel { get; }

        public abstract int EnergyLevel { get; }

        public DietInfo DietInfo { get; set; }
        public HabitatType Habitat { get; protected set; }
        public AnimalType AnimalType { get; protected set; }


        public abstract void Eat();
        public abstract void Drink();
        public abstract void Hunger();
        public abstract void IsHungry();
        public abstract void IsThirsty();
        public abstract void Move();
        public abstract void Play();
        public abstract void Sleep();
        public abstract void Stop();
        public abstract void Thirst();
    }

    public struct DietInfo
    {
        public FoodType FoodType { get; set; }
        public FeedingSchedule FeedingSchedule { get; set; }
        public int WaterIntake { get; set; }
    }

    public enum AnimalType
    {
        Mammal,
        Bird,
        Reptile,
        Amphibian,
        Fish,
        Invertebrate
    }

    public enum FoodType
    {
        Carnivore,
        Herbivore,
        Omnivore
    }

    public enum HabitatType
    {
        Desert,
        Forest,
        Urban,
        Mountain,
        Grassland,
        Tundra,
        Aquatic
    }

    public enum FeedingSchedule
    {
        Regular,
        Irregular,
        Morning,
        Afternoon,
        Evening
    }

    public interface IFeedable
    {
        void IsHungry();
        void Eat();
        void Hunger();
    }

    public interface IMovable
    {
        void Move();
        void Stop();
    }

    public interface ISleepable
    {
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

    public interface IClimable
    {
        void Climb();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Lion : Animal
    {
        public override int HungerLevel => hunger;
        public override int ThirstLevel => thirst;
        public override int EnergyLevel => energy;

        public Lion(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
            DietInfo = new DietInfo
            {
                FoodType = FoodType.Carnivore,
                FeedingSchedule = FeedingSchedule.Regular,
                WaterIntake = 50
            };
            Habitat = HabitatType.Grassland;
            AnimalType = AnimalType.Mammal;
        }

        public override void Hunger()
        {
            // Simulate hunger increase over time or activity
            hunger += random.Next(1, 10); // Increase hunger randomly
            if (hunger > 100)
            {
                hunger = 100; // Cap hunger at 100
            }
            if (hunger > 50)
            {
                IsHungry(); // Invoke IsHungry() method when hunger exceeds a certain threshold
            }
        }

        public override void IsHungry()
        {
            energy--; // Decrease energy when the lion is hungry
        }

        public override void Eat()
        {
            hunger -= 10; // Decrease hunger when the lion eats
            if (hunger < 0)
            {
                hunger = 0; // Ensure hunger does not go below 0
            }
        }

        public override void Sleep()
        {
            energy = Math.Min(energy + 20, 100);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Play()
        {
            energy = Math.Max(energy - 20, 0);
            hunger = Math.Min(hunger + 15, 100);
            thirst = Math.Min(thirst + 15, 100);
        }

        public override void Drink()
        {
            thirst -= 10;
            if (thirst < 0)
            {
                thirst = 0;
            }
        }

        public override void Thirst()
        {
            // Simulate thirst increase over time or activity
            thirst += random.Next(1, 10); // Increase thirst randomly
            if (thirst > 100)
            {
                thirst = 100; // Cap thirst at 100
            }
            if (thirst > 50)
            {
                IsThirsty(); // Invoke IsThirsty() method when thirst exceeds a certain threshold
            }
        }

        public override void IsThirsty()
        {
            energy--; // Decrease energy when the lion is thirsty
        }

        public override void Move()
        {
            energy--; // Decrease energy when the lion moves
            thirst++; // Increase thirst when the lion moves
            hunger++; // Increase hunger when the lion moves
        }

        public override void Stop()
        {
            energy++;
        }

    }

    public class Elephant : Animal
    {
        public override int HungerLevel => hunger;
        public override int ThirstLevel => thirst;
        public override int EnergyLevel => energy;

        public Elephant(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
            DietInfo = new DietInfo
            {
                FoodType = FoodType.Herbivore,
                FeedingSchedule = FeedingSchedule.Regular,
                WaterIntake = 100
            };
            Habitat = HabitatType.Grassland;
            AnimalType = AnimalType.Mammal;
        }

        public override void Hunger()
        {
            // Simulate hunger increase over time or activity
            hunger += random.Next(1, 10); // Increase hunger randomly
            if (hunger > 100)
            {
                hunger = 100; // Cap hunger at 100
            }
            if (hunger > 50)
            {
                IsHungry(); // Invoke IsHungry() method when hunger exceeds a certain threshold
            }
        }

        public override void Drink()
        {
            thirst -= 10;
            if (thirst < 0)
            {
                thirst = 0;
            }
        }

        public override void IsHungry()
        {
            energy--; // Decrease energy when the lion is hungry
        }

        public override void Eat()
        {
            hunger -= 10; // Decrease hunger when the lion eats
            if (hunger < 0)
            {
                hunger = 0; // Ensure hunger does not go below 0
            }
        }

        public override void Sleep()
        {
            energy = Math.Min(energy + 20, 100);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Play()
        {
            energy = Math.Max(energy - 20, 0);
            hunger = Math.Min(hunger + 15, 100);
            thirst = Math.Min(thirst + 15, 100);
        }

        public override void Thirst()
        {
            // Simulate thirst increase over time or activity
            thirst += random.Next(1, 10); // Increase thirst randomly
            if (thirst > 100)
            {
                thirst = 100; // Cap thirst at 100
            }
            if (thirst > 50)
            {
                IsThirsty(); // Invoke IsThirsty() method when thirst exceeds a certain threshold
            }
        }

        public override void IsThirsty()
        {
            energy--; // Decrease energy when the lion is thirsty
        }

        public override void Move()
        {
            energy--; // Decrease energy when the lion moves
            thirst++; // Increase thirst when the lion moves
            hunger++; // Increase hunger when the lion moves
        }

        public override void Stop()
        {
            energy++;
        }

    }

    public class Parrot : Animal
    {
        public override int HungerLevel => hunger;
        public override int ThirstLevel => thirst;
        public override int EnergyLevel => energy;

        public Parrot(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
            DietInfo = new DietInfo
            {
                FoodType = FoodType.Herbivore,
                FeedingSchedule = FeedingSchedule.Morning,
                WaterIntake = 1
            };
            Habitat = HabitatType.Grassland;
            AnimalType = AnimalType.Bird;
        }

        public void Fly()
        {
            energy = Math.Max(energy - 10, 0);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Hunger()
        {
            // Simulate hunger increase over time or activity
            hunger += random.Next(1, 10); // Increase hunger randomly
            if (hunger > 100)
            {
                hunger = 100; // Cap hunger at 100
            }
            if (hunger > 50)
            {
                IsHungry(); // Invoke IsHungry() method when hunger exceeds a certain threshold
            }
        }

        public override void IsHungry()
        {
            energy--; // Decrease energy when the lion is hungry
        }

        public override void Eat()
        {
            hunger -= 10; // Decrease hunger when the lion eats
            if (hunger < 0)
            {
                hunger = 0; // Ensure hunger does not go below 0
            }
        }

        public override void Sleep()
        {
            energy = Math.Min(energy + 20, 100);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Play()
        {
            energy = Math.Max(energy - 20, 0);
            hunger = Math.Min(hunger + 15, 100);
            thirst = Math.Min(thirst + 15, 100);
        }

        public override void Drink()
        {
            thirst -= 10;
            if (thirst < 0)
            {
                thirst = 0;
            }
        }

        public override void Thirst()
        {
            // Simulate thirst increase over time or activity
            thirst += random.Next(1, 10); // Increase thirst randomly
            if (thirst > 100)
            {
                thirst = 100; // Cap thirst at 100
            }
            if (thirst > 50)
            {
                IsThirsty(); // Invoke IsThirsty() method when thirst exceeds a certain threshold
            }
        }

        public override void IsThirsty()
        {
            energy--; // Decrease energy when the lion is thirsty
        }

        public override void Move()
        {
            energy--; // Decrease energy when the lion moves
            thirst++; // Increase thirst when the lion moves
            hunger++; // Increase hunger when the lion moves
        }

        public override void Stop()
        {
            energy++;
        }

    }

    public class Turtle : Animal
    {
        public override int HungerLevel => hunger;
        public override int ThirstLevel => thirst;
        public override int EnergyLevel => energy;

        public Turtle(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
            DietInfo = new DietInfo
            {
                FoodType = FoodType.Herbivore,
                FeedingSchedule = FeedingSchedule.Regular,
                WaterIntake = 2
            };
            Habitat = HabitatType.Grassland;
            AnimalType = AnimalType.Mammal;
        }

        public override void Hunger()
        {
            // Simulate hunger increase over time or activity
            hunger += random.Next(1, 10); // Increase hunger randomly
            if (hunger > 100)
            {
                hunger = 100; // Cap hunger at 100
            }
            if (hunger > 50)
            {
                IsHungry(); // Invoke IsHungry() method when hunger exceeds a certain threshold
            }
        }

        public override void IsHungry()
        {
            energy--; // Decrease energy when the lion is hungry
        }

        public override void Eat()
        {
            hunger -= 10; // Decrease hunger when the lion eats
            if (hunger < 0)
            {
                hunger = 0; // Ensure hunger does not go below 0
            }
        }

        public override void Sleep()
        {
            energy = Math.Min(energy + 20, 100);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Play()
        {
            energy = Math.Max(energy - 20, 0);
            hunger = Math.Min(hunger + 15, 100);
            thirst = Math.Min(thirst + 15, 100);
        }

        public override void Drink()
        {
            thirst -= 10;
            if (thirst < 0)
            {
                thirst = 0;
            }
        }

        public override void Thirst()
        {
            // Simulate thirst increase over time or activity
            thirst += random.Next(1, 10); // Increase thirst randomly
            if (thirst > 100)
            {
                thirst = 100; // Cap thirst at 100
            }
            if (thirst > 50)
            {
                IsThirsty(); // Invoke IsThirsty() method when thirst exceeds a certain threshold
            }
        }

        public override void IsThirsty()
        {
            energy--; // Decrease energy when the lion is thirsty
        }

        public override void Move()
        {
            energy--; // Decrease energy when the lion moves
            thirst++; // Increase thirst when the lion moves
            hunger++; // Increase hunger when the lion moves
        }

        public override void Stop()
        {
            energy++;
        }

    }

    public class Monkey : Animal
    {
        public override int HungerLevel => hunger;
        public override int ThirstLevel => thirst;
        public override int EnergyLevel => energy;

        public Monkey(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
            DietInfo = new DietInfo
            {
                FoodType = FoodType.Omnivore,
                FeedingSchedule = FeedingSchedule.Regular,
                WaterIntake = 2
            };
            Habitat = HabitatType.Grassland;
            AnimalType = AnimalType.Mammal;
        }

        public void Climb()
        {
            energy = Math.Max(energy - 10, 0);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Hunger()
        {
            // Simulate hunger increase over time or activity
            hunger += random.Next(1, 10); // Increase hunger randomly
            if (hunger > 100)
            {
                hunger = 100; // Cap hunger at 100
            }
            if (hunger > 50)
            {
                IsHungry(); // Invoke IsHungry() method when hunger exceeds a certain threshold
            }
        }

        public override void IsHungry()
        {
            energy--; // Decrease energy when the lion is hungry
        }

        public override void Eat()
        {
            hunger -= 10; // Decrease hunger when the lion eats
            if (hunger < 0)
            {
                hunger = 0; // Ensure hunger does not go below 0
            }
        }

        public override void Sleep()
        {
            energy = Math.Min(energy + 20, 100);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Play()
        {
            energy = Math.Max(energy - 20, 0);
            hunger = Math.Min(hunger + 15, 100);
            thirst = Math.Min(thirst + 15, 100);
        }

        public override void Drink()
        {
            thirst -= 10;
            if (thirst < 0)
            {
                thirst = 0;
            }
        }

        public override void Thirst()
        {
            // Simulate thirst increase over time or activity
            thirst += random.Next(1, 10); // Increase thirst randomly
            if (thirst > 100)
            {
                thirst = 100; // Cap thirst at 100
            }
            if (thirst > 50)
            {
                IsThirsty(); // Invoke IsThirsty() method when thirst exceeds a certain threshold
            }
        }

        public override void IsThirsty()
        {
            energy--; // Decrease energy when the lion is thirsty
        }

        public override void Move()
        {
            energy--; // Decrease energy when the lion moves
            thirst++; // Increase thirst when the lion moves
            hunger++; // Increase hunger when the lion moves
        }

        public override void Stop()
        {
            energy++;
        }

    }

    public class PolarBear : Animal
    {
        public override int HungerLevel => hunger;
        public override int ThirstLevel => thirst;
        public override int EnergyLevel => energy;

        public PolarBear(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
            DietInfo = new DietInfo
            {
                FoodType = FoodType.Carnivore,
                FeedingSchedule = FeedingSchedule.Regular,
                WaterIntake = 40
            };
            Habitat = HabitatType.Grassland;
            AnimalType = AnimalType.Mammal;
        }

        public override void Hunger()
        {
            // Simulate hunger increase over time or activity
            hunger += random.Next(1, 10); // Increase hunger randomly
            if (hunger > 100)
            {
                hunger = 100; // Cap hunger at 100
            }
            if (hunger > 50)
            {
                IsHungry(); // Invoke IsHungry() method when hunger exceeds a certain threshold
            }
        }

        public override void IsHungry()
        {
            energy--; // Decrease energy when the lion is hungry
        }

        public override void Eat()
        {
            hunger -= 10; // Decrease hunger when the lion eats
            if (hunger < 0)
            {
                hunger = 0; // Ensure hunger does not go below 0
            }
        }

        public override void Sleep()
        {
            energy = Math.Min(energy + 20, 100);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Play()
        {
            energy = Math.Max(energy - 20, 0);
            hunger = Math.Min(hunger + 15, 100);
            thirst = Math.Min(thirst + 15, 100);
        }

        public override void Drink()
        {
            thirst -= 10;
            if (thirst < 0)
            {
                thirst = 0;
            }
        }

        public override void Thirst()
        {
            // Simulate thirst increase over time or activity
            thirst += random.Next(1, 10); // Increase thirst randomly
            if (thirst > 100)
            {
                thirst = 100; // Cap thirst at 100
            }
            if (thirst > 50)
            {
                IsThirsty(); // Invoke IsThirsty() method when thirst exceeds a certain threshold
            }
        }

        public override void IsThirsty()
        {
            energy--; // Decrease energy when the lion is thirsty
        }

        public override void Move()
        {
            energy--; // Decrease energy when the lion moves
            thirst++; // Increase thirst when the lion moves
            hunger++; // Increase hunger when the lion moves
        }

        public override void Stop()
        {
            energy++;
        }

    }

    public class Giraffe : Animal
    {
        public override int HungerLevel => hunger;
        public override int ThirstLevel => thirst;
        public override int EnergyLevel => energy;

        public Giraffe(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
            DietInfo = new DietInfo
            {
                FoodType = FoodType.Herbivore,
                FeedingSchedule = FeedingSchedule.Regular,
                WaterIntake = 35
            };
            Habitat = HabitatType.Grassland;
            AnimalType = AnimalType.Mammal;
        }

        public override void Hunger()
        {
            // Simulate hunger increase over time or activity
            hunger += random.Next(1, 10); // Increase hunger randomly
            if (hunger > 100)
            {
                hunger = 100; // Cap hunger at 100
            }
            if (hunger > 50)
            {
                IsHungry(); // Invoke IsHungry() method when hunger exceeds a certain threshold
            }
        }

        public override void IsHungry()
        {
            energy--; // Decrease energy when the lion is hungry
        }

        public override void Eat()
        {
            hunger -= 10; // Decrease hunger when the lion eats
            if (hunger < 0)
            {
                hunger = 0; // Ensure hunger does not go below 0
            }
        }

        public override void Sleep()
        {
            energy = Math.Min(energy + 20, 100);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Play()
        {
            energy = Math.Max(energy - 20, 0);
            hunger = Math.Min(hunger + 15, 100);
            thirst = Math.Min(thirst + 15, 100);
        }

        public override void Drink()
        {
            thirst -= 10;
            if (thirst < 0)
            {
                thirst = 0;
            }
        }

        public override void Thirst()
        {
            // Simulate thirst increase over time or activity
            thirst += random.Next(1, 10); // Increase thirst randomly
            if (thirst > 100)
            {
                thirst = 100; // Cap thirst at 100
            }
            if (thirst > 50)
            {
                IsThirsty(); // Invoke IsThirsty() method when thirst exceeds a certain threshold
            }
        }

        public override void IsThirsty()
        {
            energy--; // Decrease energy when the lion is thirsty
        }

        public override void Move()
        {
            energy--; // Decrease energy when the lion moves
            thirst++; // Increase thirst when the lion moves
            hunger++; // Increase hunger when the lion moves
        }

        public override void Stop()
        {
            energy++;
        }

    }

    public class Kangaroo : Animal
    {
        public override int HungerLevel => hunger;
        public override int ThirstLevel => thirst;
        public override int EnergyLevel => energy;

        public Kangaroo(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
            DietInfo = new DietInfo
            {
                FoodType = FoodType.Herbivore,
                FeedingSchedule = FeedingSchedule.Regular,
                WaterIntake = 20
            };
            Habitat = HabitatType.Grassland;
            AnimalType = AnimalType.Mammal;
        }

        public override void Hunger()
        {
            // Simulate hunger increase over time or activity
            hunger += random.Next(1, 10); // Increase hunger randomly
            if (hunger > 100)
            {
                hunger = 100; // Cap hunger at 100
            }
            if (hunger > 50)
            {
                IsHungry(); // Invoke IsHungry() method when hunger exceeds a certain threshold
            }
        }

        public override void IsHungry()
        {
            energy--; // Decrease energy when the lion is hungry
        }

        public override void Eat()
        {
            hunger -= 10; // Decrease hunger when the lion eats
            if (hunger < 0)
            {
                hunger = 0; // Ensure hunger does not go below 0
            }
        }

        public override void Sleep()
        {
            energy = Math.Min(energy + 20, 100);
            hunger = Math.Min(hunger + 10, 100);
            thirst = Math.Min(thirst + 10, 100);
        }

        public override void Play()
        {
            energy = Math.Max(energy - 20, 0);
            hunger = Math.Min(hunger + 15, 100);
            thirst = Math.Min(thirst + 15, 100);
        }

        public override void Drink()
        {
            thirst -= 10;
            if (thirst < 0)
            {
                thirst = 0;
            }
        }

        public override void Thirst()
        {
            // Simulate thirst increase over time or activity
            thirst += random.Next(1, 10); // Increase thirst randomly
            if (thirst > 100)
            {
                thirst = 100; // Cap thirst at 100
            }
            if (thirst > 50)
            {
                IsThirsty(); // Invoke IsThirsty() method when thirst exceeds a certain threshold
            }
        }

        public override void IsThirsty()
        {
            energy--; // Decrease energy when the lion is thirsty
        }

        public override void Move()
        {
            energy--; // Decrease energy when the lion moves
            thirst++; // Increase thirst when the lion moves
            hunger++; // Increase hunger when the lion moves
        }

        public override void Stop()
        {
            energy++;
        }

    }
}
