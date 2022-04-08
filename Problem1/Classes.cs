using System;

namespace Problem1
{
    public class Classes
    {
        public abstract class Toy
        {
            public double Cost { get; set; }
            public string Description { get; set; }
            public string Name { get; set; }
            public string ManufacturingCompany { get; set; }
            public int YearOfManufacture { get; set; }
            public int MinimumAgeLimit { get; set; } // in years 
            public int MaximumAgeLimit { get; set; } // in years 
            public bool ChokingHazard { get; set; }
            public double Weight { get; set; } // in pounds
        }

        public class Car : Toy
        {
            public int NumberOfDoors { get; set; }
            public string Scale { get; set; }
            public int NumberOfUniqueModels { get; set; }
            public Car()
            {
                Cost = 19.99;
                Description = "Hot Wheels 20 Car Pack Assortment";
                Name = "Hot wheels";
                ManufacturingCompany = "Mattel";
                YearOfManufacture = 2020;
                MinimumAgeLimit = 3;
                MaximumAgeLimit = 93;
                ChokingHazard = true;
                Weight = 1.65;
                NumberOfDoors = 2;
                Scale = "1:64";
                NumberOfUniqueModels = 20;
            }

            public string PushAroundPlay()
            {
                return "Push the cars around using your hand to simulate real life racing where you are in control";
            }

            public string TrackSetAction()
            {
                return "Place the cars on the hot wheels track to see how fast it can go";
            }
        }

        public class Dollhouse : Toy
        {
            public double height { get; set; } // in inches
            public int NumberOfFloors { get; set; }
            public int NumberOfBatteriesRequired { get; set; }
            public Dollhouse()
            {
                Cost = 299.99;
                Description = "Barbie Dreamhouse Dollhouse with Pool, Slide, Elevator, Lights and Sounds";
                Name = "Barbie Dreamhouse";
                ManufacturingCompany = "Mattel";
                YearOfManufacture = 2021;
                MinimumAgeLimit = 3;
                MaximumAgeLimit = 7;
                ChokingHazard = true;
                Weight = 29.76;
                height = 29.88;
                NumberOfFloors = 3;
                NumberOfBatteriesRequired = 3;
            }

            public string Customizations()
            {
                return "Kids can design their own dream home -- the grass and pool can be placed in multiple" +
                    "configurations on the first and third floors, and the slide fits in 4 different unique locations";
            }

            public string SetTheScene()
            {
                return "Set the scene for any story with realisitc sound effects, 2 sounscapes, 3 songs, 8 light" +
                    "color options, and 4 light settings including day mode, night mode, party mode and mood lighting";
            }
        }

        public class StuffedAnimal : Toy
        {
            public double Height { get; set; } // in inches
            public string EyeColour { get; set; }
            public string FurColour { get; set; }
            public StuffedAnimal()
            {
                Cost = 99.99;
                Description = "Snuggle Buddies Henry Jumbo Teddy Bear";
                Name = "Snuggle Buddies";
                ManufacturingCompany = "Addo Play";
                YearOfManufacture = 2022;
                MinimumAgeLimit = 1;
                MaximumAgeLimit = 7;
                ChokingHazard = false;
                Weight = 5.51;
                Height = 49;
                EyeColour = "brown";
                FurColour = "light brown with white chest and stomach";
            }

            public string Cuddle()
            {
                return "Snuggle Buddies Henery Teddy Bear is waiting for you with his arms streched wide open." +
                    "Henry has an adorable face and lovely soft cuddly fur";
            }

            public string ShowerTime()
            {
                return "Just give Henry a surface wash when it nees a quick clean";
            }
        }

        public class RainbowStacker : Toy
        {
            public string Material { get; set; }
            public int NumberOfSets { get; set; }
            public int NumberOfLayersPerSet { get; set; }
            public RainbowStacker()
            {
                Cost = 24.99;
                Description = "Wooden Rainbow Stacker, Montessori Wooden Rainbow Stacking Toys for 3 year old Boy Girl, Nesting Blocks Puzzle for Toddlers Baby";
                Name = "KanCai Wooden Rainbow Stacker";
                ManufacturingCompany = "KanCai";
                YearOfManufacture = 2021;
                MinimumAgeLimit = 3;
                MaximumAgeLimit = 99;
                ChokingHazard = true;
                Weight = 0.24;
                Material = "Wood";
                NumberOfSets = 2;
                NumberOfLayersPerSet = 7;
            }

            public string StackingGame()
            {
                return "Stack each piece based on size to create the perfect rainbow";
            }

            public string Imagination()
            {
                return "Kids can let their imagination run free by using these pieces as brisges, tunnels, cradles and more";
            }
        }

        public class Creator
        {
            public Toy GetToy(string type)
            {
                switch(type)
                {
                    case "Car":
                        return new Car();
                    case "Dollhouse":
                        return new Dollhouse();
                    case "Stuffed Animal":
                        return new StuffedAnimal();
                    case "Rainbow Stacker":
                        return new RainbowStacker();
                    default:
                        return null;
                }
            }
        }


    }


}
