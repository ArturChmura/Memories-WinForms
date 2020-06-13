using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WnFormsMemory
{
    public partial class StatusBar : Form
    {
       public  Form1 form1;
        public StatusBar(Form1 form1 = null)
        {
            this.form1 = form1;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
        private void newGameButton_Click(object sender, EventArgs e)
        {
            form1.newGame();
            form1.Activate();
        }

        private void buttonCardManager_Click(object sender, EventArgs e)
        {

            if(form1.cardManager == null || form1.cardManager.IsDisposed)
            {
                form1.cardManager = new CardManager(form1);
            }
            
        }
        public void setProgresBarTime(int value)
        {
            progressBarTimeLeft.Value = value;
        }
        public void setProgresBarCardRevealed(int value)
        {
            progressBarCardRevealed.Value = value;
        }
        public void setLabelTimeLeft(int value)
        {
            timeLeftNumberLabel.Text = value.ToString();
        }

        private void StatusBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Close();
        }
    }
}
