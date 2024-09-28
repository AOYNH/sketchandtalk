namespace MagnetDrawBoard
{
    partial class DrawingBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingBoard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.move_label = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.buttonrefresh = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonsend = new System.Windows.Forms.Button();
            this.panel_receiver = new System.Windows.Forms.Panel();
            this.receivernumber_nuberlabel = new System.Windows.Forms.Label();
            this.receiver_label = new System.Windows.Forms.Label();
            this.panel_sender = new System.Windows.Forms.Panel();
            this.mynumber_nuberlabel = new System.Windows.Forms.Label();
            this.sender_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_receiver.SuspendLayout();
            this.panel_sender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.pictureBox1.Location = new System.Drawing.Point(83, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 331);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // move_label
            // 
            this.move_label.AutoSize = true;
            this.move_label.BackColor = System.Drawing.SystemColors.ControlText;
            this.move_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.move_label.ForeColor = System.Drawing.Color.White;
            this.move_label.Location = new System.Drawing.Point(400, 61);
            this.move_label.Name = "move_label";
            this.move_label.Size = new System.Drawing.Size(82, 20);
            this.move_label.TabIndex = 1;
            this.move_label.Text = "MoveHere";
            this.move_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_label_MouseDown);
            this.move_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.move_label_MouseMove);
            this.move_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.move_label_MouseUp);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.hScrollBar1.Location = new System.Drawing.Point(2, 421);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(821, 35);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // buttonrefresh
            // 
            this.buttonrefresh.BackColor = System.Drawing.Color.Maroon;
            this.buttonrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonrefresh.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonrefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonrefresh.Location = new System.Drawing.Point(2, 337);
            this.buttonrefresh.Name = "buttonrefresh";
            this.buttonrefresh.Size = new System.Drawing.Size(75, 78);
            this.buttonrefresh.TabIndex = 3;
            this.buttonrefresh.TabStop = false;
            this.buttonrefresh.Text = "q";
            this.buttonrefresh.UseVisualStyleBackColor = false;
            this.buttonrefresh.Click += new System.EventHandler(this.buttonrefresh_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClose.Location = new System.Drawing.Point(829, 84);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 78);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonsend
            // 
            this.buttonsend.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonsend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsend.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonsend.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonsend.Location = new System.Drawing.Point(826, 421);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(78, 52);
            this.buttonsend.TabIndex = 5;
            this.buttonsend.TabStop = false;
            this.buttonsend.Text = "8";
            this.buttonsend.UseVisualStyleBackColor = false;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // panel_receiver
            // 
            this.panel_receiver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_receiver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_receiver.Controls.Add(this.receivernumber_nuberlabel);
            this.panel_receiver.Controls.Add(this.receiver_label);
            this.panel_receiver.Location = new System.Drawing.Point(588, 480);
            this.panel_receiver.Name = "panel_receiver";
            this.panel_receiver.Size = new System.Drawing.Size(235, 64);
            this.panel_receiver.TabIndex = 6;
            // 
            // receivernumber_nuberlabel
            // 
            this.receivernumber_nuberlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receivernumber_nuberlabel.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivernumber_nuberlabel.Location = new System.Drawing.Point(1, 28);
            this.receivernumber_nuberlabel.Name = "receivernumber_nuberlabel";
            this.receivernumber_nuberlabel.Size = new System.Drawing.Size(228, 33);
            this.receivernumber_nuberlabel.TabIndex = 2;
            this.receivernumber_nuberlabel.Text = "-------";
            this.receivernumber_nuberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.receivernumber_nuberlabel.Click += new System.EventHandler(this.receivernumber_nuberlabel_Click);
            // 
            // receiver_label
            // 
            this.receiver_label.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiver_label.Location = new System.Drawing.Point(4, 4);
            this.receiver_label.Name = "receiver_label";
            this.receiver_label.Size = new System.Drawing.Size(228, 23);
            this.receiver_label.TabIndex = 0;
            this.receiver_label.Text = "RECEIVER NUMBER";
            this.receiver_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_sender
            // 
            this.panel_sender.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_sender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_sender.Controls.Add(this.mynumber_nuberlabel);
            this.panel_sender.Controls.Add(this.sender_label);
            this.panel_sender.Location = new System.Drawing.Point(323, 480);
            this.panel_sender.Name = "panel_sender";
            this.panel_sender.Size = new System.Drawing.Size(235, 64);
            this.panel_sender.TabIndex = 7;
            // 
            // mynumber_nuberlabel
            // 
            this.mynumber_nuberlabel.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mynumber_nuberlabel.Location = new System.Drawing.Point(0, 27);
            this.mynumber_nuberlabel.Name = "mynumber_nuberlabel";
            this.mynumber_nuberlabel.Size = new System.Drawing.Size(228, 33);
            this.mynumber_nuberlabel.TabIndex = 1;
            this.mynumber_nuberlabel.Text = "0912345678";
            this.mynumber_nuberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sender_label
            // 
            this.sender_label.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sender_label.Location = new System.Drawing.Point(4, 4);
            this.sender_label.Name = "sender_label";
            this.sender_label.Size = new System.Drawing.Size(228, 23);
            this.sender_label.TabIndex = 0;
            this.sender_label.Text = "MY NUMBER";
            this.sender_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(773, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sketch Talk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "naxvar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DrawingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_sender);
            this.Controls.Add(this.panel_receiver);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonrefresh);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.move_label);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrawingBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawingBoard";
            this.Load += new System.EventHandler(this.DrawingBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_receiver.ResumeLayout(false);
            this.panel_sender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label move_label;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button buttonrefresh;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.Panel panel_receiver;
        private System.Windows.Forms.Label receiver_label;
        private System.Windows.Forms.Panel panel_sender;
        private System.Windows.Forms.Label sender_label;
        private System.Windows.Forms.Label mynumber_nuberlabel;
        private System.Windows.Forms.Label receivernumber_nuberlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}