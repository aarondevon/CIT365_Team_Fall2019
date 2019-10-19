using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_Sawyer
{
    public partial class ViewAllQuotes : Form
    {
        private DeskQuote deskQuote;
        private MainMenu mainMenu;

        public ViewAllQuotes()

        {
            InitializeComponent();
        }

        public ViewAllQuotes(DeskQuote deskQuote, MainMenu mainMenu)

        {
            InitializeComponent();
            this.deskQuote = deskQuote;
            this.mainMenu = mainMenu;
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"quotes.json");
            string text = File.ReadAllText(@"rushOrderPrices.txt");
            labelQuotes.Text = json;
            labelRushValue.Text = text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;

            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
