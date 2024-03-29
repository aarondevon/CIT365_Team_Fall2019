﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using System.IO;

namespace MegaDesk_Team
{
    public partial class AddQuote : Form
    {
        // Create deskQuote object
        public DeskQuote deskQuote = new DeskQuote();

        public AddQuote()
        {
            InitializeComponent();
        }
        // https://stackoverflow.com/questions/35935961/bind-combobox-with-enum-description
        public static void LoadDeskMaterialCombo(ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(DeskMaterial))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cbo.DisplayMember = "Description";
            cbo.ValueMember = "value";
        }

        public static void LoadRushCombo(ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(RushDays))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cbo.DisplayMember = "Description";
            cbo.ValueMember = "value";
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            LoadDeskMaterialCombo(DeskMaterial);
            LoadRushCombo(Rush);
            deskQuote.GetRushOrder();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }
        private void CreateQuote_Click(object sender, EventArgs e)
        {
            try
            {
                int width = Convert.ToInt32(textBoxWidth.Text);
                int depth = Convert.ToInt32(textBoxDepth.Text);
                int drawers = Convert.ToInt32((textBoxDrawers.Text));
                if (validWidth(width) && validDepth(depth) && validDrawers(drawers) && validMaterial())
                {
                    DisplayQuote displayQuote = new DisplayQuote(deskQuote, (MainMenu)Tag);

                    deskQuote.FirstName = textBoxFirstName.Text;
                    deskQuote.LastName = textBoxLastName.Text;
                    deskQuote.Date = deskQuote.GenerateDate();
                    deskQuote.Width = width;
                    deskQuote.Depth = depth;
                    deskQuote.Drawers = drawers;
                    deskQuote.Material = DeskMaterial.Text;
                    deskQuote.MaterialPrice = deskQuote.PriceMaterial();
                    deskQuote.DeskSurfaceAreaPrice = deskQuote.PriceDeskSurfaceArea();
                    deskQuote.DrawerPrice = deskQuote.PriceDrawers();
                    deskQuote.RushDays = Rush.Text;
                    deskQuote.Total = deskQuote.CalculateTotal();

                    // convert JSON file to a string
                    var path = Application.StartupPath + @"\quotes.json";
                    string deskQuoteJSON = File.ReadAllText(path);

                    // Deserialize JSON to List
                    List<DeskQuote> deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(deskQuoteJSON);

                    // Add current quote to quote list
                    deskQuoteList.Add(deskQuote);

                    // Serialze List to JSON format
                    string convertedJson = JsonConvert.SerializeObject(deskQuoteList, Formatting.Indented);

                    // Write updated quote to JSON file
                    File.WriteAllText(path, convertedJson);

                    displayQuote.Show();
                    this.Close();
                }
                else
                {
                    if (!validWidth(width))
                    {
                        labelWidth.Text = "Range 24-96:";
                        labelWidth.ForeColor = Color.DarkRed;
                    }
                    if (!validDepth(depth))
                    {
                        labelDepth.Text = "Range 12-48:";
                        labelDepth.ForeColor = Color.DarkRed;
                    }
                    if (!validDrawers(drawers))
                    {
                        labelDrawers.Text = "Range 0-7:";
                        labelDrawers.ForeColor = Color.DarkRed;
                    }
                    if (!validMaterial())
                    {
                        labelMaterial.Text = "Material:";
                        labelMaterial.ForeColor = Color.DarkRed;
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private bool validWidth(int width)
        {
            if (width >= deskQuote.GetDesk().GetMinWidth() && width <= deskQuote.GetDesk().GetMaxWidth())
            {
                return true;
            }

            return false;
        }

        private bool validDepth(int depth)
        {
            if (depth >= deskQuote.GetDesk().GetMinDepth() && depth <= deskQuote.GetDesk().GetMaxDepth())
            {
                return true;
            }

            return false;
        }

        private bool validDrawers(int drawers)
        {
            if (drawers >= deskQuote.GetDesk().GetMinDrawers() && drawers <= deskQuote.GetDesk().GetMaxDrawers())
            {
                return true;
            }

            return false;
        }

        private bool validMaterial()
        {
            if (DeskMaterial.Text != "Material")
            {
                return true;
            }

            return false;
        }


        private void textBoxWidth_KeyUp(object sender, KeyEventArgs e)
        {
            int width; 
            
            if (Int32.TryParse(textBoxWidth.Text, out width))
            {
                if (validWidth(width))
                {
                    labelWidth.Text = "Width:";
                    labelWidth.ForeColor = Color.Black;
                }
                else
                {
                    labelWidth.Text = "Range 24-96:";
                    labelWidth.ForeColor = Color.DarkRed;
                }
            }
        }

        private void textBoxDepth_KeyUp(object sender, KeyEventArgs e)
        {
            int depth;

            if (Int32.TryParse(textBoxDepth.Text, out depth))
            {
                if (validDepth(depth))
                {
                    labelDepth.Text = "Depth:";
                    labelDepth.ForeColor = Color.Black;
                }
                else
                {
                    labelDepth.Text = "Range 12-48:";
                    labelDepth.ForeColor = Color.DarkRed;
                }
            }

        }

        private void textBoxDrawers_KeyUp(object sender, KeyEventArgs e)
        {
            int drawers;

            if (Int32.TryParse(textBoxDrawers.Text, out drawers))
            {
                if (validDrawers(drawers))
                {
                    labelDrawers.Text = "Drawers:";
                    labelDrawers.ForeColor = Color.Black;
                }
                else
                {
                    labelDrawers.Text = "Range 0-7:";
                    labelDrawers.ForeColor = Color.DarkRed;
                }
            }

        }
    }

    public enum DeskMaterial
    {
        [Description("Desk Material")]
        Material = -1,
        [Description("Oak")]
        Oak = 0,
        [Description("Laminate")]
        Laminate = 1,
        [Description("Pine")]
        Pine = 2,
        [Description("Rosewood")]
        Rosewood = 3,
        [Description("Veneer")]
        Veneer = 4
    }

    public enum RushDays
    {
        [Description("No Rush")]
        Declined = -1,
        [Description("3")]
        Three = 0,
        [Description("5")]
        Five = 1,
        [Description("7")]
        Seven = 2,
    }
}
