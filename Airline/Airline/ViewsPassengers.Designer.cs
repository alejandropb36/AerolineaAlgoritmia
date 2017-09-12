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
            this.listViewPassengers1 = new System.Windows.Forms.ListView();
            this.columnHeader1ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2Route = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6SeatNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPassengers1 = new System.Windows.Forms.Label();
            this.textBoxID1 = new System.Windows.Forms.TextBox();
            this.labelDelete2 = new System.Windows.Forms.Label();
            this.labelID3 = new System.Windows.Forms.Label();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.comboBoxFlights1 = new System.Windows.Forms.ComboBox();
            this.labelFlights1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPassengers1
            // 
            this.listViewPassengers1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewPassengers1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1ID,
            this.columnHeader2Route,
            this.columnHeader3Name,
            this.columnHeader4LastName,
            this.columnHeader5Age,
            this.columnHeader6SeatNumber});
            this.listViewPassengers1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewPassengers1.Location = new System.Drawing.Point(32, 45);
            this.listViewPassengers1.Name = "listViewPassengers1";
            this.listViewPassengers1.Size = new System.Drawing.Size(424, 269);
            this.listViewPassengers1.TabIndex = 0;
            this.listViewPassengers1.UseCompatibleStateImageBehavior = false;
            this.listViewPassengers1.View = System.Windows.Forms.View.Details;
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
            // labelPassengers1
            // 
            this.labelPassengers1.AutoSize = true;
            this.labelPassengers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassengers1.Location = new System.Drawing.Point(161, 9);
            this.labelPassengers1.Name = "labelPassengers1";
            this.labelPassengers1.Size = new System.Drawing.Size(135, 31);
            this.labelPassengers1.TabIndex = 1;
            this.labelPassengers1.Text = "Pasajeros";
            // 
            // textBoxID1
            // 
            this.textBoxID1.Location = new System.Drawing.Point(519, 113);
            this.textBoxID1.Name = "textBoxID1";
            this.textBoxID1.Size = new System.Drawing.Size(100, 20);
            this.textBoxID1.TabIndex = 2;
            // 
            // labelDelete2
            // 
            this.labelDelete2.AutoSize = true;
            this.labelDelete2.Location = new System.Drawing.Point(489, 86);
            this.labelDelete2.Name = "labelDelete2";
            this.labelDelete2.Size = new System.Drawing.Size(130, 13);
            this.labelDelete2.TabIndex = 3;
            this.labelDelete2.Text = "Eliminar o buscar pasajero";
            // 
            // labelID3
            // 
            this.labelID3.AutoSize = true;
            this.labelID3.Location = new System.Drawing.Point(489, 120);
            this.labelID3.Name = "labelID3";
            this.labelID3.Size = new System.Drawing.Size(24, 13);
            this.labelID3.TabIndex = 4;
            this.labelID3.Text = "ID: ";
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Location = new System.Drawing.Point(573, 195);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete1.TabIndex = 5;
            this.buttonDelete1.Text = "Eliminaro";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.Location = new System.Drawing.Point(492, 195);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch2.TabIndex = 6;
            this.buttonSearch2.Text = "Buscar";
            this.buttonSearch2.UseVisualStyleBackColor = true;
            // 
            // comboBoxFlights1
            // 
            this.comboBoxFlights1.FormattingEnabled = true;
            this.comboBoxFlights1.Location = new System.Drawing.Point(519, 153);
            this.comboBoxFlights1.Name = "comboBoxFlights1";
            this.comboBoxFlights1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFlights1.TabIndex = 7;
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
            this.Controls.Add(this.comboBoxFlights1);
            this.Controls.Add(this.buttonSearch2);
            this.Controls.Add(this.buttonDelete1);
            this.Controls.Add(this.labelID3);
            this.Controls.Add(this.labelDelete2);
            this.Controls.Add(this.textBoxID1);
            this.Controls.Add(this.labelPassengers1);
            this.Controls.Add(this.listViewPassengers1);
            this.Name = "ViewsPassengers";
            this.Text = "ViewsPassengers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPassengers1;
        private System.Windows.Forms.Label labelPassengers1;
        private System.Windows.Forms.TextBox textBoxID1;
        private System.Windows.Forms.Label labelDelete2;
        private System.Windows.Forms.Label labelID3;
        private System.Windows.Forms.Button buttonDelete1;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.ComboBox comboBoxFlights1;
        private System.Windows.Forms.Label labelFlights1;
        private System.Windows.Forms.ColumnHeader columnHeader1ID;
        private System.Windows.Forms.ColumnHeader columnHeader2Route;
        private System.Windows.Forms.ColumnHeader columnHeader3Name;
        private System.Windows.Forms.ColumnHeader columnHeader4LastName;
        private System.Windows.Forms.ColumnHeader columnHeader5Age;
        private System.Windows.Forms.ColumnHeader columnHeader6SeatNumber;
    }
}