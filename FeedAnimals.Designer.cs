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
            this.tendToAnAnimalLabel = new System.Windows.Forms.Label();
            this.feedAnimalButton = new System.Windows.Forms.Button();
            this.giveAnimalWaterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.playAnimalSoundBox = new System.Windows.Forms.CheckBox();
            this.InteractWithAnimalButton = new System.Windows.Forms.Button();
            this.restAnimalButton = new System.Windows.Forms.Button();
            this.AnimalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSet = new VirtualZooManagementSystem.animalsDataSet();
            this.AnimalNameComboBox = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.animalsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsTableAdapter = new VirtualZooManagementSystem.animalsDataSetTableAdapters.animalsTableAdapter();
            this.animalsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.animalsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource4)).BeginInit();
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
            this.panel1.Controls.Add(this.tendToAnAnimalLabel);
            this.panel1.Location = new System.Drawing.Point(15, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 77);
            this.panel1.TabIndex = 3;
            // 
            // tendToAnAnimalLabel
            // 
            this.tendToAnAnimalLabel.AutoSize = true;
            this.tendToAnAnimalLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendToAnAnimalLabel.Location = new System.Drawing.Point(142, 24);
            this.tendToAnAnimalLabel.Name = "tendToAnAnimalLabel";
            this.tendToAnAnimalLabel.Size = new System.Drawing.Size(247, 33);
            this.tendToAnAnimalLabel.TabIndex = 0;
            this.tendToAnAnimalLabel.Text = "Tend to an Animal";
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
            // giveAnimalWaterButton
            // 
            this.giveAnimalWaterButton.Location = new System.Drawing.Point(265, 367);
            this.giveAnimalWaterButton.Name = "giveAnimalWaterButton";
            this.giveAnimalWaterButton.Size = new System.Drawing.Size(124, 23);
            this.giveAnimalWaterButton.TabIndex = 8;
            this.giveAnimalWaterButton.Text = "Give this Animal Water";
            this.giveAnimalWaterButton.UseVisualStyleBackColor = true;
            this.giveAnimalWaterButton.Click += new System.EventHandler(this.giveAnimalWaterButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.playAnimalSoundBox);
            this.panel2.Controls.Add(this.InteractWithAnimalButton);
            this.panel2.Controls.Add(this.restAnimalButton);
            this.panel2.Controls.Add(this.AnimalTypeComboBox);
            this.panel2.Controls.Add(this.AnimalNameComboBox);
            this.panel2.Controls.Add(this.giveAnimalWaterButton);
            this.panel2.Controls.Add(this.animalTypeLable);
            this.panel2.Controls.Add(this.feedAnimalButton);
            this.panel2.Controls.Add(this.animalNameLabel);
            this.panel2.Location = new System.Drawing.Point(15, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 417);
            this.panel2.TabIndex = 9;
            // 
            // playAnimalSoundBox
            // 
            this.playAnimalSoundBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.playAnimalSoundBox.AutoSize = true;
            this.playAnimalSoundBox.Location = new System.Drawing.Point(212, 309);
            this.playAnimalSoundBox.Name = "playAnimalSoundBox";
            this.playAnimalSoundBox.Size = new System.Drawing.Size(91, 23);
            this.playAnimalSoundBox.TabIndex = 13;
            this.playAnimalSoundBox.Text = "Listen to Animal";
            this.playAnimalSoundBox.UseVisualStyleBackColor = true;
            this.playAnimalSoundBox.CheckedChanged += new System.EventHandler(this.playAnimalSoundBox_CheckedChanged);
            // 
            // InteractWithAnimalButton
            // 
            this.InteractWithAnimalButton.Location = new System.Drawing.Point(265, 338);
            this.InteractWithAnimalButton.Name = "InteractWithAnimalButton";
            this.InteractWithAnimalButton.Size = new System.Drawing.Size(124, 23);
            this.InteractWithAnimalButton.TabIndex = 12;
            this.InteractWithAnimalButton.Text = "Interact with Animal";
            this.InteractWithAnimalButton.UseVisualStyleBackColor = true;
            this.InteractWithAnimalButton.Click += new System.EventHandler(this.InteractWithAnimalButton_Click);
            // 
            // restAnimalButton
            // 
            this.restAnimalButton.Location = new System.Drawing.Point(146, 338);
            this.restAnimalButton.Name = "restAnimalButton";
            this.restAnimalButton.Size = new System.Drawing.Size(105, 23);
            this.restAnimalButton.TabIndex = 11;
            this.restAnimalButton.Text = "Rest";
            this.restAnimalButton.UseVisualStyleBackColor = true;
            this.restAnimalButton.Click += new System.EventHandler(this.restAnimalButton_Click);
            // 
            // AnimalTypeComboBox
            // 
            this.AnimalTypeComboBox.FormattingEnabled = true;
            this.AnimalTypeComboBox.Location = new System.Drawing.Point(207, 33);
            this.AnimalTypeComboBox.Name = "AnimalTypeComboBox";
            this.AnimalTypeComboBox.Size = new System.Drawing.Size(130, 21);
            this.AnimalTypeComboBox.TabIndex = 10;
            this.AnimalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AnimalTypeComboBox_SelectedIndexChanged);
            // 
            // animalsBindingSource5
            // 
            this.animalsBindingSource5.DataMember = "animals";
            this.animalsBindingSource5.DataSource = this.animalsDataSet;
            // 
            // animalsDataSet
            // 
            this.animalsDataSet.DataSetName = "animalsDataSet";
            this.animalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AnimalNameComboBox
            // 
            this.AnimalNameComboBox.FormattingEnabled = true;
            this.AnimalNameComboBox.Location = new System.Drawing.Point(207, 106);
            this.AnimalNameComboBox.Name = "AnimalNameComboBox";
            this.AnimalNameComboBox.Size = new System.Drawing.Size(130, 21);
            this.AnimalNameComboBox.TabIndex = 9;
            this.AnimalNameComboBox.SelectedIndexChanged += new System.EventHandler(this.AnimalNameComboBox_SelectedIndexChanged);
            // 
            // animalsBindingSource6
            // 
            this.animalsBindingSource6.DataMember = "animals";
            this.animalsBindingSource6.DataSource = this.animalsDataSet;
            // 
            // animalsBindingSource2
            // 
            this.animalsBindingSource2.DataMember = "animals";
            this.animalsBindingSource2.DataSource = this.animalsDataSetBindingSource;
            // 
            // animalsDataSetBindingSource
            // 
            this.animalsDataSetBindingSource.DataSource = this.animalsDataSet;
            this.animalsDataSetBindingSource.Position = 0;
            // 
            // animalsBindingSource1
            // 
            this.animalsBindingSource1.DataMember = "animals";
            this.animalsBindingSource1.DataSource = this.animalsDataSet;
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
            // animalsBindingSource3
            // 
            this.animalsBindingSource3.DataMember = "animals";
            this.animalsBindingSource3.DataSource = this.animalsDataSet;
            // 
            // animalsBindingSource4
            // 
            this.animalsBindingSource4.DataMember = "animals";
            this.animalsBindingSource4.DataSource = this.animalsDataSetBindingSource;
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
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label animalTypeLable;
        private System.Windows.Forms.Label animalNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tendToAnAnimalLabel;
        private System.Windows.Forms.Button feedAnimalButton;
        private System.Windows.Forms.Button giveAnimalWaterButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox AnimalNameComboBox;
        private animalsDataSet animalsDataSet;
        private System.Windows.Forms.BindingSource animalsDataSetBindingSource;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private animalsDataSetTableAdapters.animalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.BindingSource animalsBindingSource1;
        private System.Windows.Forms.ComboBox AnimalTypeComboBox;
        private System.Windows.Forms.BindingSource animalsBindingSource2;
        private System.Windows.Forms.Button InteractWithAnimalButton;
        private System.Windows.Forms.Button restAnimalButton;
        private System.Windows.Forms.CheckBox playAnimalSoundBox;
        private System.Windows.Forms.BindingSource animalsBindingSource3;
        private System.Windows.Forms.BindingSource animalsBindingSource5;
        private System.Windows.Forms.BindingSource animalsBindingSource6;
        private System.Windows.Forms.BindingSource animalsBindingSource4;
    }
}
