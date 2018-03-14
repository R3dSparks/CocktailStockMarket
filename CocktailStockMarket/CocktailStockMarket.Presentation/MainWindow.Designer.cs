namespace CocktailStockMarket.Presentation
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCocktails = new System.Windows.Forms.DataGridView();
            this.btnUpdatePrices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCocktails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCocktails
            // 
            this.dgvCocktails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCocktails.Location = new System.Drawing.Point(38, 35);
            this.dgvCocktails.Name = "dgvCocktails";
            this.dgvCocktails.Size = new System.Drawing.Size(457, 191);
            this.dgvCocktails.TabIndex = 0;
            this.dgvCocktails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCocktails_CellContentClick);
            // 
            // btnUpdatePrices
            // 
            this.btnUpdatePrices.Location = new System.Drawing.Point(512, 202);
            this.btnUpdatePrices.Name = "btnUpdatePrices";
            this.btnUpdatePrices.Size = new System.Drawing.Size(114, 23);
            this.btnUpdatePrices.TabIndex = 1;
            this.btnUpdatePrices.Text = "Update prices";
            this.btnUpdatePrices.UseVisualStyleBackColor = true;
            this.btnUpdatePrices.Click += new System.EventHandler(this.btnUpdatePrices_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 292);
            this.Controls.Add(this.btnUpdatePrices);
            this.Controls.Add(this.dgvCocktails);
            this.Name = "MainWindow";
            this.Text = "Cocktail stock market";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCocktails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCocktails;
        private System.Windows.Forms.Button btnUpdatePrices;
    }
}

