namespace VirtualZooManagementSystem
{
    partial class VirtualZooMangementSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.animalAddMenu = new System.Windows.Forms.Button();
            this.animalHealthMenu = new System.Windows.Forms.Button();
            this.checkAnimalActivity = new System.Windows.Forms.Button();
            this.animalFeedMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkAnimalActivity);
            this.panel1.Controls.Add(this.animalAddMenu);
            this.panel1.Controls.Add(this.animalHealthMenu);
            this.panel1.Controls.Add(this.animalFeedMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 648);
            this.panel1.TabIndex = 0;
            // 
            // animalAddMenu
            // 
            this.animalAddMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalAddMenu.Location = new System.Drawing.Point(52, 130);
            this.animalAddMenu.Name = "animalAddMenu";
            this.animalAddMenu.Size = new System.Drawing.Size(178, 30);
            this.animalAddMenu.TabIndex = 6;
            this.animalAddMenu.Text = "Add a new Animal";
            this.animalAddMenu.UseVisualStyleBackColor = true;
            // 
            // animalHealthMenu
            // 
            this.animalHealthMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalHealthMenu.Location = new System.Drawing.Point(52, 238);
            this.animalHealthMenu.Name = "animalHealthMenu";
            this.animalHealthMenu.Size = new System.Drawing.Size(178, 30);
            this.animalHealthMenu.TabIndex = 5;
            this.animalHealthMenu.Text = "Check Animal Health";
            this.animalHealthMenu.UseVisualStyleBackColor = true;
            // 
            // checkAnimalActivity
            // 
            this.checkAnimalActivity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAnimalActivity.Location = new System.Drawing.Point(52, 202);
            this.checkAnimalActivity.Name = "checkAnimalActivity";
            this.checkAnimalActivity.Size = new System.Drawing.Size(178, 30);
            this.checkAnimalActivity.TabIndex = 4;
            this.checkAnimalActivity.Text = "Check Animal Activity";
            this.checkAnimalActivity.UseVisualStyleBackColor = true;
            // 
            // animalFeedMenu
            // 
            this.animalFeedMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalFeedMenu.Location = new System.Drawing.Point(52, 166);
            this.animalFeedMenu.Name = "animalFeedMenu";
            this.animalFeedMenu.Size = new System.Drawing.Size(178, 30);
            this.animalFeedMenu.TabIndex = 3;
            this.animalFeedMenu.Text = "Feed an Animal";
            this.animalFeedMenu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Virtual Zoo Management System";
            // 
            // exit_button
            // 
            this.exit_button.AutoSize = true;
            this.exit_button.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(534, 27);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(27, 24);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "X";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.exit_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 79);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(280, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 569);
            this.panel3.TabIndex = 8;
            // 
            // VirtualZooMangementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(853, 648);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VirtualZooMangementSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Zoo Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button animalFeedMenu;
        private System.Windows.Forms.Button animalAddMenu;
        private System.Windows.Forms.Button animalHealthMenu;
        private System.Windows.Forms.Button checkAnimalActivity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

