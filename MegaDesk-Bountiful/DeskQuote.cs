﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Sawyer
{
    public class DeskQuote
    {
        private Desk desk = new Desk();
        private string _quoteDate;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Date
        { 
            get 
            { 
                return _quoteDate;
            }

            set 
            {
                _quoteDate = value;
            }
        }

        public int Drawers
        {
            get { return desk.Drawers;}
            set { desk.Drawers = value; }
        }

        public int BaseDeskPrice { get; set; } = 200;
        public int DeskSurfaceAreaPrice { get; set; }
        public int DrawerPrice { get; set; }
        public int MaterialPrice { get; set; }

        public string Material
        {
            get
            { return desk.Material; }
            set { desk.Material = value; }
        }
        public string RushDays;
        public int Total { get; set; }
       
        public string GenerateDate ()
        {
            return DateTime.Now.ToString("MM.dd.yyy");
        }

        public int DeskSurfaceArea()
        { 
            return desk.Width * desk.Depth;
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
            return desk.Drawers * 50;
        }

        public int PriceMaterial()
        {
            switch (desk.Material)
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
                    return 80;
                }
                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    return 70;
                }
                else
                {
                    return 60;
                }
            }

            if (RushDays == "5")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    return 60;
                }
                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    return 50;
                }
                else
                {
                    return 40;
                }
            }

            if (RushDays == "7")
            {
                if (DeskSurfaceArea() > 2000)
                {
                    return 40;
                }
                else if (DeskSurfaceArea() >= 1000 && DeskSurfaceArea() <= 2000)
                {
                    return 35;
                }
                else
                {
                    return 30;
                }
            }
            return 0;
        }

        public int GetTotal()
        {
            return BaseDeskPrice + PriceDeskSurfaceArea() + PriceDrawers() + PriceMaterial() + PriceRush();
        }

        public Desk GetDesk()
        {
            return desk;
        }

    }
}