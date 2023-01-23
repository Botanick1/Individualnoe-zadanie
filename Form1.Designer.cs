namespace Учет_книг
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
            this.button_vhod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_vhod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_middlename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_numberfhone = new System.Windows.Forms.TextBox();
            this.dateTime_datebirth = new System.Windows.Forms.DateTimePicker();
            this.button_registr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_vhod
            // 
            this.button_vhod.Location = new System.Drawing.Point(625, 150);
            this.button_vhod.Name = "button_vhod";
            this.button_vhod.Size = new System.Drawing.Size(100, 40);
            this.button_vhod.TabIndex = 0;
            this.button_vhod.Text = "Вход";
            this.button_vhod.UseVisualStyleBackColor = true;
            this.button_vhod.Click += new System.EventHandler(this.button_vhod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // textBox_vhod
            // 
            this.textBox_vhod.Location = new System.Drawing.Point(525, 100);
            this.textBox_vhod.Name = "textBox_vhod";
            this.textBox_vhod.Size = new System.Drawing.Size(300, 26);
            this.textBox_vhod.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Для входа введите свой пароль ";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Location = new System.Drawing.Point(525, 320);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(300, 26);
            this.textBox_firstname.TabIndex = 6;
            // 
            // textBox_middlename
            // 
            this.textBox_middlename.Location = new System.Drawing.Point(525, 370);
            this.textBox_middlename.Name = "textBox_middlename";
            this.textBox_middlename.Size = new System.Drawing.Size(300, 26);
            this.textBox_middlename.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Регистрация";
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(525, 270);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(300, 26);
            this.textBox_lastname.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Номер телефона ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата рождения";
            // 
            // textBox_numberfhone
            // 
            this.textBox_numberfhone.Location = new System.Drawing.Point(525, 420);
            this.textBox_numberfhone.Name = "textBox_numberfhone";
            this.textBox_numberfhone.Size = new System.Drawing.Size(300, 26);
            this.textBox_numberfhone.TabIndex = 12;
            this.textBox_numberfhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numberfhone_KeyPress);
            // 
            // dateTime_datebirth
            // 
            this.dateTime_datebirth.Location = new System.Drawing.Point(528, 470);
            this.dateTime_datebirth.Name = "dateTime_datebirth";
            this.dateTime_datebirth.Size = new System.Drawing.Size(200, 26);
            this.dateTime_datebirth.TabIndex = 13;
            // 
            // button_registr
            // 
            this.button_registr.Location = new System.Drawing.Point(585, 550);
            this.button_registr.Name = "button_registr";
            this.button_registr.Size = new System.Drawing.Size(180, 50);
            this.button_registr.TabIndex = 14;
            this.button_registr.Text = "Зарегистрировать";
            this.button_registr.UseVisualStyleBackColor = true;
            this.button_registr.Click += new System.EventHandler(this.button_registr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 644);
            this.Controls.Add(this.button_registr);
            this.Controls.Add(this.dateTime_datebirth);
            this.Controls.Add(this.textBox_numberfhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_middlename);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_vhod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_vhod);
            this.Name = "Form1";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_vhod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_vhod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.TextBox textBox_middlename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_numberfhone;
        private System.Windows.Forms.DateTimePicker dateTime_datebirth;
        private System.Windows.Forms.Button button_registr;
    }
}

