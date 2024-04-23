namespace VirtualZooManagementSystem
{
    partial class FeedAnimals
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
            this.components = new System.ComponentModel.Container();
            this.animalTypeLable = new System.Windows.Forms.Label();
            this.animalNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.animalFeedLabel = new System.Windows.Forms.Label();
            this.feedAnimalButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AnimalNameComboBox = new System.Windows.Forms.ComboBox();
            this.animalsDataSet = new VirtualZooManagementSystem.animalsDataSet();
            this.animalsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsTableAdapter = new VirtualZooManagementSystem.animalsDataSetTableAdapters.animalsTableAdapter();
            this.animalsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AnimalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // animalTypeLable
            // 
            this.animalTypeLable.AutoSize = true;
            this.animalTypeLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animalTypeLable.Location = new System.Drawing.Point(229, 15);
            this.animalTypeLable.Name = "animalTypeLable";
            this.animalTypeLable.Size = new System.Drawing.Size(70, 15);
            this.animalTypeLable.TabIndex = 1;
            this.animalTypeLable.Text = "Animal Type:";
            // 
            // animalNameLabel
            // 
            this.animalNameLabel.AutoSize = true;
            this.animalNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animalNameLabel.Location = new System.Drawing.Point(229, 88);
            this.animalNameLabel.Name = "animalNameLabel";
            this.animalNameLabel.Size = new System.Drawing.Size(74, 15);
            this.animalNameLabel.TabIndex = 2;
            this.animalNameLabel.Text = "Animal Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.animalFeedLabel);
            this.panel1.Location = new System.Drawing.Point(15, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 77);
            this.panel1.TabIndex = 3;
            // 
            // animalFeedLabel
            // 
            this.animalFeedLabel.AutoSize = true;
            this.animalFeedLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalFeedLabel.Location = new System.Drawing.Point(172, 23);
            this.animalFeedLabel.Name = "animalFeedLabel";
            this.animalFeedLabel.Size = new System.Drawing.Size(217, 33);
            this.animalFeedLabel.TabIndex = 0;
            this.animalFeedLabel.Text = "Feed an Animal";
            // 
            // feedAnimalButton
            // 
            this.feedAnimalButton.Location = new System.Drawing.Point(146, 367);
            this.feedAnimalButton.Name = "feedAnimalButton";
            this.feedAnimalButton.Size = new System.Drawing.Size(105, 23);
            this.feedAnimalButton.TabIndex = 7;
            this.feedAnimalButton.Text = "Feed this Animal";
            this.feedAnimalButton.UseVisualStyleBackColor = true;
            this.feedAnimalButton.Click += new System.EventHandler(this.feedAnimalButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Give this Animal Water";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.AnimalTypeComboBox);
            this.panel2.Controls.Add(this.AnimalNameComboBox);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.animalTypeLable);
            this.panel2.Controls.Add(this.feedAnimalButton);
            this.panel2.Controls.Add(this.animalNameLabel);
            this.panel2.Location = new System.Drawing.Point(15, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 417);
            this.panel2.TabIndex = 9;
            // 
            // AnimalNameComboBox
            // 
            this.AnimalNameComboBox.DataSource = this.animalsBindingSource1;
            this.AnimalNameComboBox.DisplayMember = "Name";
            this.AnimalNameComboBox.FormattingEnabled = true;
            this.AnimalNameComboBox.Location = new System.Drawing.Point(207, 106);
            this.AnimalNameComboBox.Name = "AnimalNameComboBox";
            this.AnimalNameComboBox.Size = new System.Drawing.Size(130, 21);
            this.AnimalNameComboBox.TabIndex = 9;
            this.AnimalNameComboBox.ValueMember = "Name";
            this.AnimalNameComboBox.SelectedIndexChanged += new System.EventHandler(this.AnimalNameComboBox_SelectedIndexChanged);
            // 
            // animalsDataSet
            // 
            this.animalsDataSet.DataSetName = "animalsDataSet";
            this.animalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalsDataSetBindingSource
            // 
            this.animalsDataSetBindingSource.DataSource = this.animalsDataSet;
            this.animalsDataSetBindingSource.Position = 0;
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "animals";
            this.animalsBindingSource.DataSource = this.animalsDataSetBindingSource;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // animalsBindingSource1
            // 
            this.animalsBindingSource1.DataMember = "animals";
            this.animalsBindingSource1.DataSource = this.animalsDataSet;
            // 
            // AnimalTypeComboBox
            // 
            this.AnimalTypeComboBox.DataSource = this.animalsBindingSource2;
            this.AnimalTypeComboBox.DisplayMember = "AnimalType";
            this.AnimalTypeComboBox.FormattingEnabled = true;
            this.AnimalTypeComboBox.Location = new System.Drawing.Point(207, 33);
            this.AnimalTypeComboBox.Name = "AnimalTypeComboBox";
            this.AnimalTypeComboBox.Size = new System.Drawing.Size(130, 21);
            this.AnimalTypeComboBox.TabIndex = 10;
            this.AnimalTypeComboBox.ValueMember = "AnimalType";
            this.AnimalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AnimalTypeComboBox_SelectedIndexChanged);
            // 
            // animalsBindingSource2
            // 
            this.animalsBindingSource2.DataMember = "animals";
            this.animalsBindingSource2.DataSource = this.animalsDataSetBindingSource;
            // 
            // FeedAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FeedAnimals";
            this.Size = new System.Drawing.Size(573, 569);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label animalTypeLable;
        private System.Windows.Forms.Label animalNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label animalFeedLabel;
        private System.Windows.Forms.Button feedAnimalButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox AnimalNameComboBox;
        private animalsDataSet animalsDataSet;
        private System.Windows.Forms.BindingSource animalsDataSetBindingSource;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private animalsDataSetTableAdapters.animalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.BindingSource animalsBindingSource1;
        private System.Windows.Forms.ComboBox AnimalTypeComboBox;
        private System.Windows.Forms.BindingSource animalsBindingSource2;
    }
}
