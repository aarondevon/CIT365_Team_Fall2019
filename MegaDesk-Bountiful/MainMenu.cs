﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Team
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
           AddQuote viewAddQuoteForm = new  AddQuote();
           viewAddQuoteForm.Tag = this;
           viewAddQuoteForm.Show(this);
           this.Hide();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuoteForm = new ViewAllQuotes();
            viewAllQuoteForm.Tag = this;
            viewAllQuoteForm.Show(this);
            this.Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes SearchQuotesForm = new SearchQuotes();
            SearchQuotesForm.Tag = this;
            SearchQuotesForm.Show(this);
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
