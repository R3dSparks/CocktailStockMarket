using CocktailStockMarket.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocktailStockMarket.Presentation
{
    public partial class MainWindow : Form
    {
        CSTLogic cstl;

        public MainWindow()
        {
            InitializeComponent();            

            cstl = new CSTLogic();

            cstl.AddCocktail("Ohm", 4, 3, 15);
            cstl.AddCocktail("Cuba", 4, 3, 15);
            cstl.AddCocktail("Fruit", 4, 3, 15);
            cstl.AddCocktail("Volt", 4, 3, 15);
            cstl.AddCocktail("Colt", 4, 3, 15);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dgvCocktails.DataSource = cstl.Cocktails;
            dgvCocktails.Columns["MaxPrice"].Visible = false;
            dgvCocktails.Columns["MinPrice"].Visible = false;
            dgvCocktails.Columns["DefaultPrice"].Visible = false;

            DataGridViewButtonColumn dgvbc = new DataGridViewButtonColumn()
            {
                HeaderText = "Sell",
                Name = "Sell"
            };

            dgvCocktails.Columns.Add(dgvbc);

            dgvCocktails.Columns["Name"].DisplayIndex = 0;
            dgvCocktails.Columns["Price"].DisplayIndex = 1;
            dgvCocktails.Columns["AmountSold"].DisplayIndex = 2;
            dgvCocktails.Columns["Sell"].DisplayIndex = 3;

            dgvCocktails.Columns["Name"].HeaderText = "Cocktail";
            dgvCocktails.Columns["AmountSold"].HeaderText = "Amount sold";
        }

        private void btnUpdatePrices_Click(object sender, EventArgs e)
        {
            cstl.UpdatePrices();

            for(int i = 0; i < dgvCocktails.RowCount; i++)
            {
                dgvCocktails.UpdateCellValue(dgvCocktails.Columns["Price"].Index, i);
            }
        }

        private void dgvCocktails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvCocktails.Columns["Sell"].Index)
            {
                Cocktail ct = cstl.Cocktails[e.RowIndex];

                cstl.SellCocktail(ct);

                dgvCocktails.UpdateCellValue(dgvCocktails.Columns["AmountSold"].Index, e.RowIndex);
            }
        }
    }
}
