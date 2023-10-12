using System;

namespace TamogatchiLogic
{

    public class Tamogatchi
    {
        public string name = "";
        public List<String> words = new();
        public int hunger = 0;
        public int boredom = 0;
        bool hasFeed = false;
        bool hasPlayed = false;

        Random generator = new Random();

        public Tamogatchi()
        {
            words.Add("Hi");
        }

        //The Action of the player
        public void Action(string playerAction)
        {
            playerAction = playerAction.ToLower();
            playerAction = playerAction.Replace(" ", "");


            if(playerAction == "feed")
            {
                Console.WriteLine("You feed your tamogatchi, it seems happy");
                hunger -= 2;
                hasFeed = true;

                if(hunger < 0)
                {
                    hunger = 0;
                }
                Console.ReadKey();
            }else if(playerAction == "teach")
            {
                Console.WriteLine("What word do you want to teach");

                boredom -= 2;
                hasPlayed = true;

                if(boredom < 0)
                {
                    boredom = 0;
                }

                LearnNewWord(Console.ReadLine());
            }else if(playerAction == "hi")
            {
                int index = generator.Next(words.Count);
                Console.WriteLine(words[index]);
                Console.ReadKey();

                boredom -= 1;
                hasPlayed = true;

                if(boredom < 0)
                {
                    boredom = 0;
                }
            }else
            {
                Console.WriteLine("You did nothing"); 
                Console.ReadKey();
            }

            Tick();
        }


        //Prints out the stats of the tamogatchi
        public void PrintStats()
        {
            Console.Clear();
            Console.WriteLine($"{name} \nHunger: {hunger} Boredom: {boredom}");
        }


        //Takes the tamogatchi closer to death
        public void Tick()
        {
            if(hasFeed == false)
            {
                hunger++;
            }
            if(hasPlayed == false)
            {
                boredom++;
            }

            hasFeed = false;
            hasPlayed = false;    

            PrintStats();
        }


        //Teaches the tamogatchi a new word
        public void LearnNewWord(string nW)
        {
            nW.Replace(" ", "");
            words.Add(nW);
            Console.WriteLine($"Your tamogatchi learned the word \"{nW}\"");
            Console.ReadKey();
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
    }
}