
namespace EquipmentRepairRequests
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
            this.DataViewer = new System.Windows.Forms.DataGridView();
            this.ApplicationNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataViewer
            // 
            this.DataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationNum,
            this.Equipment,
            this.Client,
            this.Status,
            this.DateCreate,
            this.Description});
            this.DataViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataViewer.Location = new System.Drawing.Point(12, 27);
            this.DataViewer.MultiSelect = false;
            this.DataViewer.Name = "DataViewer";
            this.DataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataViewer.Size = new System.Drawing.Size(776, 346);
            this.DataViewer.TabIndex = 0;
            this.DataViewer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataViewer_CellFormatting);
            // 
            // ApplicationNum
            // 
            this.ApplicationNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ApplicationNum.HeaderText = "№ Заявки";
            this.ApplicationNum.Name = "ApplicationNum";
            this.ApplicationNum.Width = 77;
            // 
            // Equipment
            // 
            this.Equipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Equipment.HeaderText = "Оборудование";
            this.Equipment.Name = "Equipment";
            // 
            // Client
            // 
            this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client.HeaderText = "ФИО клиента";
            this.Client.Name = "Client";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // DateCreate
            // 
            this.DateCreate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCreate.HeaderText = "Дата создания";
            this.DateCreate.Name = "DateCreate";
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отобразитьБДToolStripMenuItem,
            this.создатьЗаявкуToolStripMenuItem,
            this.удалитьЗаявкуToolStripMenuItem,
            this.редактироватьЗаявкуToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // отобразитьБДToolStripMenuItem
            // 
            this.отобразитьБДToolStripMenuItem.Name = "отобразитьБДToolStripMenuItem";
            this.отобразитьБДToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.отобразитьБДToolStripMenuItem.Text = "Отобразить БД";
            this.отобразитьБДToolStripMenuItem.Click += new System.EventHandler(this.отобразитьБДToolStripMenuItem_Click);
            // 
            // создатьЗаявкуToolStripMenuItem
            // 
            this.создатьЗаявкуToolStripMenuItem.Name = "создатьЗаявкуToolStripMenuItem";
            this.создатьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.создатьЗаявкуToolStripMenuItem.Text = "Создать заявку";
            this.создатьЗаявкуToolStripMenuItem.Click += new System.EventHandler(this.создатьЗаявкуToolStripMenuItem_Click);
            // 
            // удалитьЗаявкуToolStripMenuItem
            // 
            this.удалитьЗаявкуToolStripMenuItem.Name = "удалитьЗаявкуToolStripMenuItem";
            this.удалитьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.удалитьЗаявкуToolStripMenuItem.Text = "Удалить заявку";
            this.удалитьЗаявкуToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаявкуToolStripMenuItem_Click);
            // 
            // редактироватьЗаявкуToolStripMenuItem
            // 
            this.редактироватьЗаявкуToolStripMenuItem.Name = "редактироватьЗаявкуToolStripMenuItem";
            this.редактироватьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.редактироватьЗаявкуToolStripMenuItem.Text = "Редактировать заявку";
            this.редактироватьЗаявкуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьЗаявкуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создательToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // создательToolStripMenuItem
            // 
            this.создательToolStripMenuItem.Name = "создательToolStripMenuItem";
            this.создательToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.создательToolStripMenuItem.Text = "Создатель";
            this.создательToolStripMenuItem.Click += new System.EventHandler(this.создательToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(12, 379);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(223, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Скрыть Выполненные Заявки";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DataViewer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 446);
            this.MinimumSize = new System.Drawing.Size(816, 446);
            this.Name = "Form1";
            this.Text = "Учёт заявок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataViewer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создательToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

