namespace Accounting_App
{
    partial class FrmAddOrEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrEditCustomer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectPhoto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pcCustommer = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txvaddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txvemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txvmobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txvname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCustommer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectPhoto);
            this.groupBox1.Controls.Add(this.pcCustommer);
            this.groupBox1.Location = new System.Drawing.Point(15, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.groupBox1.Size = new System.Drawing.Size(243, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تصویر";
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectPhoto.BackgroundImage")));
            this.btnSelectPhoto.ButtonText = "انتخاب تصویر";
            this.btnSelectPhoto.ButtonTextMarginLeft = 0;
            this.btnSelectPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectPhoto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSelectPhoto.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSelectPhoto.DisabledForecolor = System.Drawing.Color.White;
            this.btnSelectPhoto.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectPhoto.ForeColor = System.Drawing.Color.White;
            this.btnSelectPhoto.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectPhoto.IconPadding = 10;
            this.btnSelectPhoto.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectPhoto.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelectPhoto.IdleBorderRadius = 35;
            this.btnSelectPhoto.IdleBorderThickness = 0;
            this.btnSelectPhoto.IdleFillColor = System.Drawing.Color.Teal;
            this.btnSelectPhoto.IdleIconLeftImage = null;
            this.btnSelectPhoto.IdleIconRightImage = null;
            this.btnSelectPhoto.Location = new System.Drawing.Point(8, 301);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 35;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSelectPhoto.onHoverState = stateProperties1;
            this.btnSelectPhoto.Size = new System.Drawing.Size(225, 63);
            this.btnSelectPhoto.TabIndex = 2;
            this.btnSelectPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click_1);
            // 
            // pcCustommer
            // 
            this.pcCustommer.Image = global::Accounting_App.Properties.Resources.no_profile_image;
            this.pcCustommer.Location = new System.Drawing.Point(8, 39);
            this.pcCustommer.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.pcCustommer.Name = "pcCustommer";
            this.pcCustommer.Size = new System.Drawing.Size(225, 241);
            this.pcCustommer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCustommer.TabIndex = 1;
            this.pcCustommer.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txvaddress);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txvemail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txvmobile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txvname);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(267, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.groupBox2.Size = new System.Drawing.Size(247, 386);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات شخص";
            // 
            // txvaddress
            // 
            this.txvaddress.Location = new System.Drawing.Point(8, 277);
            this.txvaddress.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txvaddress.Multiline = true;
            this.txvaddress.Name = "txvaddress";
            this.txvaddress.Size = new System.Drawing.Size(228, 103);
            this.txvaddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(192, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "آدرس :";
            // 
            // txvemail
            // 
            this.txvemail.Location = new System.Drawing.Point(8, 203);
            this.txvemail.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txvemail.Name = "txvemail";
            this.txvemail.Size = new System.Drawing.Size(228, 41);
            this.txvemail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(195, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "ایمیل :";
            // 
            // txvmobile
            // 
            this.txvmobile.Location = new System.Drawing.Point(8, 129);
            this.txvmobile.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txvmobile.Name = "txvmobile";
            this.txvmobile.Size = new System.Drawing.Size(228, 41);
            this.txvmobile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(186, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "موبایل :";
            // 
            // txvname
            // 
            this.txvname.Location = new System.Drawing.Point(8, 55);
            this.txvname.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txvname.Name = "txvname";
            this.txvname.Size = new System.Drawing.Size(228, 41);
            this.txvname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(209, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "بستن";
            this.btnExit.ButtonTextMarginLeft = 0;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExit.DisabledForecolor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.IconPadding = 10;
            this.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.IdleBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.IdleBorderRadius = 35;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.IdleIconLeftImage = null;
            this.btnExit.IdleIconRightImage = null;
            this.btnExit.Location = new System.Drawing.Point(34, 402);
            this.btnExit.Name = "btnExit";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            stateProperties3.BorderRadius = 35;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnExit.onHoverState = stateProperties3;
            this.btnExit.Size = new System.Drawing.Size(205, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "ثبت";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSave.DisabledForecolor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.IdleBorderRadius = 35;
            this.btnSave.IdleBorderThickness = 0;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.Location = new System.Drawing.Point(287, 402);
            this.btnSave.Name = "btnSave";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            stateProperties2.BorderRadius = 35;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Lime;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties2;
            this.btnSave.Size = new System.Drawing.Size(205, 49);
            this.btnSave.TabIndex = 2;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // FrmAddOrEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 463);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddOrEditCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن شخص جدید";
            this.Load += new System.EventHandler(this.FrmAddOrEditCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCustommer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txvaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txvemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txvmobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txvname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcCustommer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSelectPhoto;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}