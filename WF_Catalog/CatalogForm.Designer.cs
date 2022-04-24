namespace WF_Catalog
{
    partial class Catalog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_close);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Controls.Add(this.bt_clear);
            this.panel1.Controls.Add(this.bt_del);
            this.panel1.Controls.Add(this.bt_edit);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 619);
            this.panel1.TabIndex = 0;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(12, 485);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(493, 32);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "Очистить список";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(12, 443);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(493, 36);
            this.bt_del.TabIndex = 3;
            this.bt_del.Text = "Удалить товар";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(12, 404);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(493, 33);
            this.bt_edit.TabIndex = 2;
            this.bt_edit.Text = "Редактировать товар";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(13, 360);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(493, 38);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Добавить товар";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_add_MouseClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(493, 340);
            this.listBox1.TabIndex = 0;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(12, 523);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(249, 59);
            this.bt_save.TabIndex = 5;
            this.bt_save.Text = "Сохранить в файл";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(267, 523);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(238, 59);
            this.bt_close.TabIndex = 6;
            this.bt_close.Text = "Выход в меню";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 619);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Catalog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог товаров";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_save;
    }
}

