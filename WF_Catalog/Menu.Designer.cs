namespace WF_Catalog
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.Task1 = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(162, 82);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(174, 65);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Задание 1";
            this.toolTip1.SetToolTip(this.Task1, "Каталог товаров");
            this.Task1.UseVisualStyleBackColor = true;
            this.Task1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(162, 199);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(174, 67);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Задание 2";
            this.toolTip1.SetToolTip(this.Task2, "Калькулятор");
            this.Task2.UseVisualStyleBackColor = true;
            this.Task2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Task2;
        private System.Windows.Forms.Button button1;
    }
}