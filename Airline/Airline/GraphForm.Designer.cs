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
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMap.BackgroundImage")));
            this.panelMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMap.Location = new System.Drawing.Point(12, 23);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1238, 738);
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
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 790);
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
    }
}