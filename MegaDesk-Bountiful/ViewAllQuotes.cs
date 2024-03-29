﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MegaDesk_Team
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private List<DeskQuote> convertJsonToList()
        {
            // convert JSON file to a string
            var path = Application.StartupPath + @"\quotes.json";
            string deskQuoteJSON = File.ReadAllText(path);
            // Deserialize JSON to List
            return JsonConvert.DeserializeObject<List<DeskQuote>>(deskQuoteJSON);
        }


        private void displaySearchResults()
        {
            List<DeskQuote> quotes = convertJsonToList();
            dataGridView1.DataSource = quotes.Select(deskQuote => new
            {
                Customer = $"{deskQuote.FirstName} {deskQuote.LastName}",
                Date = $"{deskQuote.Date}",
                Width = $"{deskQuote.Width}",
                Depth = $"{deskQuote.Depth}",
                Drawers = $"{deskQuote.Drawers}",
                Material = $"{deskQuote.Material}",
                Total = $"{deskQuote.Total}"
            }).ToList();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            displaySearchResults();
        }
    }
}
