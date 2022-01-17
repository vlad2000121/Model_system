
namespace _1_лаб_модел
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAB1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAB2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statysBC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.statusAB1,
            this.statusAB2,
            this.statusBC1,
            this.statysBC2,
            this.statusA,
            this.statusB,
            this.statusC});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            // 
            // statusAB1
            // 
            this.statusAB1.HeaderText = "Статус АВ1";
            this.statusAB1.Name = "statusAB1";
            // 
            // statusAB2
            // 
            this.statusAB2.HeaderText = "Статус AB2";
            this.statusAB2.Name = "statusAB2";
            // 
            // statusBC1
            // 
            this.statusBC1.HeaderText = "Статус BC1";
            this.statusBC1.Name = "statusBC1";
            // 
            // statysBC2
            // 
            this.statysBC2.HeaderText = "Статус BC2";
            this.statysBC2.Name = "statysBC2";
            // 
            // statusA
            // 
            this.statusA.HeaderText = "накопитель А";
            this.statusA.Name = "statusA";
            // 
            // statusB
            // 
            this.statusB.HeaderText = "накопитель B";
            this.statusB.Name = "statusB";
            // 
            // statusC
            // 
            this.statusC.HeaderText = "накопитель C";
            this.statusC.Name = "statusC";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Time;
        public System.Windows.Forms.DataGridViewTextBoxColumn statusAB1;
        public System.Windows.Forms.DataGridViewTextBoxColumn statusAB2;
        public System.Windows.Forms.DataGridViewTextBoxColumn statusBC1;
        public System.Windows.Forms.DataGridViewTextBoxColumn statysBC2;
        public System.Windows.Forms.DataGridViewTextBoxColumn statusA;
        public System.Windows.Forms.DataGridViewTextBoxColumn statusB;
        public System.Windows.Forms.DataGridViewTextBoxColumn statusC;
    }
}