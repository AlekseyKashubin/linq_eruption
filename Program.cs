// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");




// Execute Assignment Tasks here!
IEnumerable<Eruption> FirstChile = eruptions.Where(e => e.Location == "Chile").OrderBy(e => e.Year).Take(1);
PrintEach(FirstChile, "First Chile eruption.");


IEnumerable<Eruption> FirstHawaii = eruptions.Where(h => h.Location == "Hawaiian Is").Take(1);
List<Eruption> HawaiiEruption = FirstHawaii.ToList();
if (HawaiiEruption.Count == 0)
{
    Console.WriteLine("Hawaii Island eruption dosent exist");
}
else
{
    PrintEach(FirstHawaii, "First Hawaii eruption.");
}


IEnumerable<Eruption> FirstGreenland = eruptions.Where(g => g.Location == "Geenland").ToList();
List<Eruption> GreenlandEruption = FirstGreenland.ToList();
if (GreenlandEruption.Count == 0)
{
    Console.WriteLine("Greenland eruption dosent exist");
}
else
{
    PrintEach(FirstGreenland, "First Greenland eruption.");

}


IEnumerable<Eruption> FirstNewZelandAfter1900 = eruptions.Where(n => n.Location == "New Zealand").Where(n => n.Year >= 1900).ToList();
PrintEach(FirstNewZelandAfter1900, "First eruption that is after the year 1900 AND in 'New Zealand' ");


IEnumerable<Eruption> AllOver2000m = eruptions.Where(e => e.ElevationInMeters >= 2000).ToList();
PrintEach(AllOver2000m, "All eruptions where the volcano's elevation is over 2000m");


IEnumerable<Eruption> AllWithL = eruptions.Where(e => e.Volcano.StartsWith("L")).ToList();
List<Eruption> AllLs = AllWithL.ToList();
PrintEach(AllWithL, "All eruptions where the volcano starts with the letter 'L'");
Console.WriteLine($"The Amount of Volcanos starting with the letter'L' is: {AllLs.Count}");


int HighestEruption = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine($"Highest Eruption is:{HighestEruption}");



int HighestEruptionByName = eruptions.Max(e => e.ElevationInMeters);
var ByName = eruptions.FirstOrDefault(e => e.ElevationInMeters == HighestEruptionByName);
if(ByName != null)
{
    Console.WriteLine($"Volcano with the highest elevation is: {ByName.Volcano}");
}




IEnumerable<Eruption> AllByName = eruptions.OrderBy(e => e.Volcano).ToList();
PrintEach(AllByName, "All Volcanos alphabetically");


int ElevationSum = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine($"the total elevation of all colcanos is: {ElevationSum}");



bool AllIn2000 = eruptions.Any(y => y.Year == 2000);
bool EruptionsIn2000 = AllIn2000;
if (EruptionsIn2000 == false)
{
    Console.WriteLine("There are no Volcanos that Erupted in the year 2000");
}
else
{
    Console.WriteLine($"All Volcanos that Erupted in the year 2000 {AllIn2000}");
}



IEnumerable<Eruption> First3stratovolcanos = eruptions.Where(c => c.Type == "Stratovolcano").Take(3);
PrintEach(First3stratovolcanos, "First 3 Stratovolcano eruptions.");



IEnumerable<Eruption> Before1000 = eruptions.Where(c => c.Year <= 1000).OrderBy(c => c.Volcano);
PrintEach(Before1000, "Volcanos Before the year 1000CE alphabetically by name.");


IEnumerable<Eruption> Before1000Names = eruptions.Where(c => c.Year <= 1000).OrderBy(c => c.Volcano);
foreach (var e in Before1000)
{
    Console.WriteLine(e.Volcano);
}





// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}


