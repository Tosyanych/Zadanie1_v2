
namespace Zadanie_v2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.FiboTextSum = new System.Windows.Forms.TextBox();
            this.FiboTextNum = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.searchEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wordLenght = new System.Windows.Forms.NumericUpDown();
            this.listFound = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTipSave = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOpen = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.FiboTextSum);
            this.tabPage1.Controls.Add(this.FiboTextNum);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FiboTextSum
            // 
            this.FiboTextSum.Location = new System.Drawing.Point(8, 98);
            this.FiboTextSum.Name = "FiboTextSum";
            this.FiboTextSum.ReadOnly = true;
            this.FiboTextSum.Size = new System.Drawing.Size(160, 20);
            this.FiboTextSum.TabIndex = 6;
            // 
            // FiboTextNum
            // 
            this.FiboTextNum.Location = new System.Drawing.Point(8, 60);
            this.FiboTextNum.Name = "FiboTextNum";
            this.FiboTextNum.ReadOnly = true;
            this.FiboTextNum.Size = new System.Drawing.Size(160, 20);
            this.FiboTextNum.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 22);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSave);
            this.tabPage2.Controls.Add(this.buttonOpen);
            this.tabPage2.Controls.Add(this.searchEmail);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.wordLenght);
            this.tabPage2.Controls.Add(this.listFound);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(370, 105);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.toolTipSave.SetToolTip(this.buttonSave, "Сохранить результат поиска в файл.\r\n");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(370, 74);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Загрузить";
            this.toolTipOpen.SetToolTip(this.buttonOpen, "Загрузить текст из файла.");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // searchEmail
            // 
            this.searchEmail.Location = new System.Drawing.Point(370, 48);
            this.searchEmail.Name = "searchEmail";
            this.searchEmail.Size = new System.Drawing.Size(120, 20);
            this.searchEmail.TabIndex = 4;
            this.searchEmail.Text = "Поиск E-mail адресов";
            this.searchEmail.TextChanged += new System.EventHandler(this.searchEmail_TextChanged);
            this.searchEmail.Enter += new System.EventHandler(this.searchEmail_Enter);
            this.searchEmail.Leave += new System.EventHandler(this.searchEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Максимальная длина слов:";
            // 
            // wordLenght
            // 
            this.wordLenght.Location = new System.Drawing.Point(370, 22);
            this.wordLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wordLenght.Name = "wordLenght";
            this.wordLenght.Size = new System.Drawing.Size(120, 20);
            this.wordLenght.TabIndex = 2;
            this.wordLenght.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wordLenght.ValueChanged += new System.EventHandler(this.wordLenght_ValueChanged);
            // 
            // listFound
            // 
            this.listFound.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listFound.FormattingEnabled = true;
            this.listFound.Location = new System.Drawing.Point(364, 176);
            this.listFound.Name = "listFound";
            this.listFound.Size = new System.Drawing.Size(243, 160);
            this.listFound.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 333);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 365);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестовое задание";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordLenght)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FiboTextSum;
        private System.Windows.Forms.TextBox FiboTextNum;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolTip toolTipSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ToolTip toolTipOpen;
        private System.Windows.Forms.TextBox searchEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown wordLenght;
        private System.Windows.Forms.ListBox listFound;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

