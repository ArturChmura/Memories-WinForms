using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WnFormsMemory
{

    public partial class Form1 : Form
    {
        bool canClick = true;
        bool isGameOn = false;
        public int gameSize = 6;
        int roundTime;

        int[,] cardNumbers;
        Bitmap[] bitmaps;
        bool[,] opened;

        int noCardsRevealed;
        (int row, int col) currSelected = (-1, -1);
        Button[] selectedButtons = new Button[2];

        Timer oneSecTimer;
        Timer timeLeftTimer;
        int timeLeft;

        public StatusBar statusBar;
        public CardManager cardManager;



        public Form1()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(700, 0);

           
            loadStartImages();

            statusBar = new StatusBar(this);
            statusBar.Show();


            oneSecTimer = new Timer();
            timeLeftTimer = new Timer();
            timeLeftTimer.Tick += new EventHandler(oneSecPass);
            timeLeftTimer.Interval = 1000;
            createBoard();

        }
        private void loadStartImages()
        {
            DirectoryInfo directory = new DirectoryInfo("Resources");
            FileInfo[] fileInfo = directory.GetFiles();
            foreach (FileInfo item in fileInfo)
            {
                string path = item.FullName;
                string name = item.Name;
                ListViewItem listViewItem = new ListViewItem(name);
                listViewItem.SubItems.Add(path);
                Bitmap bitmap = (Bitmap)Bitmap.FromFile(path);
                imageList.Images.Add(path, bitmap);
                listViewItem.ImageIndex = imageList.Images.Count - 1;
                listViewItem.SubItems.Add(bitmap.Width.ToString() + "x" + bitmap.Height.ToString());
                listView.BeginUpdate();
                listView.Items.Add(listViewItem);
                listView.EndUpdate();
            }
        }
        public void newGame()
        {
            createBoard();
            timeLeft = roundTime;
            statusBar.setLabelTimeLeft(timeLeft);
            isGameOn = canClick = true;
            noCardsRevealed = 0;
            statusBar.setProgresBarTime(100);
            timeLeftTimer.Start();
        }
        void createBoard()
        {
            table.Controls.Clear();
            table.ColumnCount = table.RowCount = gameSize;
            table.ColumnStyles.Clear();
            table.RowStyles.Clear();
            for (int i = 0; i < gameSize; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / gameSize));
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / gameSize));
            }
            table.Location = new Point(10, 20);
            table.Size = new Size(100 * gameSize, 100 * gameSize);
            for (int i = 0; i < gameSize * gameSize; i++)
            {
                Button button = new Button();
                button.Text = "?";


                button.Name = "button" + (i + 1).ToString();
                button.Click += cardClicked;
                button.BackColor = SystemColors.Control;
                button.Size = new Size(100, 100);
                button.BackgroundImageLayout = ImageLayout.Stretch;
                table.Controls.Add(button);
            }

            this.Size = new Size(100 * gameSize + 40, 100 * gameSize + 80);
            roundTime = 3 * gameSize * gameSize;
            GenerateNumbers();
            selectedButtons[0] = selectedButtons[1] = null;
            currSelected = (-1, -1);
            selectedButtons[0] = selectedButtons[1] = null;

        }
        void GenerateNumbers()
        {
            Random rand = new Random();

            cardNumbers = new int[gameSize, gameSize];
            bitmaps = new Bitmap[gameSize * gameSize / 2];
            opened = new bool[gameSize, gameSize];
            bool[] isSet = new bool[gameSize * gameSize];
            int number;
            int imagesUsed = 0;
            for (int i = 0; i < gameSize * gameSize / 2; i++)
            {
                number = rand.Next(0, gameSize * gameSize - 2 * i - 1);
                (int row, int col) index = getFreeIndex(isSet, number);
                cardNumbers[index.row, index.col] = i + 1;
                number = rand.Next(0, gameSize * gameSize - 2 * i - 2);
                (int row, int col) index2 = getFreeIndex(isSet, number);
                cardNumbers[index2.row, index2.col] = i + 1;

                if (imagesUsed < imageList.Images.Count)
                {
                    bitmaps[imagesUsed] = (Bitmap)imageList.Images[imagesUsed];
                    imagesUsed++;
                }
            }
        }
        public (int, int) getFreeIndex(bool[] isSet, int number)
        {

            int i = -1;
            for (int j = 0; j <= number; j++)
            {
                i++;
                while (isSet[i]) ++i;
            }
            isSet[i] = true;
            return (i / gameSize, i % gameSize);
        }

        private void cardClicked(object sender, EventArgs e)
        {
            if (!isGameOn)
            {
                newGame();
            }
            if (!canClick)
            {
                CloseCards(oneSecTimer, null);
                return;
            }
            Button button = (Button)sender;
            (int row, int col) index = getIndexFromName(button.Name);
            button.BackgroundImage = bitmaps[cardNumbers[index.row, index.col] - 1];

            if (button.BackgroundImage == null)
                button.Text = cardNumbers[index.row, index.col].ToString();
            else button.Text = "";
            if (index == currSelected || opened[index.row, index.col]) return;
            button.BackColor = Color.LightYellow;
            if (currSelected.row == -1) //pierwszy zaznaczony 
            {
                currSelected = index;
                selectedButtons[0] = button;
            }
            else
            {

                if (cardNumbers[currSelected.row, currSelected.col] == cardNumbers[index.row, index.col]) //trafił
                {
                    noCardsRevealed++;
                    statusBar.setProgresBarCardRevealed(noCardsRevealed * 100 / (gameSize * gameSize / 2));
                    opened[currSelected.row, currSelected.col] = opened[index.row, index.col] = true;
                    button.BackColor = selectedButtons[0].BackColor = Color.Green;
                    if (noCardsRevealed == gameSize * gameSize / 2)
                    {
                        GameEnded("Wygrałeś!");
                    }
                }
                else //nie trafił
                {
                    selectedButtons[1] = button;
                    oneSecTimer.Interval = 1000;
                    oneSecTimer.Tick += new EventHandler(CloseCards);
                    canClick = false;
                    oneSecTimer.Start();
                }
                currSelected = (-1, -1);
            }
        }

        private void oneSecPass(Object myObject, EventArgs myEventArgs)
        {
            timeLeft--;
            statusBar.setProgresBarTime(timeLeft * 100 / roundTime);
            statusBar.setLabelTimeLeft(timeLeft);
            if (timeLeft <= 0)
            {
                GameEnded("Czas się skończył");
            }

        }

        private void CloseCards(Object myObject, EventArgs myEventArgs)
        {
            Timer oneSecTimer = (Timer)myObject;
            oneSecTimer.Stop();
            selectedButtons[0].Text = selectedButtons[1].Text = "?";
            selectedButtons[1].BackColor = selectedButtons[0].BackColor = SystemColors.Control;

            selectedButtons[1].BackgroundImage = selectedButtons[0].BackgroundImage = null;
            canClick = true;
        }
        void GameEnded(string Reason)
        {
            timeLeftTimer.Stop();
            oneSecTimer.Stop();
            isGameOn = false;
            canClick = false;
            MessageBox.Show(Reason);
        }

      
        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSize = 2;
            newGame();
        }
        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSize = 4;
            newGame();
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSize = 6;
            newGame();
        }

        private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSize = 8;
            newGame();
        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameSize = 10;
            newGame();
        }

        private void table_MouseClick(object sender, MouseEventArgs e)
        {
            if (!canClick && isGameOn)
            {
                CloseCards(oneSecTimer, null);
                return;
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!canClick && isGameOn)
            {
                CloseCards(oneSecTimer, null);
                return;
            }
        }
        (int, int) getIndexFromName(string name)
        {
            string nrStr = name.Substring(6);
            oneSecTimer.Interval = 1000;
            int nr = int.Parse(nrStr) - 1;
            return (nr / gameSize, nr % gameSize);
        }


    }
}
