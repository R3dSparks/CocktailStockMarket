using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailStockMarket.Business
{
    public class Cocktail
    {

        public string Name { get; set; }

        public double Price { get; set; }

        public double DefaultPrice { get; set; }

        public double MaxPrice { get; set; }

        public double MinPrice { get; set; }

        public int AmountSold { get; set; }


        public Cocktail(string _name, double _price, double _min, double _max)
        {
            Name = _name;
            Price = _price;
            DefaultPrice = _price;
            MinPrice = _min;
            MaxPrice = _max;
        }

    }
}
