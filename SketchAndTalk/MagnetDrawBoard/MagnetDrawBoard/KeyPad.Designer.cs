namespace MagnetDrawBoard
{
    partial class NumberPad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberPad));
            this.displayPanel = new System.Windows.Forms.Panel();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.status_label = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.displayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.displayPanel.Controls.Add(this.numberBox);
            this.displayPanel.Controls.Add(this.status_label);
            this.displayPanel.Location = new System.Drawing.Point(13, 36);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(314, 141);
            this.displayPanel.TabIndex = 0;
            // 
            // numberBox
            // 
            this.numberBox.BackColor = System.Drawing.Color.DarkGray;
            this.numberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberBox.Font = new System.Drawing.Font("Lucida Console", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(4, 77);
            this.numberBox.Multiline = true;
            this.numberBox.Name = "numberBox";
            this.numberBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numberBox.Size = new System.Drawing.Size(307, 61);
            this.numberBox.TabIndex = 0;
            this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberBox.WordWrap = false;
            this.numberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberBox_KeyPress);
            // 
            // status_label
            // 
            this.status_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_label.Font = new System.Drawing.Font("Lucida Console", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(3, 30);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(308, 53);
            this.status_label.TabIndex = 0;
            this.status_label.Text = "ENTER YOUR NUMBER";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonclear.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.Location = new System.Drawing.Point(252, 195);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 82);
            this.buttonclear.TabIndex = 1;
            this.buttonclear.Text = "C";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEnter.Font = new System.Drawing.Font("Linux Libertine Display G", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(252, 283);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 265);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "E\r\nN\r\nT\r\nE\r\nR\r\n";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(93, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 82);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(174, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 82);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 82);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AliceBlue;
            this.button5.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(93, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 82);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(174, 283);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 82);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 371);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 82);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.AliceBlue;
            this.button8.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(93, 371);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 82);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.AliceBlue;
            this.button9.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(174, 371);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 82);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.AliceBlue;
            this.button0.Font = new System.Drawing.Font("Linux Libertine Display G", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(93, 459);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 82);
            this.button0.TabIndex = 12;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "naxvar";
            // 
            // NumberPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(338, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.displayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NumberPad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyPad";
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel displayPanel;
        public System.Windows.Forms.Button buttonclear;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button0;
        public System.Windows.Forms.Label status_label;
        protected System.Windows.Forms.Button buttonEnter;
        public System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label1;
    }
}

