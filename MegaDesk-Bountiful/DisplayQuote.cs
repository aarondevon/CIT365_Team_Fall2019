using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Sawyer
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote;
        private MainMenu mainMenu;
        public DisplayQuote()
        {
            InitializeComponent();
        }

        public DisplayQuote(DeskQuote deskQuote, MainMenu mainMenu)
        {
            InitializeComponent();
            this.deskQuote = deskQuote;
            this.mainMenu = mainMenu;
        }



        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            //textBoxFirstName.Text = this.deskQuote.FirstName;
            labelCustomerValue.Text = $"{deskQuote.FirstName} {deskQuote.LastName}";
            labelDateValue.Text = $"{deskQuote.Date}";
            labelBasePriceValue.Text = $"${deskQuote.BaseDeskPrice}";
            labelAreaPriceValue.Text = $"${deskQuote.DeskSurfaceAreaPrice}";
            labelDrawersValue.Text = $"${deskQuote.DrawerPrice}";
            labelMaterialValue.Text = $"${deskQuote.MaterialPrice}";
            labelRushValue.Text = $"${deskQuote.PriceRush()}";
            labelTotalValue.Text = $"${deskQuote.Total}";
            

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            
            mainMenu.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
