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
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.passengersButton = new System.Windows.Forms.Button();
            this.flightsButton = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AllowDrop = true;
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.Location = new System.Drawing.Point(54, 22);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(264, 39);
            this.mainTitleLabel.TabIndex = 0;
            this.mainTitleLabel.Text = "Al Qaeda Airline";
            this.mainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passengersButton
            // 
            this.passengersButton.Location = new System.Drawing.Point(76, 173);
            this.passengersButton.Name = "passengersButton";
            this.passengersButton.Size = new System.Drawing.Size(210, 36);
            this.passengersButton.TabIndex = 2;
            this.passengersButton.Text = "Pasajeros";
            this.passengersButton.UseVisualStyleBackColor = true;
            this.passengersButton.Click += new System.EventHandler(this.passengersButton_Click);
            // 
            // flightsButton
            // 
            this.flightsButton.Location = new System.Drawing.Point(76, 109);
            this.flightsButton.Name = "flightsButton";
            this.flightsButton.Size = new System.Drawing.Size(210, 36);
            this.flightsButton.TabIndex = 3;
            this.flightsButton.Text = "Vuelos";
            this.flightsButton.UseVisualStyleBackColor = true;
            this.flightsButton.Click += new System.EventHandler(this.flightsButton_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(76, 236);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(210, 36);
            this.buttonGraph.TabIndex = 4;
            this.buttonGraph.Text = "Grafo";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // MainMenu
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 323);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.flightsButton);
            this.Controls.Add(this.passengersButton);
            this.Controls.Add(this.mainTitleLabel);
            this.Name = "MainMenu";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Button passengersButton;
        private System.Windows.Forms.Button flightsButton;
        private System.Windows.Forms.Button buttonGraph;
    }
}

