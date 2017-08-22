namespace Airline
{
    partial class FlightReservation
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
            this.comboBoxFlights1 = new System.Windows.Forms.ComboBox();
            this.labelFlightsList1 = new System.Windows.Forms.Label();
            this.textBoxPassengerName1 = new System.Windows.Forms.TextBox();
            this.textBoxPassengerLastName2 = new System.Windows.Forms.TextBox();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelLastName3 = new System.Windows.Forms.Label();
            this.labelAge4 = new System.Windows.Forms.Label();
            this.textBoxPassengerAge3 = new System.Windows.Forms.TextBox();
            this.labelYears5 = new System.Windows.Forms.Label();
            this.buttonSelling1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFlights1
            // 
            this.comboBoxFlights1.FormattingEnabled = true;
            this.comboBoxFlights1.Location = new System.Drawing.Point(174, 29);
            this.comboBoxFlights1.Name = "comboBoxFlights1";
            this.comboBoxFlights1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFlights1.TabIndex = 0;
            this.comboBoxFlights1.Text = "Selecciona un vuelo";
            // 
            // labelFlightsList1
            // 
            this.labelFlightsList1.AutoSize = true;
            this.labelFlightsList1.Location = new System.Drawing.Point(36, 32);
            this.labelFlightsList1.Name = "labelFlightsList1";
            this.labelFlightsList1.Size = new System.Drawing.Size(84, 13);
            this.labelFlightsList1.TabIndex = 1;
            this.labelFlightsList1.Text = "Lista de vuelos: ";
            // 
            // textBoxPassengerName1
            // 
            this.textBoxPassengerName1.Location = new System.Drawing.Point(127, 68);
            this.textBoxPassengerName1.Name = "textBoxPassengerName1";
            this.textBoxPassengerName1.Size = new System.Drawing.Size(228, 20);
            this.textBoxPassengerName1.TabIndex = 2;
            this.textBoxPassengerName1.WordWrap = false;
            // 
            // textBoxPassengerLastName2
            // 
            this.textBoxPassengerLastName2.Location = new System.Drawing.Point(127, 114);
            this.textBoxPassengerLastName2.Name = "textBoxPassengerLastName2";
            this.textBoxPassengerLastName2.Size = new System.Drawing.Size(228, 20);
            this.textBoxPassengerLastName2.TabIndex = 3;
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(36, 68);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(50, 13);
            this.labelName2.TabIndex = 4;
            this.labelName2.Text = "Nombre: ";
            // 
            // labelLastName3
            // 
            this.labelLastName3.AutoSize = true;
            this.labelLastName3.Location = new System.Drawing.Point(36, 114);
            this.labelLastName3.Name = "labelLastName3";
            this.labelLastName3.Size = new System.Drawing.Size(50, 13);
            this.labelLastName3.TabIndex = 5;
            this.labelLastName3.Text = "Apellido: ";
            // 
            // labelAge4
            // 
            this.labelAge4.AutoSize = true;
            this.labelAge4.Location = new System.Drawing.Point(39, 155);
            this.labelAge4.Name = "labelAge4";
            this.labelAge4.Size = new System.Drawing.Size(38, 13);
            this.labelAge4.TabIndex = 6;
            this.labelAge4.Text = "Edad: ";
            // 
            // textBoxPassengerAge3
            // 
            this.textBoxPassengerAge3.Location = new System.Drawing.Point(127, 155);
            this.textBoxPassengerAge3.Name = "textBoxPassengerAge3";
            this.textBoxPassengerAge3.Size = new System.Drawing.Size(58, 20);
            this.textBoxPassengerAge3.TabIndex = 7;
            // 
            // labelYears5
            // 
            this.labelYears5.AutoSize = true;
            this.labelYears5.Location = new System.Drawing.Point(191, 162);
            this.labelYears5.Name = "labelYears5";
            this.labelYears5.Size = new System.Drawing.Size(30, 13);
            this.labelYears5.TabIndex = 8;
            this.labelYears5.Text = "años";
            // 
            // buttonSelling1
            // 
            this.buttonSelling1.Location = new System.Drawing.Point(174, 216);
            this.buttonSelling1.Name = "buttonSelling1";
            this.buttonSelling1.Size = new System.Drawing.Size(75, 23);
            this.buttonSelling1.TabIndex = 9;
            this.buttonSelling1.Text = "Venta";
            this.buttonSelling1.UseVisualStyleBackColor = true;
            // 
            // FlightReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 283);
            this.Controls.Add(this.buttonSelling1);
            this.Controls.Add(this.labelYears5);
            this.Controls.Add(this.textBoxPassengerAge3);
            this.Controls.Add(this.labelAge4);
            this.Controls.Add(this.labelLastName3);
            this.Controls.Add(this.labelName2);
            this.Controls.Add(this.textBoxPassengerLastName2);
            this.Controls.Add(this.textBoxPassengerName1);
            this.Controls.Add(this.labelFlightsList1);
            this.Controls.Add(this.comboBoxFlights1);
            this.Name = "FlightReservation";
            this.Text = "FlightReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFlights1;
        private System.Windows.Forms.Label labelFlightsList1;
        private System.Windows.Forms.TextBox textBoxPassengerName1;
        private System.Windows.Forms.TextBox textBoxPassengerLastName2;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelLastName3;
        private System.Windows.Forms.Label labelAge4;
        private System.Windows.Forms.TextBox textBoxPassengerAge3;
        private System.Windows.Forms.Label labelYears5;
        private System.Windows.Forms.Button buttonSelling1;
    }
}