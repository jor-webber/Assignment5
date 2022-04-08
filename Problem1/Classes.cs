/*
 * The group members, Harmanpreet Dhillon, 000816379, Jordan Webber, 000803303, Ramandeep Ghotra, 000818354, 
 * certify that this material is our original work. No other person's work has been used without due acknowledgement. 
 * We have not made my work available to anyone else.
 */
using System;

namespace Problem1
{
    public class Classes
    {
        /// <summary>
        /// Abstract toy class 
        /// </summary>
        public abstract class Toy
        {
            /// <summary>
            /// price of the toy
            /// </summary>
            public double Cost { get; set; }

            /// <summary>
            /// toy description
            /// </summary>
            public string Description { get; set; }

            /// <summary>
            /// name of the toy
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// company that made the toy 
            /// </summary>
            public string ManufacturingCompany { get; set; }

            /// <summary>
            /// year toy was made 
            /// </summary>
            public int YearOfManufacture { get; set; }

            /// <summary>
            /// minimum recommended age of the toy user
            /// </summary>
            public int MinimumAgeLimit { get; set; } // in years 

            /// <summary>
            /// maximum recommended age of the toy user 
            /// </summary>
            public int MaximumAgeLimit { get; set; } // in years 

            /// <summary>
            /// if the toy is a choking hazard or not 
            /// </summary>
            public bool ChokingHazard { get; set; }

            /// <summary>
            /// weight of the toy 
            /// </summary>
            public double Weight { get; set; } // in pounds
        }

        /// <summary>
        /// Car class that inherits from the Toy class 
        /// </summary>
        public class Car : Toy
        {
            /// <summary>
            /// the number of doors each car has 
            /// </summary>
            public int NumberOfDoors { get; set; }

            /// <summary>
            /// scale that was used to determine size of the car 
            /// </summary>
            public string Scale { get; set; } // a ratio 

            /// <summary>
            /// number of models in the car set 
            /// </summary>
            public int NumberOfUniqueModels { get; set; }

            /// <summary>
            /// Create a new instance of a car 
            /// </summary>
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

            /// <summary>
            /// describes the push around action the car can preform 
            /// </summary>
            /// <returns></returns>
            public string PushAroundPlay()
            {
                return "Push the cars around using your hand to simulate real life racing where you are in control";
            }

            /// <summary>
            /// describes the how car can be used on the track set 
            /// </summary>
            /// <returns></returns>
            public string TrackSetAction()
            {
                return "Place the cars on the hot wheels track to see how fast it can go";
            }
        }

        /// <summary>
        /// Dollhouse class that inherits from Toy Class
        /// </summary>
        public class Dollhouse : Toy
        {
            /// <summary>
            /// height of dollhouse 
            /// </summary>
            public double height { get; set; } // in inches

            /// <summary>
            /// number of floors in dollhouse 
            /// </summary>
            public int NumberOfFloors { get; set; }

            /// <summary>
            /// number of batteries required for dollhouse 
            /// </summary>
            public int NumberOfBatteriesRequired { get; set; }

            /// <summary>
            /// creates a new instance of a dollhouse 
            /// </summary>
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

            /// <summary>
            /// descirbes how the dollhouse can be customized 
            /// </summary>
            /// <returns></returns>
            public string Customizations()
            {
                return "Kids can design their own dream home -- the grass and pool can be placed in multiple" +
                    "configurations on the first and third floors, and the slide fits in 4 different unique locations";
            }

            /// <summary>
            /// descibes how you can set the scene for the dollhouse 
            /// </summary>
            /// <returns></returns>
            public string SetTheScene()
            {
                return "Set the scene for any story with realisitc sound effects, 2 sounscapes, 3 songs, 8 light" +
                    "color options, and 4 light settings including day mode, night mode, party mode and mood lighting";
            }
        }

        /// <summary>
        /// StuffedAnimal class that inherits from the Toy class
        /// </summary>
        public class StuffedAnimal : Toy
        {
            /// <summary>
            /// height of the suffed animal 
            /// </summary>
            public double Height { get; set; } // in inches

            /// <summary>
            /// eye colour of the stuffed animal 
            /// </summary>
            public string EyeColour { get; set; }

            /// <summary>
            /// stuffed animals fur colour 
            /// </summary>
            public string FurColour { get; set; }

            /// <summary>
            /// creates a new instance of a stuffed animal 
            /// </summary>
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

            /// <summary>
            /// describes how you can cuddle with the stuffed animal 
            /// </summary>
            /// <returns></returns>
            public string Cuddle()
            {
                return "Snuggle Buddies Henery Teddy Bear is waiting for you with his arms streched wide open." +
                    "Henry has an adorable face and lovely soft cuddly fur";
            }

            /// <summary>
            /// describes how the stuffed animal can be cleaned 
            /// </summary>
            /// <returns></returns>
            public string ShowerTime()
            {
                return "Just give Henry a surface wash when it nees a quick clean";
            }
        }

        /// <summary>
        /// Rainbow Stacker class that inherits from Toy class
        /// </summary>
        public class RainbowStacker : Toy
        {
            /// <summary>
            /// material used to make the rainbow stacker 
            /// </summary>
            public string Material { get; set; }

            /// <summary>
            /// number rainbow stacker sets included 
            /// </summary>
            public int NumberOfSets { get; set; }

            /// <summary>
            /// number of layers in each rainbow stacker set 
            /// </summary>
            public int NumberOfLayersPerSet { get; set; }

            /// <summary>
            /// creates a new instance of a Rainbow Stacker 
            /// </summary>
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

            /// <summary>
            /// decribes the stacking game you can play with Rainbow Stacker 
            /// </summary>
            /// <returns></returns>
            public string StackingGame()
            {
                return "Stack each piece based on size to create the perfect rainbow";
            }

            /// <summary>
            /// descibes some other ways users can use their imagination to use the Rainbow Stackers 
            /// </summary>
            /// <returns></returns>
            public string Imagination()
            {
                return "Kids can let their imagination run free by using these pieces as brisges, tunnels, cradles and more";
            }
        }

        /// <summary>
        /// Creator class that creates each toy 
        /// </summary>
        public class Creator
        {
            /// <summary>
            /// creates a new toy based on user preference 
            /// </summary>
            /// <param name="type"></param>
            /// <returns></returns>
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
