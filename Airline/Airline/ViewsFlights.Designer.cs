namespace Airline
{
    partial class ViewsFlights
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
            this.listViewFlights = new System.Windows.Forms.ListView();
            this.columnHeaderRoute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDistination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFlights = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioButtonRoute = new System.Windows.Forms.RadioButton();
            this.radioButtonOrigin = new System.Windows.Forms.RadioButton();
            this.radioButtonDestination = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelSearchType = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSelectFlgiht = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFlights
            // 
            this.listViewFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRoute,
            this.columnHeaderOrigin,
            this.columnHeaderDistination,
            this.columnHeaderTime,
            this.columnHeaderCost});
            this.listViewFlights.Location = new System.Drawing.Point(12, 50);
            this.listViewFlights.Name = "listViewFlights";
            this.listViewFlights.Size = new System.Drawing.Size(360, 423);
            this.listViewFlights.TabIndex = 0;
            this.listViewFlights.UseCompatibleStateImageBehavior = false;
            this.listViewFlights.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRoute
            // 
            this.columnHeaderRoute.Text = "Ruta";
            this.columnHeaderRoute.Width = 85;
            // 
            // columnHeaderOrigin
            // 
            this.columnHeaderOrigin.Text = "Origen";
            // 
            // columnHeaderDistination
            // 
            this.columnHeaderDistination.Text = "Destino";
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Tiempo";
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Costo";
            this.columnHeaderCost.Width = 90;
            // 
            // labelFlights
            // 
            this.labelFlights.AutoSize = true;
            this.labelFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlights.Location = new System.Drawing.Point(148, 27);
            this.labelFlights.Name = "labelFlights";
            this.labelFlights.Size = new System.Drawing.Size(58, 20);
            this.labelFlights.TabIndex = 1;
            this.labelFlights.Text = "Vuelos";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(446, 50);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(55, 13);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Busqueda";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(383, 387);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // radioButtonRoute
            // 
            this.radioButtonRoute.AutoSize = true;
            this.radioButtonRoute.Checked = true;
            this.radioButtonRoute.Location = new System.Drawing.Point(476, 79);
            this.radioButtonRoute.Name = "radioButtonRoute";
            this.radioButtonRoute.Size = new System.Drawing.Size(48, 17);
            this.radioButtonRoute.TabIndex = 7;
            this.radioButtonRoute.TabStop = true;
            this.radioButtonRoute.Text = "Ruta";
            this.radioButtonRoute.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrigin
            // 
            this.radioButtonOrigin.AutoSize = true;
            this.radioButtonOrigin.Location = new System.Drawing.Point(476, 102);
            this.radioButtonOrigin.Name = "radioButtonOrigin";
            this.radioButtonOrigin.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOrigin.TabIndex = 8;
            this.radioButtonOrigin.TabStop = true;
            this.radioButtonOrigin.Text = "Origen";
            this.radioButtonOrigin.UseVisualStyleBackColor = true;
            // 
            // radioButtonDestination
            // 
            this.radioButtonDestination.AutoSize = true;
            this.radioButtonDestination.Location = new System.Drawing.Point(476, 125);
            this.radioButtonDestination.Name = "radioButtonDestination";
            this.radioButtonDestination.Size = new System.Drawing.Size(61, 17);
            this.radioButtonDestination.TabIndex = 9;
            this.radioButtonDestination.TabStop = true;
            this.radioButtonDestination.Text = "Destino";
            this.radioButtonDestination.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(476, 148);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(85, 20);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(388, 151);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(82, 13);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Datos a buscar:";
            // 
            // labelSearchType
            // 
            this.labelSearchType.AutoSize = true;
            this.labelSearchType.Location = new System.Drawing.Point(378, 104);
            this.labelSearchType.Name = "labelSearchType";
            this.labelSearchType.Size = new System.Drawing.Size(96, 13);
            this.labelSearchType.TabIndex = 12;
            this.labelSearchType.Text = "Tipo de busqueda:";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(457, 185);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(44, 13);
            this.labelAdd.TabIndex = 13;
            this.labelAdd.Text = "Agregar";
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(417, 215);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(41, 13);
            this.labelOrigin.TabIndex = 14;
            this.labelOrigin.Text = "Origen:";
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.Location = new System.Drawing.Point(476, 212);
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.Size = new System.Drawing.Size(48, 20);
            this.textBoxOrigin.TabIndex = 15;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(417, 245);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(46, 13);
            this.labelDestination.TabIndex = 16;
            this.labelDestination.Text = "Destino:";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(476, 242);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(48, 20);
            this.textBoxDestination.TabIndex = 17;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(417, 274);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(45, 13);
            this.labelTime.TabIndex = 18;
            this.labelTime.Text = "Tiempo:";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(476, 271);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(48, 20);
            this.textBoxTime.TabIndex = 19;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(417, 301);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(37, 13);
            this.labelCost.TabIndex = 20;
            this.labelCost.Text = "Costo:";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(476, 298);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(61, 20);
            this.textBoxCost.TabIndex = 21;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(438, 324);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSelectFlgiht
            // 
            this.labelSelectFlgiht.AutoSize = true;
            this.labelSelectFlgiht.Location = new System.Drawing.Point(433, 361);
            this.labelSelectFlgiht.Name = "labelSelectFlgiht";
            this.labelSelectFlgiht.Size = new System.Drawing.Size(104, 13);
            this.labelSelectFlgiht.TabIndex = 23;
            this.labelSelectFlgiht.Text = "Selecciona un vuelo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Reservar Boloeto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewsFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSelectFlgiht);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.textBoxOrigin);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelSearchType);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.radioButtonDestination);
            this.Controls.Add(this.radioButtonOrigin);
            this.Controls.Add(this.radioButtonRoute);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelFlights);
            this.Controls.Add(this.listViewFlights);
            this.Name = "ViewsFlights";
            this.Text = "ViewsFlights";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFlights;
        private System.Windows.Forms.Label labelFlights;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ColumnHeader columnHeaderRoute;
        private System.Windows.Forms.ColumnHeader columnHeaderOrigin;
        private System.Windows.Forms.ColumnHeader columnHeaderDistination;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.RadioButton radioButtonRoute;
        private System.Windows.Forms.RadioButton radioButtonOrigin;
        private System.Windows.Forms.RadioButton radioButtonDestination;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelSearchType;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.TextBox textBoxOrigin;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSelectFlgiht;
        private System.Windows.Forms.Button button1;
    }
}