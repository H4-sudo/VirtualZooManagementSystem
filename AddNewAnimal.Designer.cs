namespace VirtualZooManagementSystem
{
    partial class AddNewAnimal
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
            this.addAnimalLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.animalTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.turtleSelection = new System.Windows.Forms.RadioButton();
            this.parrotSelection = new System.Windows.Forms.RadioButton();
            this.elephantSelection = new System.Windows.Forms.RadioButton();
            this.lionSelection = new System.Windows.Forms.RadioButton();
            this.addAnimalInfoButton = new System.Windows.Forms.Button();
            this.animalNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.animalAgeInput = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.animalTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalAgeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // addAnimalLabel
            // 
            this.addAnimalLabel.AutoSize = true;
            this.addAnimalLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnimalLabel.Location = new System.Drawing.Point(189, 16);
            this.addAnimalLabel.Name = "addAnimalLabel";
            this.addAnimalLabel.Size = new System.Drawing.Size(206, 37);
            this.addAnimalLabel.TabIndex = 0;
            this.addAnimalLabel.Text = "Add an Animal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.addAnimalLabel);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 66);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.animalAgeInput);
            this.panel2.Controls.Add(this.animalTypeGroupBox);
            this.panel2.Controls.Add(this.addAnimalInfoButton);
            this.panel2.Controls.Add(this.animalNameInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 421);
            this.panel2.TabIndex = 8;
            // 
            // animalTypeGroupBox
            // 
            this.animalTypeGroupBox.Controls.Add(this.turtleSelection);
            this.animalTypeGroupBox.Controls.Add(this.parrotSelection);
            this.animalTypeGroupBox.Controls.Add(this.elephantSelection);
            this.animalTypeGroupBox.Controls.Add(this.lionSelection);
            this.animalTypeGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalTypeGroupBox.Location = new System.Drawing.Point(144, 132);
            this.animalTypeGroupBox.Name = "animalTypeGroupBox";
            this.animalTypeGroupBox.Size = new System.Drawing.Size(269, 165);
            this.animalTypeGroupBox.TabIndex = 8;
            this.animalTypeGroupBox.TabStop = false;
            this.animalTypeGroupBox.Text = "Animal Type:";
            // 
            // turtleSelection
            // 
            this.turtleSelection.AutoSize = true;
            this.turtleSelection.Location = new System.Drawing.Point(13, 106);
            this.turtleSelection.Name = "turtleSelection";
            this.turtleSelection.Size = new System.Drawing.Size(63, 22);
            this.turtleSelection.TabIndex = 3;
            this.turtleSelection.TabStop = true;
            this.turtleSelection.Text = "Turtle";
            this.turtleSelection.UseVisualStyleBackColor = true;
            this.turtleSelection.CheckedChanged += new System.EventHandler(this.turtleSelection_CheckedChanged);
            // 
            // parrotSelection
            // 
            this.parrotSelection.AutoSize = true;
            this.parrotSelection.Location = new System.Drawing.Point(13, 78);
            this.parrotSelection.Name = "parrotSelection";
            this.parrotSelection.Size = new System.Drawing.Size(69, 22);
            this.parrotSelection.TabIndex = 2;
            this.parrotSelection.TabStop = true;
            this.parrotSelection.Text = "Parrot";
            this.parrotSelection.UseVisualStyleBackColor = true;
            this.parrotSelection.CheckedChanged += new System.EventHandler(this.parrotSelection_CheckedChanged);
            // 
            // elephantSelection
            // 
            this.elephantSelection.AutoSize = true;
            this.elephantSelection.Location = new System.Drawing.Point(13, 50);
            this.elephantSelection.Name = "elephantSelection";
            this.elephantSelection.Size = new System.Drawing.Size(87, 22);
            this.elephantSelection.TabIndex = 1;
            this.elephantSelection.TabStop = true;
            this.elephantSelection.Text = "Elephant";
            this.elephantSelection.UseVisualStyleBackColor = true;
            this.elephantSelection.CheckedChanged += new System.EventHandler(this.elephantSelection_CheckedChanged);
            // 
            // lionSelection
            // 
            this.lionSelection.AutoSize = true;
            this.lionSelection.Location = new System.Drawing.Point(13, 22);
            this.lionSelection.Name = "lionSelection";
            this.lionSelection.Size = new System.Drawing.Size(56, 22);
            this.lionSelection.TabIndex = 0;
            this.lionSelection.TabStop = true;
            this.lionSelection.Text = "Lion";
            this.lionSelection.UseVisualStyleBackColor = true;
            this.lionSelection.CheckedChanged += new System.EventHandler(this.lionSelection_CheckedChanged);
            // 
            // addAnimalInfoButton
            // 
            this.addAnimalInfoButton.Location = new System.Drawing.Point(224, 303);
            this.addAnimalInfoButton.Name = "addAnimalInfoButton";
            this.addAnimalInfoButton.Size = new System.Drawing.Size(94, 39);
            this.addAnimalInfoButton.TabIndex = 7;
            this.addAnimalInfoButton.Text = "Add Animal!";
            this.addAnimalInfoButton.UseVisualStyleBackColor = true;
            this.addAnimalInfoButton.Click += new System.EventHandler(this.addAnimalInfoButton_Click);
            // 
            // animalNameInput
            // 
            this.animalNameInput.Location = new System.Drawing.Point(201, 22);
            this.animalNameInput.Name = "animalNameInput";
            this.animalNameInput.Size = new System.Drawing.Size(213, 20);
            this.animalNameInput.TabIndex = 3;
            this.animalNameInput.TextChanged += new System.EventHandler(this.animalNameInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // animalAgeInput
            // 
            this.animalAgeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animalAgeInput.Location = new System.Drawing.Point(202, 74);
            this.animalAgeInput.Name = "animalAgeInput";
            this.animalAgeInput.Size = new System.Drawing.Size(41, 16);
            this.animalAgeInput.TabIndex = 9;
            this.animalAgeInput.ValueChanged += new System.EventHandler(this.animalAgeInput_ValueChanged);
            // 
            // AddNewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewAnimal";
            this.Size = new System.Drawing.Size(573, 569);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.animalTypeGroupBox.ResumeLayout(false);
            this.animalTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalAgeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addAnimalLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox animalNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAnimalInfoButton;
        private System.Windows.Forms.GroupBox animalTypeGroupBox;
        private System.Windows.Forms.RadioButton turtleSelection;
        private System.Windows.Forms.RadioButton parrotSelection;
        private System.Windows.Forms.RadioButton elephantSelection;
        private System.Windows.Forms.RadioButton lionSelection;
        private System.Windows.Forms.NumericUpDown animalAgeInput;
    }
}
