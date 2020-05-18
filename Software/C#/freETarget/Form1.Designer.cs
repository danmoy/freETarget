﻿namespace freETarget
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.imgTarget = new System.Windows.Forms.PictureBox();
            this.shotsList = new System.Windows.Forms.ListView();
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListDirections = new System.Windows.Forms.ImageList(this.components);
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastShot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imgArrow = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbWeapon = new System.Windows.Forms.ComboBox();
            this.imgAirPistol = new System.Windows.Forms.PictureBox();
            this.imgAirRifle = new System.Windows.Forms.PictureBox();
            this.trkZoom = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAirPistol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAirRifle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(7, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1186, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(39, 17);
            this.statusText.Text = "Ready";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Location = new System.Drawing.Point(723, 37);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(315, 500);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.WordWrap = false;
            // 
            // imgTarget
            // 
            this.imgTarget.BackColor = System.Drawing.Color.Linen;
            this.imgTarget.Image = ((System.Drawing.Image)(resources.GetObject("imgTarget.Image")));
            this.imgTarget.InitialImage = null;
            this.imgTarget.Location = new System.Drawing.Point(217, 37);
            this.imgTarget.MaximumSize = new System.Drawing.Size(500, 500);
            this.imgTarget.MinimumSize = new System.Drawing.Size(500, 500);
            this.imgTarget.Name = "imgTarget";
            this.imgTarget.Size = new System.Drawing.Size(500, 500);
            this.imgTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgTarget.TabIndex = 4;
            this.imgTarget.TabStop = false;
            this.imgTarget.WaitOnLoad = true;
            // 
            // shotsList
            // 
            this.shotsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.shotsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col4,
            this.col1,
            this.col2,
            this.col3});
            this.shotsList.FullRowSelect = true;
            this.shotsList.GridLines = true;
            this.shotsList.HideSelection = false;
            this.shotsList.Location = new System.Drawing.Point(7, 37);
            this.shotsList.MultiSelect = false;
            this.shotsList.Name = "shotsList";
            this.shotsList.Size = new System.Drawing.Size(204, 435);
            this.shotsList.SmallImageList = this.imgListDirections;
            this.shotsList.StateImageList = this.imgListDirections;
            this.shotsList.TabIndex = 5;
            this.shotsList.UseCompatibleStateImageBehavior = false;
            this.shotsList.View = System.Windows.Forms.View.Details;
            // 
            // col4
            // 
            this.col4.Text = "Direction";
            this.col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col4.Width = 56;
            // 
            // col1
            // 
            this.col1.Text = "Shot";
            this.col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col1.Width = 36;
            // 
            // col2
            // 
            this.col2.Text = "Score";
            this.col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col2.Width = 40;
            // 
            // col3
            // 
            this.col3.Text = "Decimal";
            this.col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col3.Width = 51;
            // 
            // imgListDirections
            // 
            this.imgListDirections.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListDirections.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListDirections.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.Location = new System.Drawing.Point(56, 515);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(155, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total";
            // 
            // txtLastShot
            // 
            this.txtLastShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLastShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLastShot.Location = new System.Drawing.Point(75, 477);
            this.txtLastShot.Name = "txtLastShot";
            this.txtLastShot.ReadOnly = true;
            this.txtLastShot.Size = new System.Drawing.Size(100, 31);
            this.txtLastShot.TabIndex = 8;
            this.txtLastShot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Shot";
            // 
            // imgArrow
            // 
            this.imgArrow.BackColor = System.Drawing.Color.White;
            this.imgArrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgArrow.Image = ((System.Drawing.Image)(resources.GetObject("imgArrow.Image")));
            this.imgArrow.Location = new System.Drawing.Point(181, 477);
            this.imgArrow.Name = "imgArrow";
            this.imgArrow.Size = new System.Drawing.Size(30, 30);
            this.imgArrow.TabIndex = 10;
            this.imgArrow.TabStop = false;
            this.imgArrow.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.imgArrow_LoadCompleted);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(690, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbWeapon
            // 
            this.cmbWeapon.FormattingEnabled = true;
            this.cmbWeapon.Location = new System.Drawing.Point(217, 9);
            this.cmbWeapon.Name = "cmbWeapon";
            this.cmbWeapon.Size = new System.Drawing.Size(121, 21);
            this.cmbWeapon.TabIndex = 12;
            this.cmbWeapon.SelectedIndexChanged += new System.EventHandler(this.cmbWeapon_SelectedIndexChanged);
            // 
            // imgAirPistol
            // 
            this.imgAirPistol.Image = ((System.Drawing.Image)(resources.GetObject("imgAirPistol.Image")));
            this.imgAirPistol.Location = new System.Drawing.Point(1059, 43);
            this.imgAirPistol.Name = "imgAirPistol";
            this.imgAirPistol.Size = new System.Drawing.Size(47, 30);
            this.imgAirPistol.TabIndex = 13;
            this.imgAirPistol.TabStop = false;
            // 
            // imgAirRifle
            // 
            this.imgAirRifle.Image = ((System.Drawing.Image)(resources.GetObject("imgAirRifle.Image")));
            this.imgAirRifle.Location = new System.Drawing.Point(1059, 116);
            this.imgAirRifle.Name = "imgAirRifle";
            this.imgAirRifle.Size = new System.Drawing.Size(47, 29);
            this.imgAirRifle.TabIndex = 14;
            this.imgAirRifle.TabStop = false;
            this.imgAirRifle.Visible = false;
            // 
            // trkZoom
            // 
            this.trkZoom.LargeChange = 1;
            this.trkZoom.Location = new System.Drawing.Point(467, 6);
            this.trkZoom.Maximum = 12;
            this.trkZoom.Minimum = 2;
            this.trkZoom.Name = "trkZoom";
            this.trkZoom.Size = new System.Drawing.Size(104, 45);
            this.trkZoom.TabIndex = 15;
            this.trkZoom.Value = 2;
            this.trkZoom.ValueChanged += new System.EventHandler(this.trkZoom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Zoom";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imgAirRifle);
            this.Controls.Add(this.imgAirPistol);
            this.Controls.Add(this.cmbWeapon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgArrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastShot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.shotsList);
            this.Controls.Add(this.imgTarget);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.trkZoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainWindow";
            this.Text = "freETarget";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainWindow_FormClosing);
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.Shown += new System.EventHandler(this.frmMainWindow_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAirPistol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAirRifle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        public System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.PictureBox imgTarget;
        private System.Windows.Forms.ListView shotsList;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastShot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgArrow;
        private System.Windows.Forms.ImageList imgListDirections;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbWeapon;
        private System.Windows.Forms.PictureBox imgAirPistol;
        private System.Windows.Forms.PictureBox imgAirRifle;
        private System.Windows.Forms.TrackBar trkZoom;
        private System.Windows.Forms.Label label3;
    }
}
