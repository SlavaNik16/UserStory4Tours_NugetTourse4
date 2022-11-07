namespace UserStory4Tours
{
    partial class ToursInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DirectionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericNumberNigth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CostVacBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericNumberVac = new System.Windows.Forms.NumericUpDown();
            this.Wi_FiChangheBox = new System.Windows.Forms.CheckBox();
            this.SurBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butCansel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberNigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberVac)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(152, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация об Tуре";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Направление";
            // 
            // DirectionBox
            // 
            this.DirectionBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DirectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DirectionBox.FormattingEnabled = true;
            this.DirectionBox.Location = new System.Drawing.Point(168, 110);
            this.DirectionBox.Name = "DirectionBox";
            this.DirectionBox.Size = new System.Drawing.Size(297, 21);
            this.DirectionBox.TabIndex = 2;
            this.DirectionBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DirectionBox_DrawItem);
            this.DirectionBox.SelectedIndexChanged += new System.EventHandler(this.DirectionBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата вылета";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кол-во ночей";
            // 
            // numericNumberNigth
            // 
            this.numericNumberNigth.Location = new System.Drawing.Point(243, 184);
            this.numericNumberNigth.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericNumberNigth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumberNigth.Name = "numericNumberNigth";
            this.numericNumberNigth.Size = new System.Drawing.Size(222, 20);
            this.numericNumberNigth.TabIndex = 6;
            this.numericNumberNigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumberNigth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumberNigth.ValueChanged += new System.EventHandler(this.numericNumberNigth_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(56, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Стоимость за отдыхающего(руб.)";
            // 
            // CostVacBox1
            // 
            this.CostVacBox1.Location = new System.Drawing.Point(75, 251);
            this.CostVacBox1.Name = "CostVacBox1";
            this.CostVacBox1.Size = new System.Drawing.Size(307, 20);
            this.CostVacBox1.TabIndex = 8;
            this.CostVacBox1.Text = "100";
            this.CostVacBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CostVacBox1.TextChanged += new System.EventHandler(this.CostVacBox1_TextChanged);
            this.CostVacBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostVacBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Кол-во отдыхающих";
            // 
            // numericNumberVac
            // 
            this.numericNumberVac.Location = new System.Drawing.Point(243, 295);
            this.numericNumberVac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumberVac.Name = "numericNumberVac";
            this.numericNumberVac.Size = new System.Drawing.Size(222, 20);
            this.numericNumberVac.TabIndex = 10;
            this.numericNumberVac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumberVac.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumberVac.ValueChanged += new System.EventHandler(this.numericNumberVac_ValueChanged);
            // 
            // Wi_FiChangheBox
            // 
            this.Wi_FiChangheBox.AutoSize = true;
            this.Wi_FiChangheBox.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wi_FiChangheBox.Location = new System.Drawing.Point(7, 325);
            this.Wi_FiChangheBox.Name = "Wi_FiChangheBox";
            this.Wi_FiChangheBox.Size = new System.Drawing.Size(186, 33);
            this.Wi_FiChangheBox.TabIndex = 12;
            this.Wi_FiChangheBox.Text = "Наличие Wi-Fi";
            this.Wi_FiChangheBox.UseVisualStyleBackColor = true;
            this.Wi_FiChangheBox.CheckedChanged += new System.EventHandler(this.Wi_FiChangheBox_CheckedChanged);
            // 
            // SurBox
            // 
            this.SurBox.Location = new System.Drawing.Point(168, 379);
            this.SurBox.Name = "SurBox";
            this.SurBox.Size = new System.Drawing.Size(297, 20);
            this.SurBox.TabIndex = 14;
            this.SurBox.Text = "0";
            this.SurBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SurBox.TextChanged += new System.EventHandler(this.SurBox_TextChanged);
            this.SurBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(2, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Доплаты(руб.)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.butCansel);
            this.panel2.Controls.Add(this.butSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 73);
            this.panel2.TabIndex = 15;
            // 
            // butCansel
            // 
            this.butCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCansel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCansel.Location = new System.Drawing.Point(348, 10);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(132, 51);
            this.butCansel.TabIndex = 1;
            this.butCansel.Text = "Отмена";
            this.butCansel.UseVisualStyleBackColor = true;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(12, 10);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(132, 51);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = false;
            // 
            // ToursInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SurBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Wi_FiChangheBox);
            this.Controls.Add(this.numericNumberVac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CostVacBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericNumberNigth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirectionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ToursInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавления туров";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberNigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberVac)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butCansel;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.ComboBox DirectionBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericNumberNigth;
        private System.Windows.Forms.TextBox CostVacBox1;
        private System.Windows.Forms.NumericUpDown numericNumberVac;
        private System.Windows.Forms.CheckBox Wi_FiChangheBox;
        private System.Windows.Forms.TextBox SurBox;
    }
}