using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.ChooseYourOwnAdventure_JoshuaZimmerman
{
    class Program
    {
        enum GameState { StartingPosition, ChoiceFortune500, ChoiceGovernmentContractor, ChoiceFriendStartup}

        struct PathChoice
        {
            public int choiceNumber;
            public string choiceText;
            public GameState stateToMoveTo;

            public PathChoice(int choiceNo, string text, GameState state)
            {
                choiceNumber = choiceNo;
                choiceText = text;
                stateToMoveTo = state;
            }

        }

        static void Main(string[] args)
        {
            GameState userGameState = GameState.StartingPosition;
            int userChoice = -1;

            PathChoice startOver = new PathChoice(0, "Start Over", GameState.StartingPosition);

            PathChoice fortune500Choice = new PathChoice(1, "(1) Get job with Fortune 500 company", GameState.ChoiceFortune500);
            PathChoice governmentContractorChoice = new PathChoice(2, "(2) Get job with government contractor", GameState.ChoiceGovernmentContractor);
            PathChoice friendStartupChoice = new PathChoice(3, "(3) Get job with your friend's startup company", GameState.ChoiceFriendStartup);



            Console.Write(  "***********************************************************\n" +
                            "*        Dev.Build(2.0) - Choose your own Adventure       *\n" +
                            "***********************************************************\n\n");

            //present adventure synopsis to user
            Console.WriteLine(  "Congratulations! You've graduated from a reputable coding bootcamp and you're off to start your first adventure " +
                                "as a\nprofessional developer. The offers are lining up, and it's time for you to choose where to apply. \nA Fortune 500 company with a sterling reputation has made a formal offer, as have a few government contractors. \nIf you're feeling especially adventurous, you can also see about a job with one of a few startup companies run by your fellow bootcamp alumnists.");

            Console.WriteLine("\n");
            //present user with five choices, record user's choice
            Console.WriteLine(fortune500Choice.choiceText);
            Console.WriteLine(governmentContractorChoice.choiceText);
            Console.WriteLine(friendStartupChoice.choiceText);

            userChoice = int.Parse(Console.ReadLine());
            //process user's choice, use switch statement
            switch (userChoice)
            {

            }


        }
    }
}
