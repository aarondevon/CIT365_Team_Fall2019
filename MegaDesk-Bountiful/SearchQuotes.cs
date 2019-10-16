using System;
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

namespace MegaDesk_Sawyer
{

    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            LoadDeskMaterialCombo(DeskMaterial);
        }

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


        // convert JSON file to a string
        string deskQuoteJSON = File.ReadAllText(@"quotes.json");

        private List<DeskQuote> convertJsonToList()
        {
            // Deserialize JSON to List
            return JsonConvert.DeserializeObject<List<DeskQuote>>(deskQuoteJSON);
        }

        private List<DeskQuote> searchResults()
        {
            List<DeskQuote> results = new List<DeskQuote>();

            foreach (var quote in convertJsonToList())
            {
                if (quote.Material == DeskMaterial.Text)
                {
                    results.Add(quote);
                }
            }

            return results;
        }

        private void displaySearchResults()
        {
            List<DeskQuote> results = searchResults();
            BindingList<DeskQuote> bindingList = new BindingList<DeskQuote>(results);
            BindingSource source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = results.Select(deskQuote => new 
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

        private void DeskMaterial_DropDownClosed(object sender, EventArgs e)
        {
            displaySearchResults();
        }
    }
}
