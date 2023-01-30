using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quartett_Projekt
{
    public partial class Quartett_Spielfeld : Form
    {
        //Player One
        private Label Player1;
        private ListBox CardP1;
        private ListBox CarddeckPl1;

        //Player Two
        private Label Player2;
        private ListBox CardP2;
        private ListBox CarddeckPl2;

        private Label[] PlayerName = new Label[2];
        private ListBox[] PlayerCard = new ListBox[2];
        private ListBox[] PlayerDeck = new ListBox[2];

        private ComboBox Comparer;

        public Quartett_Spielfeld()
        {
            InitializeComponent();

            PlayerName[0] = Player1;
            PlayerName[1] = Player2;

            PlayerCard[0] = CardP1;
            PlayerCard[1] = CardP2;

            PlayerDeck[0] = CarddeckPl1;
            PlayerDeck[1] = CarddeckPl2;
        }

        private void Quartett_Spielfeld_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Quartett_Spielfeld
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Quartett_Spielfeld";
            this.ResumeLayout(false);

        }
    }
}