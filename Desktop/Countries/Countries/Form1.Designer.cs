namespace Countries
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
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label код_страныLabel;
            System.Windows.Forms.Label столицаLabel;
            System.Windows.Forms.Label площадьLabel;
            System.Windows.Forms.Label населениеLabel;
            System.Windows.Forms.Label регионLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            код_страныLabel = new System.Windows.Forms.Label();
            столицаLabel = new System.Windows.Forms.Label();
            площадьLabel = new System.Windows.Forms.Label();
            населениеLabel = new System.Windows.Forms.Label();
            регионLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(70, 59);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 10;
            названиеLabel.Text = "Название:";
            // 
            // код_страныLabel
            // 
            код_страныLabel.AutoSize = true;
            код_страныLabel.Location = new System.Drawing.Point(70, 88);
            код_страныLabel.Name = "код_страныLabel";
            код_страныLabel.Size = new System.Drawing.Size(69, 13);
            код_страныLabel.TabIndex = 12;
            код_страныLabel.Text = "Код страны:";
            // 
            // столицаLabel
            // 
            столицаLabel.AutoSize = true;
            столицаLabel.Location = new System.Drawing.Point(70, 123);
            столицаLabel.Name = "столицаLabel";
            столицаLabel.Size = new System.Drawing.Size(52, 13);
            столицаLabel.TabIndex = 14;
            столицаLabel.Text = "Столица:";
            // 
            // площадьLabel
            // 
            площадьLabel.AutoSize = true;
            площадьLabel.Location = new System.Drawing.Point(70, 157);
            площадьLabel.Name = "площадьLabel";
            площадьLabel.Size = new System.Drawing.Size(57, 13);
            площадьLabel.TabIndex = 16;
            площадьLabel.Text = "Площадь:";
            // 
            // населениеLabel
            // 
            населениеLabel.AutoSize = true;
            населениеLabel.Location = new System.Drawing.Point(70, 191);
            населениеLabel.Name = "населениеLabel";
            населениеLabel.Size = new System.Drawing.Size(66, 13);
            населениеLabel.TabIndex = 18;
            населениеLabel.Text = "Население:";
            // 
            // регионLabel
            // 
            регионLabel.AutoSize = true;
            регионLabel.Location = new System.Drawing.Point(70, 223);
            регионLabel.Name = "регионLabel";
            регионLabel.Size = new System.Drawing.Size(46, 13);
            регионLabel.TabIndex = 20;
            регионLabel.Text = "Регион:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(регионLabel);
            this.groupBox1.Controls.Add(населениеLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(названиеLabel);
            this.groupBox1.Controls.Add(код_страныLabel);
            this.groupBox1.Controls.Add(столицаLabel);
            this.groupBox1.Controls.Add(площадьLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сохранить и вывести на экран базу?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Поиск страны";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 499);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

