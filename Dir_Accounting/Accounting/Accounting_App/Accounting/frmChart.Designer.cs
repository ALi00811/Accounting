namespace Accounting_App
{
    partial class frmChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChart));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbYear = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbChartType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbMonth = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bcPay = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bcRecive = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblRecive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartRecive = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPay)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.cbChartType);
            this.groupBox1.Controls.Add(this.cbMonth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bcPay);
            this.groupBox1.Controls.Add(this.bcRecive);
            this.groupBox1.Location = new System.Drawing.Point(423, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox1.Size = new System.Drawing.Size(200, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع نمودار";
            // 
            // cbYear
            // 
            this.cbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbYear.DisplayMember = "Text";
            this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.ItemHeight = 30;
            this.cbYear.Location = new System.Drawing.Point(32, 125);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(138, 36);
            this.cbYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbYear.TabIndex = 5;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cbChartType
            // 
            this.cbChartType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbChartType.DisplayMember = "Text";
            this.cbChartType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChartType.FormattingEnabled = true;
            this.cbChartType.ItemHeight = 30;
            this.cbChartType.Location = new System.Drawing.Point(32, 257);
            this.cbChartType.Name = "cbChartType";
            this.cbChartType.Size = new System.Drawing.Size(138, 36);
            this.cbChartType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbChartType.TabIndex = 4;
            this.cbChartType.SelectedIndexChanged += new System.EventHandler(this.cbChartType_SelectedIndexChanged);
            // 
            // cbMonth
            // 
            this.cbMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMonth.DisplayMember = "Text";
            this.cbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.ItemHeight = 30;
            this.cbMonth.Location = new System.Drawing.Point(32, 64);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(138, 36);
            this.cbMonth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMonth.TabIndex = 4;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(50, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "(( نوع نمایش نمودار))";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(80, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "پرداختی ها";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(32, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "(( سال مورد نظر را انتخاب کنید ))";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(32, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "(( ماه مورد نظر را انتخاب کنید ))";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(80, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "دریافتی ها";
            // 
            // bcPay
            // 
            this.bcPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcPay.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bcPay.Checked = true;
            this.bcPay.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcPay.ForeColor = System.Drawing.Color.White;
            this.bcPay.Location = new System.Drawing.Point(54, 197);
            this.bcPay.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bcPay.Name = "bcPay";
            this.bcPay.Size = new System.Drawing.Size(20, 20);
            this.bcPay.TabIndex = 2;
            this.bcPay.OnChange += new System.EventHandler(this.bcPay_OnChange);
            // 
            // bcRecive
            // 
            this.bcRecive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bcRecive.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bcRecive.Checked = false;
            this.bcRecive.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcRecive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcRecive.ForeColor = System.Drawing.Color.White;
            this.bcRecive.Location = new System.Drawing.Point(54, 169);
            this.bcRecive.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bcRecive.Name = "bcRecive";
            this.bcRecive.Size = new System.Drawing.Size(20, 20);
            this.bcRecive.TabIndex = 1;
            this.bcRecive.OnChange += new System.EventHandler(this.bcRecive_OnChange);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.ButtonText = "بستن";
            this.btnExit.ButtonTextMarginLeft = 0;
            this.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExit.DisabledForecolor = System.Drawing.Color.White;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconPadding = 10;
            this.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IdleBorderColor = System.Drawing.Color.Yellow;
            this.btnExit.IdleBorderRadius = 20;
            this.btnExit.IdleBorderThickness = 0;
            this.btnExit.IdleFillColor = System.Drawing.Color.Red;
            this.btnExit.IdleIconLeftImage = null;
            this.btnExit.IdleIconRightImage = null;
            this.btnExit.Location = new System.Drawing.Point(428, 378);
            this.btnExit.Name = "btnExit";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties2.BorderRadius = 20;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnExit.onHoverState = stateProperties2;
            this.btnExit.Size = new System.Drawing.Size(188, 43);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblBalance);
            this.groupBox2.Controls.Add(this.lblPay);
            this.groupBox2.Controls.Add(this.lblRecive);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chartRecive);
            this.groupBox2.Controls.Add(this.chartPay);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.groupBox2.Size = new System.Drawing.Size(405, 413);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نمودار";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(314, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "وضعیت کلی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(149, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "پرداختی :";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBalance.Location = new System.Drawing.Point(211, 368);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(78, 33);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "000000000";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPay.Location = new System.Drawing.Point(77, 333);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(78, 33);
            this.lblPay.TabIndex = 1;
            this.lblPay.Text = "000000000";
            // 
            // lblRecive
            // 
            this.lblRecive.AutoSize = true;
            this.lblRecive.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecive.Location = new System.Drawing.Point(268, 333);
            this.lblRecive.Name = "lblRecive";
            this.lblRecive.Size = new System.Drawing.Size(78, 33);
            this.lblRecive.TabIndex = 1;
            this.lblRecive.Text = "000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aviny", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(340, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "دریافتی :";
            // 
            // chartRecive
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRecive.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRecive.Legends.Add(legend3);
            this.chartRecive.Location = new System.Drawing.Point(6, 30);
            this.chartRecive.Name = "chartRecive";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "دریافتی ها";
            this.chartRecive.Series.Add(series3);
            this.chartRecive.Size = new System.Drawing.Size(393, 286);
            this.chartRecive.TabIndex = 0;
            this.chartRecive.Text = "chart1";
            this.chartRecive.Visible = false;
            // 
            // chartPay
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPay.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPay.Legends.Add(legend4);
            this.chartPay.Location = new System.Drawing.Point(6, 30);
            this.chartPay.Name = "chartPay";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "پرداختی ها";
            this.chartPay.Series.Add(series4);
            this.chartPay.Size = new System.Drawing.Size(393, 286);
            this.chartPay.TabIndex = 0;
            this.chartPay.Text = "chart1";
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Aviny", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmChart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChart";
            this.Load += new System.EventHandler(this.frmChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox bcPay;
        private Bunifu.Framework.UI.BunifuCheckbox bcRecive;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMonth;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartPay;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartRecive;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbChartType;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblRecive;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbYear;
        private System.Windows.Forms.Label label8;
    }
}