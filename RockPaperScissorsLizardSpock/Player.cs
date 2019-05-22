using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        //member variables (HAS A)
        List<string> gestures;
        public string rock;
        public string paper;
        public string scissors;
        public string lizzard;
        public string spock;
        public string pickedGesture;
        public string winCounter;



        //constructor (SPAWNER) //constructor (SPAWNER)
        public Gestures()
        {
            gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizzard");
            gestures.Add("spock");
        }


        //member methods (CAN DO)
        public void SelectGesture()
        {

        }
        
      
    }
}
