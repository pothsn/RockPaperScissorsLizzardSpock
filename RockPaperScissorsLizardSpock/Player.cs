using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    abstract public class Player
    {
        //member variables (HAS A)
        public string name;
        public int score;
        public string gesture;
        public List<string> gestures;
               

        //constructor (SPAWNER) //constructor (SPAWNER)
        public Player()
        {
            gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizzard");
            gestures.Add("spock");
        }


        //member methods (CAN DO)
        abstract public void ChooseGesture();
        
        
      
    }
}
