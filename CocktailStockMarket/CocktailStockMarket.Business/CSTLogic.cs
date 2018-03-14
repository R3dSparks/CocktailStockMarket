using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailStockMarket.Business
{
    public class CSTLogic
    {

        public double Sharpness = 4;
        public double Width = 20;

        private BindingList<Cocktail> m_Cocktails;


        public BindingList<Cocktail> Cocktails
        {
            get
            {
                if (m_Cocktails == null)
                    m_Cocktails = new BindingList<Cocktail>();
                return m_Cocktails;
            }
            private set { }
        }


        public CSTLogic()
        {

        }


        /// <summary>
        /// Add a new Cocktail
        /// </summary>
        /// <param name="name">Name of the cocktail</param>
        /// <param name="price">Price of the cocktail</param>
        /// <param name="min">Minimum price of the cocktail</param>
        /// <param name="max">Maximum price of the cocktail</param>
        public void AddCocktail(string name, double price, double min, double max)
        {
            AddCocktail(new Cocktail(name, price, min, max));
        }

        /// <summary>
        /// Add a new Cocktail
        /// </summary>
        /// <param name="ct">The cocktail to be added</param>
        public void AddCocktail(Cocktail ct)
        {
            if(!Cocktails.Contains(ct))
                Cocktails.Add(ct);
        }

        /// <summary>
        /// Call if a cocktail is sold
        /// </summary>
        /// <param name="ct">The cocktail that was sold</param>
        public void SellCocktail(Cocktail ct)
        {
            ct.AmountSold++; 
        }

        /// <summary>
        /// Update prices for all cocktails
        /// </summary>
        public void UpdatePrices()
        {
            double totalSales = Cocktails.Sum(x => x.AmountSold);

            if (totalSales == 0)
                return;

            foreach(Cocktail ct in Cocktails)
            {

                if (ct.AmountSold == 0)
                    continue;

                double percentageOfSales = (ct.AmountSold / totalSales) * Cocktails.Count;

                double percentageConversion = Width * Math.Pow((percentageOfSales - 1), 3);

                double shift = -inverseSigmoid(ct.DefaultPrice, ct.MinPrice, ct.MaxPrice);

                ct.Price = sigmoid(percentageConversion, shift, ct.MinPrice, ct.MaxPrice);
            }

        }

        private double sigmoid(double x, double shift, double min, double max)
        {
            return (1 / (1 + Math.Pow(Sharpness, shift - x))) * (max - min) + min;
        }

        private double inverseSigmoid(double x, double min, double max)
        {
            return -(Math.Log(((max - min) / (x - min)) - 1, Sharpness));
        }

    }
}
