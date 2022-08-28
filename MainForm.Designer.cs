using System.Windows.Forms;

namespace Inventorymanagementsystem1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerButton5 = new Inventorymanagementsystem1.CustomerButton();
            this.customerButton4 = new Inventorymanagementsystem1.CustomerButton();
            this.customerButton3 = new Inventorymanagementsystem1.CustomerButton();
            this.customerButton2 = new Inventorymanagementsystem1.CustomerButton();
            this.customerButton1 = new Inventorymanagementsystem1.CustomerButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.customerButton5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customerButton4);
            this.panel1.Controls.Add(this.customerButton3);
            this.panel1.Controls.Add(this.customerButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.customerButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "SHOPRITE INVENTORY MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Location = new System.Drawing.Point(0, 90);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(686, 285);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRODUCT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "CUSTOMERS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "CATEGORIES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "USERS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ORDERS";
            // 
            // customerButton5
            // 
            this.customerButton5.Image = ((System.Drawing.Image)(resources.GetObject("customerButton5.Image")));
            this.customerButton5.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton5.ImageHover")));
            this.customerButton5.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton5.ImageNormal")));
            this.customerButton5.Location = new System.Drawing.Point(477, 37);
            this.customerButton5.Name = "customerButton5";
            this.customerButton5.Size = new System.Drawing.Size(36, 30);
            this.customerButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton5.TabIndex = 12;
            this.customerButton5.TabStop = false;
            this.customerButton5.Click += new System.EventHandler(this.customerButton5_Click);
            // 
            // customerButton4
            // 
            this.customerButton4.Image = ((System.Drawing.Image)(resources.GetObject("customerButton4.Image")));
            this.customerButton4.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton4.ImageHover")));
            this.customerButton4.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton4.ImageNormal")));
            this.customerButton4.Location = new System.Drawing.Point(382, 38);
            this.customerButton4.Name = "customerButton4";
            this.customerButton4.Size = new System.Drawing.Size(36, 30);
            this.customerButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton4.TabIndex = 7;
            this.customerButton4.TabStop = false;
            // 
            // customerButton3
            // 
            this.customerButton3.Image = ((System.Drawing.Image)(resources.GetObject("customerButton3.Image")));
            this.customerButton3.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton3.ImageHover")));
            this.customerButton3.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton3.ImageNormal")));
            this.customerButton3.Location = new System.Drawing.Point(291, 37);
            this.customerButton3.Name = "customerButton3";
            this.customerButton3.Size = new System.Drawing.Size(36, 30);
            this.customerButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton3.TabIndex = 6;
            this.customerButton3.TabStop = false;
            // 
            // customerButton2
            // 
            this.customerButton2.Image = ((System.Drawing.Image)(resources.GetObject("customerButton2.Image")));
            this.customerButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton2.ImageHover")));
            this.customerButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton2.ImageNormal")));
            this.customerButton2.Location = new System.Drawing.Point(200, 37);
            this.customerButton2.Name = "customerButton2";
            this.customerButton2.Size = new System.Drawing.Size(36, 30);
            this.customerButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton2.TabIndex = 5;
            this.customerButton2.TabStop = false;
            // 
            // customerButton1
            // 
            this.customerButton1.Image = ((System.Drawing.Image)(resources.GetObject("customerButton1.Image")));
            this.customerButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageHover")));
            this.customerButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageNormal")));
            this.customerButton1.Location = new System.Drawing.Point(109, 37);
            this.customerButton1.Name = "customerButton1";
            this.customerButton1.Size = new System.Drawing.Size(36, 30);
            this.customerButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton1.TabIndex = 0;
            this.customerButton1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 10);
            this.panel2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelMain;
        private PictureBox pictureBox1;
        private CustomerButton customerButton1;
        private Label label1;
        private Label label6;
        private CustomerButton customerButton5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CustomerButton customerButton4;
        private CustomerButton customerButton3;
        private CustomerButton customerButton2;
        private Panel panel2;
    }
}
