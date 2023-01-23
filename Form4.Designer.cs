namespace Учет_книг
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nazv = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_kodizd = new System.Windows.Forms.TextBox();
            this.textBox_autor = new System.Windows.Forms.TextBox();
            this.textBox_opis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBox_nazv
            // 
            this.textBox_nazv.Location = new System.Drawing.Point(400, 44);
            this.textBox_nazv.Name = "textBox_nazv";
            this.textBox_nazv.Size = new System.Drawing.Size(350, 26);
            this.textBox_nazv.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(400, 450);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(200, 100);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Код издания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Описание";
            // 
            // textBox_kodizd
            // 
            this.textBox_kodizd.Location = new System.Drawing.Point(400, 144);
            this.textBox_kodizd.Name = "textBox_kodizd";
            this.textBox_kodizd.Size = new System.Drawing.Size(350, 26);
            this.textBox_kodizd.TabIndex = 6;
            // 
            // textBox_autor
            // 
            this.textBox_autor.Location = new System.Drawing.Point(400, 94);
            this.textBox_autor.Name = "textBox_autor";
            this.textBox_autor.Size = new System.Drawing.Size(350, 26);
            this.textBox_autor.TabIndex = 7;
            // 
            // textBox_opis
            // 
            this.textBox_opis.Location = new System.Drawing.Point(400, 194);
            this.textBox_opis.Multiline = true;
            this.textBox_opis.Name = "textBox_opis";
            this.textBox_opis.Size = new System.Drawing.Size(350, 219);
            this.textBox_opis.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.textBox_opis);
            this.Controls.Add(this.textBox_autor);
            this.Controls.Add(this.textBox_kodizd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_nazv);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Книга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nazv;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_kodizd;
        private System.Windows.Forms.TextBox textBox_autor;
        private System.Windows.Forms.TextBox textBox_opis;
    }
}