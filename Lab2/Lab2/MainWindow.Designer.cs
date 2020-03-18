namespace Lab2
{
  partial class MainWindow
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.Start = new System.Windows.Forms.TextBox();
      this.Result = new System.Windows.Forms.TextBox();
      this.Type = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.Action = new System.Windows.Forms.ComboBox();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.FileMenu = new System.Windows.Forms.ToolStripDropDownButton();
      this.ToolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripSave = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripClose = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.ToolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.Switch = new System.Windows.Forms.Button();
      this.Calc = new System.Windows.Forms.Button();
      this.Delete = new System.Windows.Forms.PictureBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.Shift = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.Progress = new System.Windows.Forms.ProgressBar();
      this.KeyWord = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Delete)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Shift)).BeginInit();
      this.SuspendLayout();
      // 
      // Start
      // 
      this.Start.Location = new System.Drawing.Point(47, 97);
      this.Start.Multiline = true;
      this.Start.Name = "Start";
      this.Start.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Start.Size = new System.Drawing.Size(330, 363);
      this.Start.TabIndex = 0;
      // 
      // Result
      // 
      this.Result.BackColor = System.Drawing.SystemColors.Window;
      this.Result.Location = new System.Drawing.Point(440, 97);
      this.Result.Multiline = true;
      this.Result.Name = "Result";
      this.Result.ReadOnly = true;
      this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Result.Size = new System.Drawing.Size(330, 363);
      this.Result.TabIndex = 1;
      // 
      // Type
      // 
      this.Type.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.Type.Enabled = false;
      this.Type.FormattingEnabled = true;
      this.Type.Items.AddRange(new object[] {
            "DES",
            "Шифр Цезаря"});
      this.Type.Location = new System.Drawing.Point(157, 68);
      this.Type.Name = "Type";
      this.Type.Size = new System.Drawing.Size(101, 21);
      this.Type.TabIndex = 2;
      this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(44, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Выберите шифр:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(44, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(107, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Выберите действие";
      // 
      // Action
      // 
      this.Action.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.Action.FormattingEnabled = true;
      this.Action.Items.AddRange(new object[] {
            "Зашифровать",
            "Расшифровать"});
      this.Action.Location = new System.Drawing.Point(157, 38);
      this.Action.Name = "Action";
      this.Action.Size = new System.Drawing.Size(101, 21);
      this.Action.TabIndex = 4;
      this.Action.SelectedIndexChanged += new System.EventHandler(this.Action_SelectedIndexChanged);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.toolStripDropDownButton1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(820, 25);
      this.toolStrip1.TabIndex = 6;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // FileMenu
      // 
      this.FileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripOpen,
            this.ToolStripSave,
            this.ToolStripClose});
      this.FileMenu.Image = ((System.Drawing.Image)(resources.GetObject("FileMenu.Image")));
      this.FileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.FileMenu.Name = "FileMenu";
      this.FileMenu.Size = new System.Drawing.Size(49, 22);
      this.FileMenu.Text = "Файл";
      // 
      // ToolStripOpen
      // 
      this.ToolStripOpen.Enabled = false;
      this.ToolStripOpen.Name = "ToolStripOpen";
      this.ToolStripOpen.Size = new System.Drawing.Size(133, 22);
      this.ToolStripOpen.Text = "Открыть";
      this.ToolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
      // 
      // ToolStripSave
      // 
      this.ToolStripSave.Enabled = false;
      this.ToolStripSave.Name = "ToolStripSave";
      this.ToolStripSave.Size = new System.Drawing.Size(133, 22);
      this.ToolStripSave.Text = "Сохранить";
      this.ToolStripSave.Click += new System.EventHandler(this.ToolStripSave_Click);
      // 
      // ToolStripClose
      // 
      this.ToolStripClose.Name = "ToolStripClose";
      this.ToolStripClose.Size = new System.Drawing.Size(133, 22);
      this.ToolStripClose.Text = "Выход";
      this.ToolStripClose.Click += new System.EventHandler(this.ToolStripClose_Click);
      // 
      // toolStripDropDownButton1
      // 
      this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripAbout});
      this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 22);
      this.toolStripDropDownButton1.Text = "Справка";
      // 
      // ToolStripAbout
      // 
      this.ToolStripAbout.Name = "ToolStripAbout";
      this.ToolStripAbout.Size = new System.Drawing.Size(149, 22);
      this.ToolStripAbout.Text = "О программе";
      this.ToolStripAbout.Click += new System.EventHandler(this.ToolStripAbout_Click);
      // 
      // Switch
      // 
      this.Switch.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Switch.Location = new System.Drawing.Point(393, 267);
      this.Switch.Name = "Switch";
      this.Switch.Size = new System.Drawing.Size(30, 24);
      this.Switch.TabIndex = 7;
      this.Switch.Text = "<->";
      this.Switch.UseVisualStyleBackColor = true;
      this.Switch.Click += new System.EventHandler(this.Switch_Click);
      // 
      // Calc
      // 
      this.Calc.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Calc.Enabled = false;
      this.Calc.Location = new System.Drawing.Point(603, 42);
      this.Calc.Name = "Calc";
      this.Calc.Size = new System.Drawing.Size(167, 29);
      this.Calc.TabIndex = 9;
      this.Calc.Text = "Выполнить";
      this.Calc.UseVisualStyleBackColor = true;
      this.Calc.Click += new System.EventHandler(this.Calc_Click);
      // 
      // Delete
      // 
      this.Delete.BackColor = System.Drawing.Color.Transparent;
      this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
      this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
      this.Delete.Location = new System.Drawing.Point(384, 408);
      this.Delete.Name = "Delete";
      this.Delete.Size = new System.Drawing.Size(50, 52);
      this.Delete.TabIndex = 10;
      this.Delete.TabStop = false;
      this.toolTip1.SetToolTip(this.Delete, "Очистить содержимое правого окна\r\n");
      this.Delete.Click += new System.EventHandler(this.Delete_Click);
      // 
      // Shift
      // 
      this.Shift.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Shift.Enabled = false;
      this.Shift.Location = new System.Drawing.Point(340, 68);
      this.Shift.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
      this.Shift.Name = "Shift";
      this.Shift.Size = new System.Drawing.Size(37, 20);
      this.Shift.TabIndex = 11;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(285, 47);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(92, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Выберите сдвиг:";
      // 
      // Progress
      // 
      this.Progress.Location = new System.Drawing.Point(603, 76);
      this.Progress.Name = "Progress";
      this.Progress.Size = new System.Drawing.Size(167, 12);
      this.Progress.TabIndex = 13;
      // 
      // KeyWord
      // 
      this.KeyWord.Enabled = false;
      this.KeyWord.Location = new System.Drawing.Point(440, 64);
      this.KeyWord.Name = "KeyWord";
      this.KeyWord.Size = new System.Drawing.Size(100, 20);
      this.KeyWord.TabIndex = 14;
      this.KeyWord.Text = "A";
      this.KeyWord.Visible = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(437, 47);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "Ключевое слово";
      this.label4.Visible = false;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(820, 483);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.KeyWord);
      this.Controls.Add(this.Progress);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.Shift);
      this.Controls.Add(this.Delete);
      this.Controls.Add(this.Calc);
      this.Controls.Add(this.Switch);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Action);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Type);
      this.Controls.Add(this.Result);
      this.Controls.Add(this.Start);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "MainWindow";
      this.Text = "Левинский Илья, гр. 484";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Delete)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Shift)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ComboBox Type;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox Action;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripDropDownButton FileMenu;
    private System.Windows.Forms.ToolStripMenuItem ToolStripOpen;
    private System.Windows.Forms.ToolStripMenuItem ToolStripSave;
    private System.Windows.Forms.ToolStripMenuItem ToolStripClose;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    private System.Windows.Forms.ToolStripMenuItem ToolStripAbout;
    private System.Windows.Forms.Button Switch;
    private System.Windows.Forms.Button Calc;
    private System.Windows.Forms.PictureBox Delete;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.NumericUpDown Shift;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox Start;
    private System.Windows.Forms.TextBox Result;
    private System.Windows.Forms.ProgressBar Progress;
    private System.Windows.Forms.TextBox KeyWord;
    private System.Windows.Forms.Label label4;
  }
}

