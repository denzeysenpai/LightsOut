using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut.Classes.Game.GamePlay
{
    internal class HardDifficulty : BaseClassGameStart
    {
        public HardDifficulty() : base ()
        {
            TotalNumOfKeysToCollect = 4;
            Score = 0;
            TimeToFinish = 300; // 5 minutes
            LightsOutTimer = 10;
            CollectedKeys = 0;
        }
        
        
        
        // Start Game Method
        public override void StartGame()
        {
            Score = 0;
            TimeToFinish = 180;
        }


        // Score Calculation if status is complete
        public override void CalculateScoreCompleted()
        {
            GameStatus = "completed";
            Score = (StartingScore - (TimeToFinish - TimeFinished)) + (TotalNumOfKeysToCollect * 100);
        }



        // Player chose to Exit
        public override void ChooseToExitGameUnfinished()
        {
            GameStatus = "unfinished";
            Score = (StartingScore - 1000 - (TimeToFinish * 10) - (TotalNumOfKeysToCollect * 100));
        }


        // check if all keys are collected
        public override bool HasCollectedAllKeys()
        {
            return TotalNumOfKeysToCollect == CollectedKeys;
        }


        // lights out event check
        public override bool LightsOutEvent()
        {
            return LightsOutTimer == 0;
        }



        public override void ResetLightsOutEventTimer()
        {
            LightsOutTimer = 10;
        }

        public override string ReturnGameType() => "HARD";
    }
}
