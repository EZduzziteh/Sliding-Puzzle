using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    public partial class MainForm : Form
    {
        
        public int difficulty = 0; //0=easy, 1= medium, 2=hard
        int gridSize = 4; //base size for grid is 4x4
        public GameManager gameManager;
        public ScoreTracker tracker;
        public List<PuzzlePiece> sortedPieceList= new List<PuzzlePiece>();
        public List<Button> buttonList = new List<Button>();
        bool gridInitialized = false;
        public void StartGame()
        {

            //create game manager if it doesnt exist
            if (gameManager == null)
            {
                gameManager = new GameManager();
            }
            //create tracker if it doesnt exist
            if ( tracker == null)
            {
                tracker = new ScoreTracker();
            }

            gameManager.scoreTracker = tracker;

            //initialize grid and button values.
            int columns = gridSize + difficulty;
            int rows = gridSize + difficulty;
            int buttonCount = 0;
            int startingPieceIndex = 0;

            //create the grid and buttons

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
              
                    buttonCount++;

                    Button button = new Button();
                    button.ForeColor = Color.White;
                    button.Name = "button " + buttonCount;
                    button.Size = new Size(100, 100);
                    button.Location = new Point(i * 110, j * 110);
                    button.Click += Button_ClickedEvent;
                    this.Controls.Add(button);

                    buttonList.Add(button);

                    PuzzlePiece piece = new PuzzlePiece();
                    piece.Name = "piece " + buttonCount;
                    piece.buttonReference = button;
                    piece.gridPositionX = i;
                    piece.desiredGridPosX = j;
                    piece.gridPositionY = j;
                    piece.desiredGridPosY = i;
                    piece.position = button.Location;

                    gameManager.pieces.Add(piece);
                    sortedPieceList.Add(piece);
                 
                    
                    if (buttonCount == rows * columns)
                    {
                        startingPieceIndex = buttonCount - 1;
                        button.Text = "";
                    }
                    else
                    {
                        button.Text = (buttonCount).ToString();

                    }



                }
            }

            ShufflePieces();


            gameManager.firstPiece = gameManager.pieces[startingPieceIndex];

            gameManager.secondPiece = null;
            gameManager.DisplaySelectablePieces();

        }

        public void ResetGame()
        {
            sortedPieceList.Clear();
            btn_Start.Visible = true;
            cmb_Difficulty.Visible = true;
            lbl_instructions.Visible = true;
            text_instructions.Visible = true;
            lbl_difficulty.Visible = true;
            text_difficulty.Visible = true;
            gameManager.pieces.Clear();
            sortedPieceList.Clear();
            foreach (Button button in buttonList)
            {
                this.Controls.Remove(button);
            }

        }
        public MainForm()
        {
            InitializeComponent();

            cmb_Difficulty.Items.Add("Easy");
            cmb_Difficulty.Items.Add("Medium");
            cmb_Difficulty.Items.Add("Hard");

        }

        public void Button_ClickedEvent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string[] buttonSplit = button.Name.Split();
            foreach(PuzzlePiece piece in gameManager.pieces) //loop through all pieces
            {
                    
                string []piecesSplit = piece.Name.Split();

                if (buttonSplit[1] == piecesSplit[1])//if button index equals piece index
                {
                    if (gameManager.firstPiece==piece) //do nothing if you click on the blank piece
                    {
                       
                    }
                    else //otherwise set as second piece and swap //#TODO Add logic to make it so you can only select adjacent pieces
                    {
                        if (piece.canBeSelected)
                        {
                            gameManager.secondPiece = piece;
                            gameManager.SwapPieces();
                            CheckForWin();
                        }
                    }
                }
            }
                
                
            
        }

       public void CheckForWin()
        {
            bool hasWon = true;

            foreach(PuzzlePiece piece in gameManager.pieces) //loop through all pieces
            {
                Console.WriteLine(piece.Name+" is at: "+piece.gridPositionX+", "+piece.gridPositionY+". Desired: "+piece.desiredGridPosX+", "+piece.desiredGridPosY);
                if(piece.gridPositionX==piece.desiredGridPosX && piece.gridPositionY == piece.desiredGridPosY)
                {

                }
                else
                {

                    hasWon = false;
                    break;
                }
            }

           

            if (hasWon)
            {
                lbl_victory.Text = "Congratulations! you won! Total move count: "+gameManager.scoreTracker.GetMoveCount();
                gameManager.scoreTracker.SetHighScore(gameManager.scoreTracker.GetMoveCount());
            }
            else
            {
                lbl_victory.Text = "Victory not yet achieved!";
            }
        }
        public void ShufflePieces()
        {
            Random rand = new Random();
            foreach (PuzzlePiece piece in gameManager.pieces)
            {
               
                int randomNum = rand.Next(0, ((gridSize + difficulty) * (gridSize + difficulty))-1); //generate random number
                gameManager.firstPiece = piece;
                gameManager.secondPiece = gameManager.pieces[randomNum];
                gameManager.SwapPieces();
            }
            //This function will shuffle all of the puzzle panels
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            difficulty = cmb_Difficulty.SelectedIndex;
            btn_Start.Visible = false;
            cmb_Difficulty.Visible = false;
            lbl_instructions.Visible = false;
            text_instructions.Visible = false;
            lbl_difficulty.Visible = false;
            text_difficulty.Visible = false;
            StartGame();
        }
    }
    public class ScoreTracker
    {
        
        int moveCount = 0;
        private int highScore;
        
        public void IncreaseMoveCount()
        {
            moveCount++;
        }

        public int GetMoveCount()
        {
            return moveCount;
        }

        public void SetHighScore(int score)
        {
            highScore = score;
        }
    }
    public class PuzzlePiece
    {
        public string Name;
        public int gridPositionX;
        public int gridPositionY;
        public int desiredGridPosX;
        public int desiredGridPosY;
        public Point position;
        public bool canBeSelected = false;

        public Button buttonReference;
        public void SwapPiece(PuzzlePiece otherPiece)
        {
            //store this objects position temporarily
            Point temp = position;
            int gridXTemp = gridPositionX;
            int gridYTemp = gridPositionY;
            
            //update this objects position to the other objects position
            this.position = otherPiece.buttonReference.Location;
            this.buttonReference.Location = otherPiece.buttonReference.Location;
            //update grid location
            this.gridPositionX = otherPiece.gridPositionX;
            this.gridPositionY = otherPiece.gridPositionY;
            //update the other objects position to this objects original position which is stored in temp.
            otherPiece.buttonReference.Location = temp;
            otherPiece.position = temp;
            //update grid location
            otherPiece.gridPositionX = gridXTemp;
            otherPiece.gridPositionY = gridYTemp;

            Console.WriteLine("Moved piece: " + this.Name + "  to " + this.gridPositionX+","+this.gridPositionY+", desired: "+this.desiredGridPosX+","+this.desiredGridPosY);
            Console.WriteLine("and piece: " + otherPiece.Name + "  to " + otherPiece.gridPositionX+"," + otherPiece.gridPositionY + ", desired: " + otherPiece.desiredGridPosX + "," + otherPiece.desiredGridPosY);
        }


    }
    public class GameManager
    {
        public List<PuzzlePiece> pieces = new List<PuzzlePiece>();
        public PuzzlePiece firstPiece;
        public PuzzlePiece secondPiece;
        public ScoreTracker scoreTracker;

        public void SwapPieces()
        {
            firstPiece.SwapPiece(secondPiece);
            secondPiece = null;
            
            DisplaySelectablePieces();
            scoreTracker.IncreaseMoveCount();

        }
        public void DisplaySelectablePieces()
        {
            foreach(PuzzlePiece piece in pieces)//first reset all pieces to not be selectable
            {
                piece.canBeSelected = false;
            }
            foreach (PuzzlePiece piece in pieces)
            {
                if (piece.gridPositionY == firstPiece.gridPositionY)
                { //if on the same y level
                    if (piece.gridPositionX == firstPiece.gridPositionX + 1 || piece.gridPositionX == firstPiece.gridPositionX - 1) //if + or - 1 x level
                    {
                        piece.canBeSelected = true;

                    }
                }
                else if (piece.gridPositionX == firstPiece.gridPositionX)//if same x level
                {
                    if (piece.gridPositionY == firstPiece.gridPositionY + 1 || piece.gridPositionY == firstPiece.gridPositionY - 1)// if + or - 1 on y level
                    {
                        piece.canBeSelected = true;
                    }

                }
                

                if (piece.canBeSelected)
                {
                    piece.buttonReference.BackColor = Color.LightGreen;
                }
                else
                {
                    piece.buttonReference.BackColor = Color.DarkGreen;

                }
            }
        }


    }
}
