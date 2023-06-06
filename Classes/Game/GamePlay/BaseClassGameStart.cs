using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut.Classes.Game.GamePlay
{
    internal abstract class BaseClassGameStart
    {
        #region Initializations
#pragma warning disable CS0649 // Field 'BaseClassGameStart.Mechanics' is never assigned to, and will always have its default value null
        public GameMechanics Mechanics;
#pragma warning restore CS0649 // Field 'BaseClassGameStart.Mechanics' is never assigned to, and will always have its default value null
#pragma warning disable CS0649 // Field 'BaseClassGameStart.Admin' is never assigned to, and will always have its default value null
        public A_Admin Admin;
#pragma warning restore CS0649 // Field 'BaseClassGameStart.Admin' is never assigned to, and will always have its default value null
        public int TotalNumOfKeysToCollect;
        public int CollectedKeys;
#pragma warning disable CS0649 // Field 'BaseClassGameStart.game_Form' is never assigned to, and will always have its default value null
        public Form game_Form;
#pragma warning restore CS0649 // Field 'BaseClassGameStart.game_Form' is never assigned to, and will always have its default value null
        public string GameStatus;
        public int Score;
#pragma warning disable CS0649 // Field 'BaseClassGameStart.TimeFinished' is never assigned to, and will always have its default value 0
        public int TimeFinished;
#pragma warning restore CS0649 // Field 'BaseClassGameStart.TimeFinished' is never assigned to, and will always have its default value 0
        public int TimeToFinish;
        public int StartingScore;
        public int LightsOutTimer;
        #endregion
        public BaseClassGameStart() 
        {
            // Initial score for all game modes
            StartingScore = 20000;
        }
        #region Abstract Methods
        public abstract void StartGame();
        public abstract void CalculateScoreCompleted();
        public abstract void ChooseToExitGameUnfinished();
        public abstract bool HasCollectedAllKeys();
        public abstract bool LightsOutEvent();
        public abstract void ResetLightsOutEventTimer();
        public abstract string ReturnGameType();
        #endregion
    }
}
