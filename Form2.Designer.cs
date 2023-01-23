namespace Учет_книг
{
    partial class Form2
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
            this.listBox_spkn = new System.Windows.Forms.ListBox();
            this.button_poisk = new System.Windows.Forms.Button();
            this.textBox_poisk = new System.Windows.Forms.TextBox();
            this.listBox_mspkn = new System.Windows.Forms.ListBox();
            this.button_nchb = new System.Windows.Forms.Button();
            this.button_vzyal = new System.Windows.Forms.Button();
            this.button_otdal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_spkn
            // 
            this.listBox_spkn.FormattingEnabled = true;
            this.listBox_spkn.ItemHeight = 20;
            this.listBox_spkn.Location = new System.Drawing.Point(35, 39);
            this.listBox_spkn.Name = "listBox_spkn";
            this.listBox_spkn.Size = new System.Drawing.Size(819, 444);
            this.listBox_spkn.TabIndex = 0;
            // 
            // button_poisk
            // 
            this.button_poisk.Location = new System.Drawing.Point(1183, 39);
            this.button_poisk.Name = "button_poisk";
            this.button_poisk.Size = new System.Drawing.Size(118, 36);
            this.button_poisk.TabIndex = 1;
            this.button_poisk.Text = "Поиск";
            this.button_poisk.UseVisualStyleBackColor = true;
            this.button_poisk.Click += new System.EventHandler(this.button_poisk_Click);
            // 
            // textBox_poisk
            // 
            this.textBox_poisk.Location = new System.Drawing.Point(876, 39);
            this.textBox_poisk.Name = "textBox_poisk";
            this.textBox_poisk.Size = new System.Drawing.Size(285, 26);
            this.textBox_poisk.TabIndex = 2;
            // 
            // listBox_mspkn
            // 
            this.listBox_mspkn.FormattingEnabled = true;
            this.listBox_mspkn.ItemHeight = 20;
            this.listBox_mspkn.Location = new System.Drawing.Point(913, 99);
            this.listBox_mspkn.Name = "listBox_mspkn";
            this.listBox_mspkn.Size = new System.Drawing.Size(368, 384);
            this.listBox_mspkn.TabIndex = 3;
            // 
            // button_nchb
            // 
            this.button_nchb.Location = new System.Drawing.Point(120, 501);
            this.button_nchb.Name = "button_nchb";
            this.button_nchb.Size = new System.Drawing.Size(200, 100);
            this.button_nchb.TabIndex = 4;
            this.button_nchb.Text = "Номер читательского билета";
            this.button_nchb.UseVisualStyleBackColor = true;
            this.button_nchb.Click += new System.EventHandler(this.button_nchb_Click);
            // 
            // button_vzyal
            // 
            this.button_vzyal.Location = new System.Drawing.Point(510, 501);
            this.button_vzyal.Name = "button_vzyal";
            this.button_vzyal.Size = new System.Drawing.Size(200, 100);
            this.button_vzyal.TabIndex = 5;
            this.button_vzyal.Text = "Список книг на руках";
            this.button_vzyal.UseVisualStyleBackColor = true;
            this.button_vzyal.Click += new System.EventHandler(this.button_vzyal_Click);
            // 
            // button_otdal
            // 
            this.button_otdal.Location = new System.Drawing.Point(913, 501);
            this.button_otdal.Name = "button_otdal";
            this.button_otdal.Size = new System.Drawing.Size(200, 100);
            this.button_otdal.TabIndex = 6;
            this.button_otdal.Text = "Список книг что вернул";
            this.button_otdal.UseVisualStyleBackColor = true;
            this.button_otdal.Click += new System.EventHandler(this.button_otdal_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 644);
            this.Controls.Add(this.button_otdal);
            this.Controls.Add(this.button_vzyal);
            this.Controls.Add(this.button_nchb);
            this.Controls.Add(this.listBox_mspkn);
            this.Controls.Add(this.textBox_poisk);
            this.Controls.Add(this.button_poisk);
            this.Controls.Add(this.listBox_spkn);
            this.Name = "Form2";
            this.Text = "Читатель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_spkn;
        private System.Windows.Forms.Button button_poisk;
        private System.Windows.Forms.TextBox textBox_poisk;
        private System.Windows.Forms.ListBox listBox_mspkn;
        private System.Windows.Forms.Button button_nchb;
        private System.Windows.Forms.Button button_vzyal;
        private System.Windows.Forms.Button button_otdal;
    }
}