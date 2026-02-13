namespace Database
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            this.buttonChange1 = new System.Windows.Forms.Button();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDelete2 = new System.Windows.Forms.Button();
            this.buttonChange2 = new System.Windows.Forms.Button();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDelete3 = new System.Windows.Forms.Button();
            this.buttonChange3 = new System.Windows.Forms.Button();
            this.buttonAdd3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxSNP = new System.Windows.Forms.TextBox();
            this.buttonDelete4 = new System.Windows.Forms.Button();
            this.buttonChange4 = new System.Windows.Forms.Button();
            this.buttonAdd4 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 286);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 352);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDelete1);
            this.tabPage1.Controls.Add(this.buttonChange1);
            this.tabPage1.Controls.Add(this.buttonAdd1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Абоненты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Location = new System.Drawing.Point(170, 295);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete1.TabIndex = 4;
            this.buttonDelete1.Text = "Удалить";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
            // 
            // buttonChange1
            // 
            this.buttonChange1.Location = new System.Drawing.Point(89, 295);
            this.buttonChange1.Name = "buttonChange1";
            this.buttonChange1.Size = new System.Drawing.Size(75, 23);
            this.buttonChange1.TabIndex = 3;
            this.buttonChange1.Text = "Изменить";
            this.buttonChange1.UseVisualStyleBackColor = true;
            this.buttonChange1.Click += new System.EventHandler(this.buttonChange1_Click);
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Location = new System.Drawing.Point(8, 295);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd1.TabIndex = 2;
            this.buttonAdd1.Text = "Добавить";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDelete2);
            this.tabPage2.Controls.Add(this.buttonChange2);
            this.tabPage2.Controls.Add(this.buttonAdd2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Контакты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDelete2
            // 
            this.buttonDelete2.Location = new System.Drawing.Point(170, 295);
            this.buttonDelete2.Name = "buttonDelete2";
            this.buttonDelete2.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete2.TabIndex = 7;
            this.buttonDelete2.Text = "Удалить";
            this.buttonDelete2.UseVisualStyleBackColor = true;
            this.buttonDelete2.Click += new System.EventHandler(this.buttonDelete2_Click);
            // 
            // buttonChange2
            // 
            this.buttonChange2.Location = new System.Drawing.Point(89, 295);
            this.buttonChange2.Name = "buttonChange2";
            this.buttonChange2.Size = new System.Drawing.Size(75, 23);
            this.buttonChange2.TabIndex = 6;
            this.buttonChange2.Text = "Изменить";
            this.buttonChange2.UseVisualStyleBackColor = true;
            this.buttonChange2.Click += new System.EventHandler(this.buttonChange2_Click);
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Location = new System.Drawing.Point(8, 295);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd2.TabIndex = 5;
            this.buttonAdd2.Text = "Добавить";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(600, 286);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDelete3);
            this.tabPage3.Controls.Add(this.buttonChange3);
            this.tabPage3.Controls.Add(this.buttonAdd3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(606, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Провайдеры";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDelete3
            // 
            this.buttonDelete3.Location = new System.Drawing.Point(170, 295);
            this.buttonDelete3.Name = "buttonDelete3";
            this.buttonDelete3.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete3.TabIndex = 7;
            this.buttonDelete3.Text = "Удалить";
            this.buttonDelete3.UseVisualStyleBackColor = true;
            this.buttonDelete3.Click += new System.EventHandler(this.buttonDelete3_Click);
            // 
            // buttonChange3
            // 
            this.buttonChange3.Location = new System.Drawing.Point(89, 295);
            this.buttonChange3.Name = "buttonChange3";
            this.buttonChange3.Size = new System.Drawing.Size(75, 23);
            this.buttonChange3.TabIndex = 6;
            this.buttonChange3.Text = "Изменить";
            this.buttonChange3.UseVisualStyleBackColor = true;
            this.buttonChange3.Click += new System.EventHandler(this.buttonChange3_Click);
            // 
            // buttonAdd3
            // 
            this.buttonAdd3.Location = new System.Drawing.Point(8, 295);
            this.buttonAdd3.Name = "buttonAdd3";
            this.buttonAdd3.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd3.TabIndex = 5;
            this.buttonAdd3.Text = "Добавить";
            this.buttonAdd3.UseVisualStyleBackColor = true;
            this.buttonAdd3.Click += new System.EventHandler(this.buttonAdd3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(606, 289);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.textBoxAddress);
            this.tabPage4.Controls.Add(this.textBoxPhone);
            this.tabPage4.Controls.Add(this.textBoxSNP);
            this.tabPage4.Controls.Add(this.buttonDelete4);
            this.tabPage4.Controls.Add(this.buttonChange4);
            this.tabPage4.Controls.Add(this.buttonAdd4);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(606, 326);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Телефонный справочник";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тел. номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(430, 303);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(168, 20);
            this.textBoxAddress.TabIndex = 8;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(430, 277);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(168, 20);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxSNP
            // 
            this.textBoxSNP.Location = new System.Drawing.Point(430, 251);
            this.textBoxSNP.Name = "textBoxSNP";
            this.textBoxSNP.Size = new System.Drawing.Size(168, 20);
            this.textBoxSNP.TabIndex = 8;
            this.textBoxSNP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonDelete4
            // 
            this.buttonDelete4.Location = new System.Drawing.Point(168, 249);
            this.buttonDelete4.Name = "buttonDelete4";
            this.buttonDelete4.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete4.TabIndex = 7;
            this.buttonDelete4.Text = "Удалить";
            this.buttonDelete4.UseVisualStyleBackColor = true;
            this.buttonDelete4.Click += new System.EventHandler(this.buttonDelete4_Click);
            // 
            // buttonChange4
            // 
            this.buttonChange4.Location = new System.Drawing.Point(87, 249);
            this.buttonChange4.Name = "buttonChange4";
            this.buttonChange4.Size = new System.Drawing.Size(75, 23);
            this.buttonChange4.TabIndex = 6;
            this.buttonChange4.Text = "Изменить";
            this.buttonChange4.UseVisualStyleBackColor = true;
            this.buttonChange4.Click += new System.EventHandler(this.buttonChange4_Click);
            // 
            // buttonAdd4
            // 
            this.buttonAdd4.Location = new System.Drawing.Point(6, 249);
            this.buttonAdd4.Name = "buttonAdd4";
            this.buttonAdd4.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd4.TabIndex = 5;
            this.buttonAdd4.Text = "Добавить";
            this.buttonAdd4.UseVisualStyleBackColor = true;
            this.buttonAdd4.Click += new System.EventHandler(this.buttonAdd4_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(606, 243);
            this.dataGridView4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 352);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Телефонный справочник";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button buttonDelete1;
        private System.Windows.Forms.Button buttonChange1;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.Button buttonDelete2;
        private System.Windows.Forms.Button buttonChange2;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.Button buttonDelete3;
        private System.Windows.Forms.Button buttonChange3;
        private System.Windows.Forms.Button buttonAdd3;
        private System.Windows.Forms.Button buttonDelete4;
        private System.Windows.Forms.Button buttonChange4;
        private System.Windows.Forms.Button buttonAdd4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxSNP;
    }
}

