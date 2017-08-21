namespace Airline
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTitle = new System.Windows.Forms.Label();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonPassengers = new System.Windows.Forms.Button();
            this.buttonFlights = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.AllowDrop = true;
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.Location = new System.Drawing.Point(54, 22);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(246, 39);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Alkaeda Airline";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReservation
            // 
            this.buttonReservation.Location = new System.Drawing.Point(76, 75);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(210, 36);
            this.buttonReservation.TabIndex = 1;
            this.buttonReservation.Text = "Reservaciones";
            this.buttonReservation.UseVisualStyleBackColor = true;
            // 
            // buttonPassengers
            // 
            this.buttonPassengers.Location = new System.Drawing.Point(76, 130);
            this.buttonPassengers.Name = "buttonPassengers";
            this.buttonPassengers.Size = new System.Drawing.Size(210, 36);
            this.buttonPassengers.TabIndex = 2;
            this.buttonPassengers.Text = "Pasajeros";
            this.buttonPassengers.UseVisualStyleBackColor = true;
            // 
            // buttonFlights
            // 
            this.buttonFlights.Location = new System.Drawing.Point(76, 182);
            this.buttonFlights.Name = "buttonFlights";
            this.buttonFlights.Size = new System.Drawing.Size(210, 36);
            this.buttonFlights.TabIndex = 3;
            this.buttonFlights.Text = "Vuelos";
            this.buttonFlights.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 323);
            this.Controls.Add(this.buttonFlights);
            this.Controls.Add(this.buttonPassengers);
            this.Controls.Add(this.buttonReservation);
            this.Controls.Add(this.MainTitle);
            this.Name = "MainMenu";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonPassengers;
        private System.Windows.Forms.Button buttonFlights;
    }
}

