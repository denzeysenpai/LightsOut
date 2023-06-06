using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOut.Classes.Game.GamePlay
{
    internal class MediumDifficulty : BaseClassGameStart
    {
        public MediumDifficulty()
        {
            TotalNumOfKeysToCollect = 3;
            Score = 0;
            TimeToFinish = 240; // 4 minutes
            LightsOutTimer = 20;
        }


        // Start Game Method
        public override void StartGame()
        {
            Score = 0;
            TimeToFinish = 240; // 5 minutes 
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
            LightsOutTimer = 30;
        }

        public override string ReturnGameType() => "MEDIUM";
    }
}
