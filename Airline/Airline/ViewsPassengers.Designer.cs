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
            this.listViewPassengers1.Location = new System.Drawing.Point(32, 45);
            this.listViewPassengers1.Name = "listViewPassengers1";
            this.listViewPassengers1.Size = new System.Drawing.Size(156, 217);
            this.listViewPassengers1.TabIndex = 0;
            this.listViewPassengers1.UseCompatibleStateImageBehavior = false;
            // 
            // labelPassengers1
            // 
            this.labelPassengers1.AutoSize = true;
            this.labelPassengers1.Location = new System.Drawing.Point(70, 29);
            this.labelPassengers1.Name = "labelPassengers1";
            this.labelPassengers1.Size = new System.Drawing.Size(53, 13);
            this.labelPassengers1.TabIndex = 1;
            this.labelPassengers1.Text = "Pasajeros";
            // 
            // textBoxID1
            // 
            this.textBoxID1.Location = new System.Drawing.Point(246, 104);
            this.textBoxID1.Name = "textBoxID1";
            this.textBoxID1.Size = new System.Drawing.Size(100, 20);
            this.textBoxID1.TabIndex = 2;
            // 
            // labelDelete2
            // 
            this.labelDelete2.AutoSize = true;
            this.labelDelete2.Location = new System.Drawing.Point(216, 77);
            this.labelDelete2.Name = "labelDelete2";
            this.labelDelete2.Size = new System.Drawing.Size(130, 13);
            this.labelDelete2.TabIndex = 3;
            this.labelDelete2.Text = "Eliminar o buscar pasajero";
            this.labelDelete2.Click += new System.EventHandler(this.labelDelete2_Click);
            // 
            // labelID3
            // 
            this.labelID3.AutoSize = true;
            this.labelID3.Location = new System.Drawing.Point(216, 111);
            this.labelID3.Name = "labelID3";
            this.labelID3.Size = new System.Drawing.Size(24, 13);
            this.labelID3.TabIndex = 4;
            this.labelID3.Text = "ID: ";
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Location = new System.Drawing.Point(300, 186);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete1.TabIndex = 5;
            this.buttonDelete1.Text = "Eliminaro";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.Location = new System.Drawing.Point(219, 186);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch2.TabIndex = 6;
            this.buttonSearch2.Text = "Buscar";
            this.buttonSearch2.UseVisualStyleBackColor = true;
            // 
            // comboBoxFlights1
            // 
            this.comboBoxFlights1.FormattingEnabled = true;
            this.comboBoxFlights1.Location = new System.Drawing.Point(246, 144);
            this.comboBoxFlights1.Name = "comboBoxFlights1";
            this.comboBoxFlights1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFlights1.TabIndex = 7;
            // 
            // labelFlights1
            // 
            this.labelFlights1.AutoSize = true;
            this.labelFlights1.Location = new System.Drawing.Point(206, 147);
            this.labelFlights1.Name = "labelFlights1";
            this.labelFlights1.Size = new System.Drawing.Size(37, 13);
            this.labelFlights1.TabIndex = 8;
            this.labelFlights1.Text = "Vuelo:";
            // 
            // ViewsPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 326);
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
    }
}