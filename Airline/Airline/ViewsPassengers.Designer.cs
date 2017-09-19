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
            this.labelSearch = new System.Windows.Forms.Label();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.radioButtonRoute = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
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
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(527, 45);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(83, 13);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Buscar pasajero";
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Checked = true;
            this.radioButtonID.Location = new System.Drawing.Point(557, 70);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(36, 17);
            this.radioButtonID.TabIndex = 5;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoute
            // 
            this.radioButtonRoute.AutoSize = true;
            this.radioButtonRoute.Location = new System.Drawing.Point(557, 93);
            this.radioButtonRoute.Name = "radioButtonRoute";
            this.radioButtonRoute.Size = new System.Drawing.Size(48, 17);
            this.radioButtonRoute.TabIndex = 6;
            this.radioButtonRoute.Text = "Ruta";
            this.radioButtonRoute.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(530, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(557, 115);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(62, 17);
            this.radioButtonName.TabIndex = 8;
            this.radioButtonName.Text = "Nombre";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // ViewsPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 326);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonRoute);
            this.Controls.Add(this.radioButtonID);
            this.Controls.Add(this.labelSearch);
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
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ColumnHeader columnHeader1ID;
        private System.Windows.Forms.ColumnHeader columnHeader2Route;
        private System.Windows.Forms.ColumnHeader columnHeader3Name;
        private System.Windows.Forms.ColumnHeader columnHeader4LastName;
        private System.Windows.Forms.ColumnHeader columnHeader5Age;
        private System.Windows.Forms.ColumnHeader columnHeader6SeatNumber;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.RadioButton radioButtonRoute;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonName;
    }
}