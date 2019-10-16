using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Sawyer
{
    public class DeskQuote
    {
        private Desk desk = new Desk();

        // Quote data
        private int[,] rushOrderPricing = new int[3, 3];
        private string _quoteDate;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Date
        {
            get { return _quoteDate; }
            set { _quoteDate = value; }
        }

        public int BaseDeskPrice { get; set; } = 200;
        public int DeskSurfaceAreaPrice { get; set; }
        public int DrawerPrice { get; set; }
        public int MaterialPrice { get; set; }
        public string RushDays;
        public int Total { get; set; }

        // Desk data
        public int Width
        {
            get { return desk.Width;}
            set { desk.Width = value; }
        }

        public int Depth
        {
            get { return desk.Depth;}
            set { desk.Depth = value; }
        }

        public int Drawers
        {
            get { return desk.Drawers;}
            set { desk.Drawers = value; }
        }
        public string Material
        {
            get
            { return desk.Material; }
            set { desk.Material = value; }
        }

       

        public Desk GetDesk()
        {
            return desk;
        }
        public string GenerateDate ()
        {
            return DateTime.Now.ToString("MM.dd.yyy");
        }

        public int DeskSurfaceArea()
        { 
            return Width * Depth;
        }

        public int PriceDeskSurfaceArea()
        {
            int deskSurfaceArea = DeskSurfaceArea();

            if (deskSurfaceArea > 1000)
            {
                return deskSurfaceArea * 1;
            }
            
            return 0;
        }

        public int PriceDrawers()
        {
            return Drawers * 50;
        }

        public int PriceMaterial()
        {
            switch (Material)
            {
                case "Oak":
                    return 200;
                case "Laminate":
                    return 100;
                case "Pine":
                    return 50;
                case "Rosewood":
                    return 300;
                default :
                    return 125;

            }
        }

        public int PriceRush()
        {
            if (RushDays == "3")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    return rushOrderPricing[0,2];
                }
                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    return rushOrderPricing[0, 1];
                }
                else
                {
                    return rushOrderPricing[0, 0];
                }
            }

            if (RushDays == "5")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    return rushOrderPricing[1, 2];
                }
                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    return rushOrderPricing[1, 1];
                }
                else
                {
                    return rushOrderPricing[1, 0];
                }
            }

            if (RushDays == "7")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    return rushOrderPricing[2, 2];
                }
                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    return rushOrderPricing[2, 1];
                }
                else
                {
                    return rushOrderPricing[2, 0];
                }
            }
            return 0;
        }

        public int CalculateTotal()
        {
            return BaseDeskPrice + PriceDeskSurfaceArea() + PriceDrawers() + PriceMaterial() + PriceRush();
        }

        public void GetRushOrder()
        {
            try
            {
                string[] textRushPrices = File.ReadAllLines(@"rushOrderPrices.txt");
                int textRushPricesIndex = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        rushOrderPricing[i, j] = Int32.Parse(textRushPrices[textRushPricesIndex]);
                        textRushPricesIndex++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}