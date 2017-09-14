namespace Airline
{
    partial class ViewsPassengers
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
            this.listViewPassengers = new System.Windows.Forms.ListView();
            this.columnHeader1ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2Route = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6SeatNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPassengers = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelID3 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxFlights = new System.Windows.Forms.ComboBox();
            this.labelFlights1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPassengers
            // 
            this.listViewPassengers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewPassengers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1ID,
            this.columnHeader2Route,
            this.columnHeader3Name,
            this.columnHeader4LastName,
            this.columnHeader5Age,
            this.columnHeader6SeatNumber});
            this.listViewPassengers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewPassengers.Location = new System.Drawing.Point(32, 45);
            this.listViewPassengers.Name = "listViewPassengers";
            this.listViewPassengers.Size = new System.Drawing.Size(424, 269);
            this.listViewPassengers.TabIndex = 0;
            this.listViewPassengers.UseCompatibleStateImageBehavior = false;
            this.listViewPassengers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1ID
            // 
            this.columnHeader1ID.Text = "ID";
            this.columnHeader1ID.Width = 75;
            // 
            // columnHeader2Route
            // 
            this.columnHeader2Route.Text = "Ruta";
            this.columnHeader2Route.Width = 55;
            // 
            // columnHeader3Name
            // 
            this.columnHeader3Name.Text = "Nombre";
            this.columnHeader3Name.Width = 85;
            // 
            // columnHeader4LastName
            // 
            this.columnHeader4LastName.Text = "Apellido";
            this.columnHeader4LastName.Width = 90;
            // 
            // columnHeader5Age
            // 
            this.columnHeader5Age.Text = "Edad";
            // 
            // columnHeader6SeatNumber
            // 
            this.columnHeader6SeatNumber.Text = "Nº asiento";
            // 
            // labelPassengers
            // 
            this.labelPassengers.AutoSize = true;
            this.labelPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassengers.Location = new System.Drawing.Point(161, 9);
            this.labelPassengers.Name = "labelPassengers";
            this.labelPassengers.Size = new System.Drawing.Size(135, 31);
            this.labelPassengers.TabIndex = 1;
            this.labelPassengers.Text = "Pasajeros";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(519, 117);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(527, 45);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(83, 13);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Buscar pasajero";
            // 
            // labelID3
            // 
            this.labelID3.AutoSize = true;
            this.labelID3.Location = new System.Drawing.Point(527, 70);
            this.labelID3.Name = "labelID3";
            this.labelID3.Size = new System.Drawing.Size(24, 13);
            this.labelID3.TabIndex = 4;
            this.labelID3.Text = "ID: ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(573, 195);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Eliminaro";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(492, 195);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // comboBoxFlights
            // 
            this.comboBoxFlights.FormattingEnabled = true;
            this.comboBoxFlights.Location = new System.Drawing.Point(519, 153);
            this.comboBoxFlights.Name = "comboBoxFlights";
            this.comboBoxFlights.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFlights.TabIndex = 7;
            // 
            // labelFlights1
            // 
            this.labelFlights1.AutoSize = true;
            this.labelFlights1.Location = new System.Drawing.Point(479, 156);
            this.labelFlights1.Name = "labelFlights1";
            this.labelFlights1.Size = new System.Drawing.Size(37, 13);
            this.labelFlights1.TabIndex = 8;
            this.labelFlights1.Text = "Vuelo:";
            // 
            // ViewsPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 326);
            this.Controls.Add(this.labelFlights1);
            this.Controls.Add(this.comboBoxFlights);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelID3);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPassengers);
            this.Controls.Add(this.listViewPassengers);
            this.Name = "ViewsPassengers";
            this.Text = "ViewsPassengers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPassengers;
        private System.Windows.Forms.Label labelPassengers;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelID3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxFlights;
        private System.Windows.Forms.Label labelFlights1;
        private System.Windows.Forms.ColumnHeader columnHeader1ID;
        private System.Windows.Forms.ColumnHeader columnHeader2Route;
        private System.Windows.Forms.ColumnHeader columnHeader3Name;
        private System.Windows.Forms.ColumnHeader columnHeader4LastName;
        private System.Windows.Forms.ColumnHeader columnHeader5Age;
        private System.Windows.Forms.ColumnHeader columnHeader6SeatNumber;
    }
}