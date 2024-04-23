namespace VirtualZooManagementSystem
{
    partial class SeeAllAnimals
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.seeAllAnimalsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataSet = new VirtualZooManagementSystem.animalsDataSet();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsTableAdapter = new VirtualZooManagementSystem.animalsDataSetTableAdapters.animalsTableAdapter();
            this.animalsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.seeAllAnimalsLabel);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 98);
            this.panel1.TabIndex = 0;
            // 
            // seeAllAnimalsLabel
            // 
            this.seeAllAnimalsLabel.AutoSize = true;
            this.seeAllAnimalsLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAllAnimalsLabel.Location = new System.Drawing.Point(166, 34);
            this.seeAllAnimalsLabel.Name = "seeAllAnimalsLabel";
            this.seeAllAnimalsLabel.Size = new System.Drawing.Size(216, 33);
            this.seeAllAnimalsLabel.TabIndex = 0;
            this.seeAllAnimalsLabel.Text = "See All Animals";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(15, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 411);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.animalTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animalsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(49, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalTypeDataGridViewTextBoxColumn
            // 
            this.animalTypeDataGridViewTextBoxColumn.DataPropertyName = "AnimalType";
            this.animalTypeDataGridViewTextBoxColumn.HeaderText = "AnimalType";
            this.animalTypeDataGridViewTextBoxColumn.Name = "animalTypeDataGridViewTextBoxColumn";
            this.animalTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalsBindingSource1
            // 
            this.animalsBindingSource1.DataMember = "animals";
            this.animalsBindingSource1.DataSource = this.animalsDataSet;
            // 
            // animalsDataSet
            // 
            this.animalsDataSet.DataSetName = "animalsDataSet";
            this.animalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "animals";
            this.animalsBindingSource.DataSource = this.animalsDataSet;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // animalsDataSetBindingSource
            // 
            this.animalsDataSetBindingSource.DataSource = this.animalsDataSet;
            this.animalsDataSetBindingSource.Position = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(573, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // SeeAllAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SeeAllAnimals";
            this.Size = new System.Drawing.Size(573, 569);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataSetBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label seeAllAnimalsLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private animalsDataSet animalsDataSet;
        private animalsDataSetTableAdapters.animalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource animalsBindingSource1;
        private System.Windows.Forms.BindingSource animalsDataSetBindingSource;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}
