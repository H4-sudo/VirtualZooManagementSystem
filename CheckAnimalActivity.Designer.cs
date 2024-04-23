namespace VirtualZooManagementSystem
{
    partial class CheckAnimalActivity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.animalActivityLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.animalActivityLabel);
            this.panel1.Location = new System.Drawing.Point(10, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 93);
            this.panel1.TabIndex = 0;
            // 
            // animalActivityLabel
            // 
            this.animalActivityLabel.AutoSize = true;
            this.animalActivityLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalActivityLabel.Location = new System.Drawing.Point(142, 31);
            this.animalActivityLabel.Name = "animalActivityLabel";
            this.animalActivityLabel.Size = new System.Drawing.Size(289, 33);
            this.animalActivityLabel.TabIndex = 0;
            this.animalActivityLabel.Text = "Check Animal Activity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Location = new System.Drawing.Point(10, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 410);
            this.panel2.TabIndex = 1;
            // 
            // CheckAnimalActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckAnimalActivity";
            this.Size = new System.Drawing.Size(573, 569);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label animalActivityLabel;
        private System.Windows.Forms.Panel panel2;
    }
}
