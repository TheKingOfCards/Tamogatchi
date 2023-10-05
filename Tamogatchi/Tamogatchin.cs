namespace TamogatchiLogic
{

    public class Tamogatchi
    {
        public string name = "";
        List<String> words = new();
        public int hunger = 0;
        public int boredom = 0;


        //The Action of the player
        public void Action(string action)
        {
            action = action.ToLower();
            action = action.Replace(" ", "");


            if(action == "feed")
            {
                Console.WriteLine();
                hunger -= 3;
            }else if(action == "teach")
            {

            }else if(action == "hi")
            {

            }else
            {
                Console.WriteLine("You did nothing"); 
                if(GetAlive() == false)
                {

                }
            }

            Tick();
            PrintStats();
        }


        //Prints out the stats of the tamogatchi
        public void PrintStats()
        {
            Console.Clear();
            Console.WriteLine($"Hunger: {hunger}");
            Console.WriteLine($"Boredom: {boredom}");
        }


        //Takes the tamogatchi closer to death
        public void Tick()
        {
            hunger++;
            boredom++;
        }


        public void NewWord(string nW)
        {

        }


        //Checks if the tamogatchi is alive
        public bool GetAlive()
        {
            if(hunger == 10 || boredom == 10)
            {
                return false;
            }else
            {
                return true;
            }
        }


        public void Dead()
        {

        }
    }
}