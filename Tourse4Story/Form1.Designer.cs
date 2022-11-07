namespace UserStory4Tours
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Correction = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeliteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Program = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddTool = new System.Windows.Forms.ToolStripButton();
            this.ChangeTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeliteTool = new System.Windows.Forms.ToolStripButton();
            this.ToursGridViev = new System.Windows.Forms.DataGridView();
            this.DirectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDepartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberNightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostVacColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberVacColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wi_FiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountAllColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NumberToursStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumerToursSurcharges = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalAmountSurcharges = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToursGridViev)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Correction,
            this.Program});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Correction
            // 
            this.Correction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.ChangeMenu,
            this.toolStripSeparator1,
            this.DeliteMenu});
            this.Correction.Name = "Correction";
            this.Correction.Size = new System.Drawing.Size(59, 20);
            this.Correction.Text = "Правка";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(128, 22);
            this.AddMenu.Text = "Добавить";
            this.AddMenu.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Enabled = false;
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(128, 22);
            this.ChangeMenu.Text = "Изменить";
            this.ChangeMenu.Click += new System.EventHandler(this.ChangeMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // DeliteMenu
            // 
            this.DeliteMenu.Enabled = false;
            this.DeliteMenu.Name = "DeliteMenu";
            this.DeliteMenu.Size = new System.Drawing.Size(128, 22);
            this.DeliteMenu.Text = "Удалить";
            this.DeliteMenu.Click += new System.EventHandler(this.DeliteMenu_Click);
            // 
            // Program
            // 
            this.Program.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info});
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(94, 20);
            this.Program.Text = "О программе";
            // 
            // Info
            // 
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(148, 22);
            this.Info.Text = "Информация";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTool,
            this.ChangeTool,
            this.toolStripSeparator2,
            this.DeliteTool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddTool
            // 
            this.AddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTool.Name = "AddTool";
            this.AddTool.Size = new System.Drawing.Size(63, 22);
            this.AddTool.Text = "Добавить";
            this.AddTool.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // ChangeTool
            // 
            this.ChangeTool.Enabled = false;
            this.ChangeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeTool.Name = "ChangeTool";
            this.ChangeTool.Size = new System.Drawing.Size(65, 22);
            this.ChangeTool.Text = "Изменить";
            this.ChangeTool.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DeliteTool
            // 
            this.DeliteTool.Enabled = false;
            this.DeliteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeliteTool.Name = "DeliteTool";
            this.DeliteTool.Size = new System.Drawing.Size(55, 22);
            this.DeliteTool.Text = "Удалить";
            this.DeliteTool.Click += new System.EventHandler(this.DeliteTool_Click);
            // 
            // ToursGridViev
            // 
            this.ToursGridViev.AllowUserToAddRows = false;
            this.ToursGridViev.AllowUserToDeleteRows = false;
            this.ToursGridViev.AllowUserToResizeColumns = false;
            this.ToursGridViev.AllowUserToResizeRows = false;
            this.ToursGridViev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToursGridViev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirectColumn,
            this.DateDepartColumn,
            this.NumberNightColumn,
            this.CostVacColumn,
            this.NumberVacColumn,
            this.Wi_FiColumn,
            this.SurColumn,
            this.AmountAllColumn});
            this.ToursGridViev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToursGridViev.Location = new System.Drawing.Point(0, 49);
            this.ToursGridViev.MultiSelect = false;
            this.ToursGridViev.Name = "ToursGridViev";
            this.ToursGridViev.ReadOnly = true;
            this.ToursGridViev.Size = new System.Drawing.Size(810, 414);
            this.ToursGridViev.TabIndex = 2;
            this.ToursGridViev.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ToursGridViev_CellFormatting);
            this.ToursGridViev.SelectionChanged += new System.EventHandler(this.ToursGridViev_SelectionChanged);
            // 
            // DirectColumn
            // 
            this.DirectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirectColumn.DataPropertyName = "direction";
            this.DirectColumn.HeaderText = "Направление";
            this.DirectColumn.Name = "DirectColumn";
            this.DirectColumn.ReadOnly = true;
            // 
            // DateDepartColumn
            // 
            this.DateDepartColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateDepartColumn.DataPropertyName = "DateDeparture";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DateDepartColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.DateDepartColumn.FillWeight = 110F;
            this.DateDepartColumn.HeaderText = "Дата вылета";
            this.DateDepartColumn.MinimumWidth = 50;
            this.DateDepartColumn.Name = "DateDepartColumn";
            this.DateDepartColumn.ReadOnly = true;
            // 
            // NumberNightColumn
            // 
            this.NumberNightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberNightColumn.DataPropertyName = "NumberNight";
            this.NumberNightColumn.HeaderText = "Кол-во ночей";
            this.NumberNightColumn.Name = "NumberNightColumn";
            this.NumberNightColumn.ReadOnly = true;
            // 
            // CostVacColumn
            // 
            this.CostVacColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CostVacColumn.DataPropertyName = "CostVac";
            this.CostVacColumn.HeaderText = "Стоимость за отдыхающего";
            this.CostVacColumn.Name = "CostVacColumn";
            this.CostVacColumn.ReadOnly = true;
            // 
            // NumberVacColumn
            // 
            this.NumberVacColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberVacColumn.DataPropertyName = "NumberVac";
            this.NumberVacColumn.HeaderText = "Кол-во отдыхающих";
            this.NumberVacColumn.Name = "NumberVacColumn";
            this.NumberVacColumn.ReadOnly = true;
            // 
            // Wi_FiColumn
            // 
            this.Wi_FiColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Wi_FiColumn.DataPropertyName = "Wi_Fi";
            this.Wi_FiColumn.HeaderText = "Наличие Wi-Fi";
            this.Wi_FiColumn.Name = "Wi_FiColumn";
            this.Wi_FiColumn.ReadOnly = true;
            // 
            // SurColumn
            // 
            this.SurColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurColumn.DataPropertyName = "Surcharges";
            this.SurColumn.HeaderText = "Доплаты";
            this.SurColumn.Name = "SurColumn";
            this.SurColumn.ReadOnly = true;
            // 
            // AmountAllColumn
            // 
            this.AmountAllColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountAllColumn.DataPropertyName = "AmountAllColumn";
            this.AmountAllColumn.HeaderText = "Общая стоимость";
            this.AmountAllColumn.Name = "AmountAllColumn";
            this.AmountAllColumn.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumberToursStatus,
            this.TotalAmount,
            this.NumerToursSurcharges,
            this.TotalAmountSurcharges});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(810, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NumberToursStatus
            // 
            this.NumberToursStatus.Name = "NumberToursStatus";
            this.NumberToursStatus.Size = new System.Drawing.Size(89, 17);
            this.NumberToursStatus.Text = "Кол-во туров 0";
            // 
            // TotalAmount
            // 
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(94, 17);
            this.TotalAmount.Text = "Общая сумма 0";
            // 
            // NumerToursSurcharges
            // 
            this.NumerToursSurcharges.Name = "NumerToursSurcharges";
            this.NumerToursSurcharges.Size = new System.Drawing.Size(161, 17);
            this.NumerToursSurcharges.Text = "Кол-во туров с доплатами 0";
            // 
            // TotalAmountSurcharges
            // 
            this.TotalAmountSurcharges.Name = "TotalAmountSurcharges";
            this.TotalAmountSurcharges.Size = new System.Drawing.Size(135, 17);
            this.TotalAmountSurcharges.Text = "Общая сумма доплат 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 463);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ToursGridViev);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Горящие туры";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToursGridViev)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Correction;
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeliteMenu;
        private System.Windows.Forms.ToolStripMenuItem Program;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddTool;
        private System.Windows.Forms.ToolStripButton ChangeTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeliteTool;
        private System.Windows.Forms.DataGridView ToursGridViev;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NumberToursStatus;
        private System.Windows.Forms.ToolStripStatusLabel TotalAmount;
        private System.Windows.Forms.ToolStripStatusLabel NumerToursSurcharges;
        private System.Windows.Forms.ToolStripStatusLabel TotalAmountSurcharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDepartColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberNightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostVacColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberVacColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wi_FiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountAllColumn;
    }
}

