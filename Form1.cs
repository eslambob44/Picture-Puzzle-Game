using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyRandom;
using MyString;
namespace Picture_Puzzle_Game
{
    public partial class Form1 : Form
    {

        List<int> _lImagesIndexes;

        clsGameInfo _GameInfo=new clsGameInfo();

        class clsGameInfo
        {
            public bool IsGameStarted { get; set; }
            public bool IsGameFinished { get; set; }
            public int NumberOfTries { get; set; }
            public TimeSpan GameTime { get; set; }
            public enDifficultyLvl DifficultyLvl { get; set; }

            public enum enDifficultyLvl { Easy=0 , Medium=1,Hard=2 };

            public clsGameInfo()
            {
                GameTime = TimeSpan.Zero;
                IsGameStarted = false;
                IsGameFinished = false;
                NumberOfTries = 0;
                DifficultyLvl = enDifficultyLvl.Easy;
            }
        }

        

        Button btnGray = null;
        public Form1()
        {
            InitializeComponent();
            _lImagesIndexes = FillLImagesIndexes();
            ShuffleImages();
        }

        

        List<int> FillLImagesIndexes()
        {
            List<int> lImagesIndexes = new List<int>();
            for(int i = 0; i<=8;i++)
            {
                lImagesIndexes.Add(i);
            }
            return lImagesIndexes;
        }

        int GetRandomPictureIndex()
        {
            int Index = clsRandom.GetRandomNumber(0, _lImagesIndexes.Count-1);
            int RandomPictureIndex = _lImagesIndexes[Index];
            _lImagesIndexes.RemoveAt(Index);
            return RandomPictureIndex;
        }

        void ShuffleImages()
        {
            foreach(Control c in tableLayoutPanel1.Controls)
            {
                if(c is Button)
                {
                    Button btn = (Button)c;
                    btn.ImageIndex = GetRandomPictureIndex();
                }
            }
            _lImagesIndexes = FillLImagesIndexes();
        }

        int getCorrectButtonImageIndex(Button btn)
        {
            return Convert.ToInt32(btn.Tag);
        }

        bool IsCorrectImage(Button btn)
        {
            return (getCorrectButtonImageIndex(btn)==btn.ImageIndex);
        }

        bool IsGameFinish()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    if(!IsCorrectImage(btn))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            ShuffleImages();
        }

        Button GetGrayButton()
        {
            foreach(Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    if (btn.ImageIndex==6)
                    {
                        return btn;
                    }
                }
            }
            return null;    
        }

        clsGameInfo.enDifficultyLvl GetDifficultyLvl()
        {
            if(rbEasy.Checked) return clsGameInfo.enDifficultyLvl.Easy;
            if (rbMedium.Checked) return clsGameInfo.enDifficultyLvl.Medium;
            return clsGameInfo.enDifficultyLvl.Hard;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(IsGameFinish())
            {
                MessageBox.Show("The picture is already right", "Game Ended");
                return;
            }
            btnStartGame.Enabled = false;
            btnSuffle.Enabled = false;
            _GameInfo.IsGameStarted = true;
            _GameInfo.DifficultyLvl = GetDifficultyLvl();
            gbDifficultyLvl.Enabled = false;
            btnReset.Enabled = true;
            GameTimer.Start();
            btnGray = GetGrayButton();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            _GameInfo.GameTime = _GameInfo.GameTime.Add(new TimeSpan(0, 0, 1));
            lblTimeTaken.Text = _GameInfo.GameTime.ToString();
        }
        
        void SwapImages(Button Button1 , Button Button2)
        {
            Button tempButton = new Button();
            tempButton.ImageIndex=Button1.ImageIndex;
            Button1.ImageIndex=Button2.ImageIndex;
            Button2.ImageIndex=tempButton.ImageIndex;

        }

        void ResetGame()
        {
            ShuffleImages();
            GameTimer.Stop();
            btnStartGame.Enabled = true;
            btnSuffle.Enabled = true;
            gbDifficultyLvl.Enabled=true;  
            btnReset.Enabled = false;
            _GameInfo=new clsGameInfo();
            lblNumberOfTries.Text = "0";
            lblTimeTaken.Text = "00:00:00";

        }

        void EndGame()
        {
            btn6.ImageIndex = 9;
            GameTimer.Stop();
            MessageBox.Show("congratulations");
            ResetGame();
        }

        List<int> GetPossibleMovesDifficultyHard()
        {
            List<int> lPossibleMoves = new List<int>();
            switch (Convert.ToInt32(btnGray.Tag))
            {
                case 0:
                    lPossibleMoves.Add(1);
                    lPossibleMoves.Add(3);
                    break;
                case 1:
                    lPossibleMoves.Add(0);
                    lPossibleMoves.Add(2);
                    lPossibleMoves.Add(4);
                    break;
                case 2:
                    lPossibleMoves.Add(1);
                    lPossibleMoves.Add(5);
                    break;
                case 3:
                    lPossibleMoves.Add(0);
                    lPossibleMoves.Add(4);
                    lPossibleMoves.Add(6);
                    break;
                case 4:
                    lPossibleMoves.Add(1);
                    lPossibleMoves.Add(3);
                    lPossibleMoves.Add(5);
                    lPossibleMoves.Add(7);
                    break;
                case 5:
                    lPossibleMoves.Add(2);
                    lPossibleMoves.Add(4);
                    lPossibleMoves.Add(8);
                    break;
                case 6:
                    lPossibleMoves.Add(3);
                    lPossibleMoves.Add(7);
                    break;
                case 7:
                    lPossibleMoves.Add(6);
                    lPossibleMoves.Add(8);
                    lPossibleMoves.Add(4);
                    break;
                case 8:
                    lPossibleMoves.Add(7);
                    lPossibleMoves.Add(5);
                    break;
            }
            return lPossibleMoves;
        }

        List<int> GetPossibleMovesDifficultyMedium()
        {
            List<int> lPossibleMoves = new List<int>();
            lPossibleMoves=GetPossibleMovesDifficultyHard();
            switch (Convert.ToInt32(btnGray.Tag))
            {
                case 0:
                    lPossibleMoves.Add(4);
                    break;
                case 1:
                    lPossibleMoves.Add(3);
                    lPossibleMoves.Add(5);
                    break;
                case 2:
                    lPossibleMoves.Add(4);
                    break;
                case 3:
                    lPossibleMoves.Add(1);
                    lPossibleMoves.Add(7);
                    break;
                case 4:
                    lPossibleMoves.Add(0);
                    lPossibleMoves.Add(2);
                    lPossibleMoves.Add(6);
                    lPossibleMoves.Add(8);
                    break;
                case 5:
                    lPossibleMoves.Add(1);
                    lPossibleMoves.Add(7);
                    break;
                case 6:
                    lPossibleMoves.Add(4);
                    break;
                case 7:
                    lPossibleMoves.Add(3);
                    lPossibleMoves.Add(5);
                    break;
                case 8:
                    lPossibleMoves.Add(4);
                    break;
            }
            return lPossibleMoves;
        }



        List<int> GetPossibleMoves()
        {
            if (_GameInfo.DifficultyLvl == clsGameInfo.enDifficultyLvl.Hard)
            {
                return GetPossibleMovesDifficultyHard();
            }
            else if (_GameInfo.DifficultyLvl == clsGameInfo.enDifficultyLvl.Medium)
            {
                return GetPossibleMovesDifficultyMedium();
            }
            else
            {
                return FillLImagesIndexes();
            }
        }

        bool IsNumberInList(int number , List<int>li)
        {
            foreach(int i in li) 
            
            {
                if(number == i) return true;
            }
            return false;
        }

        bool IsMoveRight(Button btn)
        {
            if(_GameInfo.DifficultyLvl==clsGameInfo.enDifficultyLvl.Easy) return true;

            List<int> lPossibleMoves = GetPossibleMoves();
            return (IsNumberInList(Convert.ToInt32(btn.Tag), lPossibleMoves));
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            if (!_GameInfo.IsGameStarted || _GameInfo.IsGameFinished) return;

            Button btn = (Button)sender;
            if (btn==btnGray) return;

            if(!IsMoveRight(btn)) return;


            SwapImages(btn, btnGray);
            btnGray = btn;
            _GameInfo.NumberOfTries++;
            lblNumberOfTries.Text= _GameInfo.NumberOfTries.ToString();

            if (IsGameFinish())
            {
                _GameInfo.IsGameFinished = true;
                EndGame();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
