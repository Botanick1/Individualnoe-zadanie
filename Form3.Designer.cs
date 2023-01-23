namespace Учет_книг
{
    partial class Form3
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
            this.listBox_vseknigi = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_otd = new System.Windows.Forms.Button();
            this.button_priem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_vseknigi
            // 
            this.listBox_vseknigi.FormattingEnabled = true;
            this.listBox_vseknigi.ItemHeight = 20;
            this.listBox_vseknigi.Location = new System.Drawing.Point(40, 25);
            this.listBox_vseknigi.Name = "listBox_vseknigi";
            this.listBox_vseknigi.Size = new System.Drawing.Size(960, 584);
            this.listBox_vseknigi.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(1108, 25);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(149, 69);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(1108, 155);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(149, 69);
            this.button_del.TabIndex = 2;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_red
            // 
            this.button_red.Location = new System.Drawing.Point(1108, 287);
            this.button_red.Name = "button_red";
            this.button_red.Size = new System.Drawing.Size(149, 69);
            this.button_red.TabIndex = 3;
            this.button_red.Text = "Редактировать";
            this.button_red.UseVisualStyleBackColor = true;
            this.button_red.Click += new System.EventHandler(this.button_red_Click);
            // 
            // button_otd
            // 
            this.button_otd.Location = new System.Drawing.Point(1108, 414);
            this.button_otd.Name = "button_otd";
            this.button_otd.Size = new System.Drawing.Size(149, 69);
            this.button_otd.TabIndex = 4;
            this.button_otd.Text = "Выдача";
            this.button_otd.UseVisualStyleBackColor = true;
            this.button_otd.Click += new System.EventHandler(this.button_otd_Click);
            // 
            // button_priem
            // 
            this.button_priem.Location = new System.Drawing.Point(1108, 540);
            this.button_priem.Name = "button_priem";
            this.button_priem.Size = new System.Drawing.Size(149, 69);
            this.button_priem.TabIndex = 5;
            this.button_priem.Text = "Прием";
            this.button_priem.UseVisualStyleBackColor = true;
            this.button_priem.Click += new System.EventHandler(this.button_priem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 644);
            this.Controls.Add(this.button_priem);
            this.Controls.Add(this.button_otd);
            this.Controls.Add(this.button_red);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_vseknigi);
            this.Name = "Form3";
            this.Text = "Библиотекарь";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_vseknigi;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_otd;
        private System.Windows.Forms.Button button_priem;
    }
}