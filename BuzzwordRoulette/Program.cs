// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

internal class Program {
    private static void Main() {
        Console.WriteLine("Welcome to Buzzword Roulette!");
        Console.WriteLine("Press any key to generate a random appliance coupled with a random tech buzzword.");

        while (true) {
            var key = Console.ReadKey(intercept: true);
            if (key.Key == ConsoleKey.Escape) break;
            Console.WriteLine($"Make a {GetRandomAppliance()} with integrated {GetRandomBuzzword()}!");
        }

        object GetRandomBuzzword() {
            List<string> homeAppliances = [
                "Artificial Intelligence (AI)",
                "Machine Learning (ML)",
                "Blockchain",
                "Internet of Things (IoT)",
                "Quantum Computing",
                "Cloud Computing",
                "Big Data",
                "Augmented Reality (AR)",
                "Virtual Reality (VR)",
                "5G",
                "Cybersecurity",
                "DevOps",
                "Edge Computing",
                "Microservices",
                "Digital Twin",
                "Natural Language Processing (NLP)",
                "Low-Code Development",
                "Autonomous Systems",
                "Robotic Process Automation (RPA)",
                "Serverless Computing"
            ];

            return homeAppliances[new Random().Next(homeAppliances.Count)];
        }

        object GetRandomAppliance() {
            List<string> homeAppliances = [
                "Refrigerator",
                "Microwave Oven",
                "Dishwasher",
                "Washing Machine",
                "Dryer",
                "Air Conditioner",
                "Heater",
                "Vacuum Cleaner",
                "Coffee Maker",
                "Toaster",
                "Blender",
                "Iron",
                "Television",
                "Electric Kettle",
                "Water Purifier",
                "Ceiling Fan",
                "Humidifier",
                "Dehumidifier",
                "Electric Stove",
                "Rice Cooker"
            ];

            return homeAppliances[new Random().Next(homeAppliances.Count)];
        }
    }
}