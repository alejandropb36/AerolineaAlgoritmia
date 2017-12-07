namespace Airline
{
    partial class GraphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.panelMap = new System.Windows.Forms.Panel();
            this.labelCitySelect = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonKruskal = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelCostResult = new System.Windows.Forms.Label();
            this.buttonPrim = new System.Windows.Forms.Button();
            this.labelDijkstra = new System.Windows.Forms.Label();
            this.radioButtonTime = new System.Windows.Forms.RadioButton();
            this.radioButtonCost = new System.Windows.Forms.RadioButton();
            this.comboBoxOrigin = new System.Windows.Forms.ComboBox();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.buttonDijkstra = new System.Windows.Forms.Button();
            this.listViewDijkstra = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMap.BackgroundImage")));
            this.panelMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMap.Location = new System.Drawing.Point(12, 23);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1205, 738);
            this.panelMap.TabIndex = 0;
            this.panelMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMap_MouseClick);
            // 
            // labelCitySelect
            // 
            this.labelCitySelect.AutoSize = true;
            this.labelCitySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCitySelect.Location = new System.Drawing.Point(1256, 44);
            this.labelCitySelect.Name = "labelCitySelect";
            this.labelCitySelect.Size = new System.Drawing.Size(145, 18);
            this.labelCitySelect.TabIndex = 1;
            this.labelCitySelect.Text = "Ciudad seleccionada";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(1325, 83);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(0, 20);
            this.labelCity.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1294, 137);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonKruskal
            // 
            this.buttonKruskal.Location = new System.Drawing.Point(1294, 276);
            this.buttonKruskal.Name = "buttonKruskal";
            this.buttonKruskal.Size = new System.Drawing.Size(75, 23);
            this.buttonKruskal.TabIndex = 4;
            this.buttonKruskal.Text = "Kruskal";
            this.buttonKruskal.UseVisualStyleBackColor = true;
            this.buttonKruskal.Click += new System.EventHandler(this.buttonKruskal_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(1251, 253);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(37, 13);
            this.labelCost.TabIndex = 6;
            this.labelCost.Text = "Costo:";
            // 
            // labelCostResult
            // 
            this.labelCostResult.AutoSize = true;
            this.labelCostResult.Location = new System.Drawing.Point(1309, 253);
            this.labelCostResult.Name = "labelCostResult";
            this.labelCostResult.Size = new System.Drawing.Size(13, 13);
            this.labelCostResult.TabIndex = 7;
            this.labelCostResult.Text = "0";
            // 
            // buttonPrim
            // 
            this.buttonPrim.Location = new System.Drawing.Point(1294, 314);
            this.buttonPrim.Name = "buttonPrim";
            this.buttonPrim.Size = new System.Drawing.Size(75, 23);
            this.buttonPrim.TabIndex = 8;
            this.buttonPrim.Text = "Prim";
            this.buttonPrim.UseVisualStyleBackColor = true;
            this.buttonPrim.Click += new System.EventHandler(this.buttonPrim_Click);
            // 
            // labelDijkstra
            // 
            this.labelDijkstra.AutoSize = true;
            this.labelDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDijkstra.Location = new System.Drawing.Point(1291, 372);
            this.labelDijkstra.Name = "labelDijkstra";
            this.labelDijkstra.Size = new System.Drawing.Size(58, 18);
            this.labelDijkstra.TabIndex = 9;
            this.labelDijkstra.Text = "Dijkstra";
            // 
            // radioButtonTime
            // 
            this.radioButtonTime.AutoSize = true;
            this.radioButtonTime.Checked = true;
            this.radioButtonTime.Location = new System.Drawing.Point(1294, 404);
            this.radioButtonTime.Name = "radioButtonTime";
            this.radioButtonTime.Size = new System.Drawing.Size(60, 17);
            this.radioButtonTime.TabIndex = 10;
            this.radioButtonTime.TabStop = true;
            this.radioButtonTime.Text = "Tiempo";
            this.radioButtonTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonCost
            // 
            this.radioButtonCost.AutoSize = true;
            this.radioButtonCost.Location = new System.Drawing.Point(1294, 427);
            this.radioButtonCost.Name = "radioButtonCost";
            this.radioButtonCost.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCost.TabIndex = 11;
            this.radioButtonCost.Text = "Precio";
            this.radioButtonCost.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrigin
            // 
            this.comboBoxOrigin.FormattingEnabled = true;
            this.comboBoxOrigin.Location = new System.Drawing.Point(1232, 482);
            this.comboBoxOrigin.Name = "comboBoxOrigin";
            this.comboBoxOrigin.Size = new System.Drawing.Size(40, 21);
            this.comboBoxOrigin.TabIndex = 12;
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(1314, 482);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(40, 21);
            this.comboBoxDestination.TabIndex = 13;
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(1234, 466);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(38, 13);
            this.labelOrigin.TabIndex = 14;
            this.labelOrigin.Text = "Origen";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(1311, 466);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(43, 13);
            this.labelDestination.TabIndex = 15;
            this.labelDestination.Text = "Destino";
            // 
            // buttonDijkstra
            // 
            this.buttonDijkstra.Location = new System.Drawing.Point(1223, 520);
            this.buttonDijkstra.Name = "buttonDijkstra";
            this.buttonDijkstra.Size = new System.Drawing.Size(75, 23);
            this.buttonDijkstra.TabIndex = 0;
            this.buttonDijkstra.Text = "Dijkstra";
            this.buttonDijkstra.UseVisualStyleBackColor = true;
            this.buttonDijkstra.Click += new System.EventHandler(this.buttonDijkstra_Click);
            // 
            // listViewDijkstra
            // 
            this.listViewDijkstra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewDijkstra.Location = new System.Drawing.Point(1142, 549);
            this.listViewDijkstra.Name = "listViewDijkstra";
            this.listViewDijkstra.Size = new System.Drawing.Size(212, 170);
            this.listViewDijkstra.TabIndex = 16;
            this.listViewDijkstra.UseCompatibleStateImageBehavior = false;
            this.listViewDijkstra.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Origen";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Destino";
            this.columnHeader2.Width = 20;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Peso";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Recorrido";
            this.columnHeader4.Width = 100;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(1312, 520);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 17;
            this.buttonBuy.Text = "Reservar";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 741);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.listViewDijkstra);
            this.Controls.Add(this.buttonDijkstra);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.comboBoxOrigin);
            this.Controls.Add(this.radioButtonCost);
            this.Controls.Add(this.radioButtonTime);
            this.Controls.Add(this.labelDijkstra);
            this.Controls.Add(this.buttonPrim);
            this.Controls.Add(this.labelCostResult);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.buttonKruskal);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelCitySelect);
            this.Controls.Add(this.panelMap);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Label labelCitySelect;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonKruskal;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelCostResult;
        private System.Windows.Forms.Button buttonPrim;
        private System.Windows.Forms.Label labelDijkstra;
        private System.Windows.Forms.RadioButton radioButtonTime;
        private System.Windows.Forms.RadioButton radioButtonCost;
        private System.Windows.Forms.ComboBox comboBoxOrigin;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Button buttonDijkstra;
        private System.Windows.Forms.ListView listViewDijkstra;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonBuy;
    }
}