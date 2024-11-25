namespace upr19
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.галериаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraciq1 = new upr19.View.Registraciq();
            this.vhod1 = new upr19.View.Vhod();
            this.zaNas1 = new upr19.View.ZaNas();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.началоToolStripMenuItem,
            this.галериаToolStripMenuItem,
            this.заНасToolStripMenuItem,
            this.услугиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // началоToolStripMenuItem
            // 
            this.началоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem,
            this.регистрацияToolStripMenuItem});
            this.началоToolStripMenuItem.Name = "началоToolStripMenuItem";
            this.началоToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.началоToolStripMenuItem.Text = "Начало";
            this.началоToolStripMenuItem.Click += new System.EventHandler(this.началоToolStripMenuItem_Click);
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.входToolStripMenuItem.Text = "Вход";
            this.входToolStripMenuItem.Click += new System.EventHandler(this.входToolStripMenuItem_Click);
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // галериаToolStripMenuItem
            // 
            this.галериаToolStripMenuItem.Name = "галериаToolStripMenuItem";
            this.галериаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.галериаToolStripMenuItem.Text = "Галерия";
            this.галериаToolStripMenuItem.Click += new System.EventHandler(this.галериаToolStripMenuItem_Click);
            // 
            // заНасToolStripMenuItem
            // 
            this.заНасToolStripMenuItem.Name = "заНасToolStripMenuItem";
            this.заНасToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.заНасToolStripMenuItem.Text = "За нас";
            this.заНасToolStripMenuItem.Click += new System.EventHandler(this.заНасToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // registraciq1
            // 
            this.registraciq1.Location = new System.Drawing.Point(0, 27);
            this.registraciq1.Name = "registraciq1";
            this.registraciq1.Size = new System.Drawing.Size(584, 431);
            this.registraciq1.TabIndex = 2;
            // 
            // vhod1
            // 
            this.vhod1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vhod1.Location = new System.Drawing.Point(0, 27);
            this.vhod1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vhod1.Name = "vhod1";
            this.vhod1.Size = new System.Drawing.Size(584, 431);
            this.vhod1.TabIndex = 3;
            // 
            // zaNas1
            // 
            this.zaNas1.Location = new System.Drawing.Point(0, 27);
            this.zaNas1.Name = "zaNas1";
            this.zaNas1.Size = new System.Drawing.Size(584, 431);
            this.zaNas1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.zaNas1);
            this.Controls.Add(this.registraciq1);
            this.Controls.Add(this.vhod1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem галериаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private View.Registraciq registraciq1;
        private View.Vhod vhod1;
        private View.ZaNas zaNas1;
    }
}

