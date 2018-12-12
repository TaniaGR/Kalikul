namespace Zara
{
    partial class glav_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glav_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отделКадровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.zara_base2DataSet = new Zara.Zara_base2DataSet();
            this.zarabase2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zara_base2DataSet1 = new Zara.Zara_base2DataSet1();
            this.dolzhnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolzhnTableAdapter = new Zara.Zara_base2DataSet1TableAdapters.dolzhnTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zara_base2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarabase2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zara_base2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отделКадровToolStripMenuItem,
            this.складToolStripMenuItem,
            this.продажиToolStripMenuItem,
            this.выходИзПрограммыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отделКадровToolStripMenuItem
            // 
            this.отделКадровToolStripMenuItem.Enabled = false;
            this.отделКадровToolStripMenuItem.Name = "отделКадровToolStripMenuItem";
            this.отделКадровToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.отделКадровToolStripMenuItem.Text = "Отдел кадров";
            this.отделКадровToolStripMenuItem.Click += new System.EventHandler(this.отделКадровToolStripMenuItem_Click);
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Enabled = false;
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.складToolStripMenuItem.Text = "Учет товаров";
            this.складToolStripMenuItem.Click += new System.EventHandler(this.складToolStripMenuItem_Click);
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.Enabled = false;
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.продажиToolStripMenuItem.Text = "Продажи";
            this.продажиToolStripMenuItem.Click += new System.EventHandler(this.продажиToolStripMenuItem_Click);
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Zara.Properties.Resources.zara;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(57, 20);
            this.toolStripSplitButton1.Text = "Выход";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // zara_base2DataSet
            // 
            this.zara_base2DataSet.DataSetName = "Zara_base2DataSet";
            this.zara_base2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zarabase2DataSetBindingSource
            // 
            this.zarabase2DataSetBindingSource.DataSource = this.zara_base2DataSet;
            this.zarabase2DataSetBindingSource.Position = 0;
            // 
            // zara_base2DataSet1
            // 
            this.zara_base2DataSet1.DataSetName = "Zara_base2DataSet1";
            this.zara_base2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dolzhnBindingSource
            // 
            this.dolzhnBindingSource.DataMember = "dolzhn";
            this.dolzhnBindingSource.DataSource = this.zara_base2DataSet1;
            // 
            // dolzhnTableAdapter
            // 
            this.dolzhnTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(709, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // glav_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "glav_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.glav_menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.glav_menu_FormClosed);
            this.Load += new System.EventHandler(this.glav_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zara_base2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarabase2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zara_base2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отделКадровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Zara_base2DataSet zara_base2DataSet;
        private System.Windows.Forms.BindingSource zarabase2DataSetBindingSource;
        private Zara_base2DataSet1 zara_base2DataSet1;
        private System.Windows.Forms.BindingSource dolzhnBindingSource;
        private Zara_base2DataSet1TableAdapters.dolzhnTableAdapter dolzhnTableAdapter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}