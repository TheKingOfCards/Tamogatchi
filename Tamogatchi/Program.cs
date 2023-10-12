using System.Runtime.Intrinsics.Arm;
using TamogatchiLogic;

Tamogatchi tamo = new();

Console.WriteLine("Name your tamogatchi:");
tamo.name = Console.ReadLine();

while(tamo.GetAlive() == true)
{
    Console.WriteLine("\nActions: \"Feed\" - \"Teach\" - \"hi\"");

    tamo.Action(Console.ReadLine());
}


//Death scene
if(tamo.hunger == 10 && tamo.boredom == 10)
{
    Console.WriteLine("Your tamogatchi imploded into a black hole and destroyed the entire universe");
}else if(tamo.hunger == 10)
{
    Console.WriteLine("Your tamogatchi became so hungry it started eating itself and died of blood loss");
}else 
{
    Console.WriteLine("Your tamogatchi became so bored and fat it hung itself from the ceilingfan");
}

Console.ReadKey();