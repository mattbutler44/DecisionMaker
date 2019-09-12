using System;

namespace MyApplication
{

    class DecisionMaker
    {
        private int numChoices, chosenNumber;
        private String[] options;
        private String decision;

        //get user input for how many choices they have
        public int GetNumChoices()
        {
            //prompt user
            Console.WriteLine("How many choices do you have?");

            //ensure input is a number
            try
            {
                numChoices = int.Parse(Console.ReadLine());
            }
            //show error message and re-prompt for input
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
                GetNumChoices();
            }
            return numChoices;
        }

        //get the options the user is considering
        public void GetOptions()
        {
            options = new String[numChoices];

            for (int i = 0; i < numChoices; i++)
            {
                Console.WriteLine("What is option number " + (i + 1) + "?");
                options[i] = Console.ReadLine();
            }
        }

        //choose a random option
        public void ChooseOption()
        {
            Random random = new Random();
            chosenNumber = random.Next(0, numChoices);
            decision = options[chosenNumber];
        }

        //display the chosen option
        public void DisplayWinner()
        {
            Console.WriteLine("You should choose: " + decision);
        }

        public void run()
        {
            GetNumChoices();
            GetOptions();
            ChooseOption();
            DisplayWinner();
        }

        //execute program
        public static void Main(string[] args)
        {
            DecisionMaker d = new DecisionMaker();
            d.run();
        }
    }
}
