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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.labelSelection = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioButtonNamS = new System.Windows.Forms.RadioButton();
            this.radioButtonFlight = new System.Windows.Forms.RadioButton();
            this.radioButtonSeat = new System.Windows.Forms.RadioButton();
            this.labelSorts = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
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
            this.listViewPassengers.Size = new System.Drawing.Size(431, 397);
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
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(527, 45);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(116, 18);
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
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(530, 138);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
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
            // labelSelection
            // 
            this.labelSelection.AutoSize = true;
            this.labelSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelection.Location = new System.Drawing.Point(513, 372);
            this.labelSelection.Name = "labelSelection";
            this.labelSelection.Size = new System.Drawing.Size(142, 18);
            this.labelSelection.TabIndex = 9;
            this.labelSelection.Text = "Selecciona pasajero";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(544, 409);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // radioButtonNamS
            // 
            this.radioButtonNamS.AutoSize = true;
            this.radioButtonNamS.Location = new System.Drawing.Point(557, 221);
            this.radioButtonNamS.Name = "radioButtonNamS";
            this.radioButtonNamS.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNamS.TabIndex = 12;
            this.radioButtonNamS.TabStop = true;
            this.radioButtonNamS.Text = "Name";
            this.radioButtonNamS.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlight
            // 
            this.radioButtonFlight.AutoSize = true;
            this.radioButtonFlight.Location = new System.Drawing.Point(557, 244);
            this.radioButtonFlight.Name = "radioButtonFlight";
            this.radioButtonFlight.Size = new System.Drawing.Size(52, 17);
            this.radioButtonFlight.TabIndex = 13;
            this.radioButtonFlight.TabStop = true;
            this.radioButtonFlight.Text = "Vuelo";
            this.radioButtonFlight.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeat
            // 
            this.radioButtonSeat.AutoSize = true;
            this.radioButtonSeat.Location = new System.Drawing.Point(557, 267);
            this.radioButtonSeat.Name = "radioButtonSeat";
            this.radioButtonSeat.Size = new System.Drawing.Size(60, 17);
            this.radioButtonSeat.TabIndex = 14;
            this.radioButtonSeat.TabStop = true;
            this.radioButtonSeat.Text = "Asiento";
            this.radioButtonSeat.UseVisualStyleBackColor = true;
            // 
            // labelSorts
            // 
            this.labelSorts.AutoSize = true;
            this.labelSorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSorts.Location = new System.Drawing.Point(526, 186);
            this.labelSorts.Name = "labelSorts";
            this.labelSorts.Size = new System.Drawing.Size(110, 18);
            this.labelSorts.TabIndex = 15;
            this.labelSorts.Text = "Ordenamientos";
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.Location = new System.Drawing.Point(544, 300);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 16;
            this.buttonSort.Text = "Ordenar";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // ViewsPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 468);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelSorts);
            this.Controls.Add(this.radioButtonSeat);
            this.Controls.Add(this.radioButtonFlight);
            this.Controls.Add(this.radioButtonNamS);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelSelection);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.textBoxSearch);
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
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.Label labelSelection;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RadioButton radioButtonNamS;
        private System.Windows.Forms.RadioButton radioButtonFlight;
        private System.Windows.Forms.RadioButton radioButtonSeat;
        private System.Windows.Forms.Label labelSorts;
        private System.Windows.Forms.Button buttonSort;
    }
}