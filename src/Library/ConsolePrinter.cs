using System; 
namespace Full_GRASP_And_SOLID.Library;
public class ConsolePrinter
{
    public void PrintBuilding(Building building)
    {
        Console.WriteLine(building.StringBuilding());
    }

} 