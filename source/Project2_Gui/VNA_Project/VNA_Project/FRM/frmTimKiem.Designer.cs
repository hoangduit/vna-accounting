﻿namespace VNA_Project.FRM
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.palRight = new Qios.DevSuite.Components.QPanel();
            this.btnThoat = new Qios.DevSuite.Components.QButton();
            this.qsButton = new Qios.DevSuite.Components.QShape();
            this.btnDongY = new Qios.DevSuite.Components.QButton();
            this.palTop_Center = new Qios.DevSuite.Components.QPanel();
            this.palCenter = new Qios.DevSuite.Components.QPanel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.palTop = new Qios.DevSuite.Components.QPanel();
            this.qMarkupLabel3 = new Qios.DevSuite.Components.QMarkupLabel();
            this.txtTenSearch = new Qios.DevSuite.Components.QTextBox();
            this.qMarkupLabel2 = new Qios.DevSuite.Components.QMarkupLabel();
            this.txtMaSearch = new Qios.DevSuite.Components.QTextBox();
            this.qMarkupLabel1 = new Qios.DevSuite.Components.QMarkupLabel();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
            this.palRight.SuspendLayout();
            this.palTop_Center.SuspendLayout();
            this.palCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.palTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // qRibbonCaption1
            // 
            this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption1.Name = "qRibbonCaption1";
            this.qRibbonCaption1.Size = new System.Drawing.Size(494, 28);
            this.qRibbonCaption1.TabIndex = 0;
            this.qRibbonCaption1.Text = "TÌM KIẾM - SEARCH";
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.btnThoat);
            this.palRight.Controls.Add(this.btnDongY);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.palRight.Location = new System.Drawing.Point(374, 28);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(120, 566);
            this.palRight.TabIndex = 1;
            this.palRight.Text = "qPanel1";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Shape = this.qsButton;
            this.btnThoat.Image = null;
            this.btnThoat.Location = new System.Drawing.Point(22, 128);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintTransparentBackground = true;
            this.btnThoat.Size = new System.Drawing.Size(75, 45);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // qsButton
            // 
            this.qsButton.BaseShapeType = Qios.DevSuite.Components.QBaseShapeType.RibbonShowDialogButton;
            this.qsButton.ContentBounds = new System.Drawing.Rectangle(2, 2, 14, 11);
            this.qsButton.Items.Add(new Qios.DevSuite.Components.QShapeItem(-5F, 11F, ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left))), true));
            this.qsButton.Items.Add(new Qios.DevSuite.Components.QShapeItem(55F, 31F, ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))), true));
            this.qsButton.Items.Add(new Qios.DevSuite.Components.QShapeItem(12F, -5F, ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))), true));
            this.qsButton.Items.Add(new Qios.DevSuite.Components.QShapeItem(22F, 12F, 20F, 19F, 19F, 20F, ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))), true));
            this.qsButton.Items.Add(new Qios.DevSuite.Components.QShapeItem(12F, 22F, ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))), true));
            // 
            // btnDongY
            // 
            this.btnDongY.Appearance.Shape = this.qsButton;
            this.btnDongY.Image = null;
            this.btnDongY.Location = new System.Drawing.Point(22, 42);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.PaintTransparentBackground = true;
            this.btnDongY.Size = new System.Drawing.Size(75, 45);
            this.btnDongY.TabIndex = 0;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // palTop_Center
            // 
            this.palTop_Center.Controls.Add(this.palCenter);
            this.palTop_Center.Controls.Add(this.palTop);
            this.palTop_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palTop_Center.Location = new System.Drawing.Point(0, 28);
            this.palTop_Center.Name = "palTop_Center";
            this.palTop_Center.Size = new System.Drawing.Size(374, 566);
            this.palTop_Center.TabIndex = 2;
            this.palTop_Center.Text = "qPanel2";
            // 
            // palCenter
            // 
            this.palCenter.Controls.Add(this.DataGridView);
            this.palCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palCenter.Location = new System.Drawing.Point(0, 93);
            this.palCenter.Name = "palCenter";
            this.palCenter.Size = new System.Drawing.Size(372, 471);
            this.palCenter.TabIndex = 1;
            this.palCenter.Text = "qPanel2";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(370, 469);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            this.DataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_KeyDown);
            // 
            // palTop
            // 
            this.palTop.Controls.Add(this.qMarkupLabel3);
            this.palTop.Controls.Add(this.txtTenSearch);
            this.palTop.Controls.Add(this.qMarkupLabel2);
            this.palTop.Controls.Add(this.txtMaSearch);
            this.palTop.Controls.Add(this.qMarkupLabel1);
            this.palTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.palTop.Location = new System.Drawing.Point(0, 0);
            this.palTop.Name = "palTop";
            this.palTop.Size = new System.Drawing.Size(372, 93);
            this.palTop.TabIndex = 0;
            this.palTop.Text = "qPanel1";
            // 
            // qMarkupLabel3
            // 
            this.qMarkupLabel3.Location = new System.Drawing.Point(183, 45);
            this.qMarkupLabel3.MarkupText = "Tên";
            this.qMarkupLabel3.Name = "qMarkupLabel3";
            this.qMarkupLabel3.Size = new System.Drawing.Size(34, 15);
            this.qMarkupLabel3.TabIndex = 4;
            // 
            // txtTenSearch
            // 
            this.txtTenSearch.Location = new System.Drawing.Point(214, 43);
            this.txtTenSearch.Name = "txtTenSearch";
            this.txtTenSearch.Size = new System.Drawing.Size(113, 21);
            this.txtTenSearch.TabIndex = 3;
            this.txtTenSearch.TextChanged += new System.EventHandler(this.txtTenSearch_TextChanged);
            // 
            // qMarkupLabel2
            // 
            this.qMarkupLabel2.Location = new System.Drawing.Point(16, 45);
            this.qMarkupLabel2.MarkupText = "Mã";
            this.qMarkupLabel2.Name = "qMarkupLabel2";
            this.qMarkupLabel2.Size = new System.Drawing.Size(34, 15);
            this.qMarkupLabel2.TabIndex = 2;
            // 
            // txtMaSearch
            // 
            this.txtMaSearch.Location = new System.Drawing.Point(48, 42);
            this.txtMaSearch.Name = "txtMaSearch";
            this.txtMaSearch.Size = new System.Drawing.Size(113, 21);
            this.txtMaSearch.TabIndex = 1;
            this.txtMaSearch.TextChanged += new System.EventHandler(this.txtMaSearch_TextChanged);
            // 
            // qMarkupLabel1
            // 
            this.qMarkupLabel1.Location = new System.Drawing.Point(11, 9);
            this.qMarkupLabel1.MarkupText = "TÌM KIẾM";
            this.qMarkupLabel1.Name = "qMarkupLabel1";
            this.qMarkupLabel1.Size = new System.Drawing.Size(75, 15);
            this.qMarkupLabel1.TabIndex = 0;
            // 
            // frmTimKiem
            // 
            this.ClientSize = new System.Drawing.Size(494, 594);
            this.Controls.Add(this.palTop_Center);
            this.Controls.Add(this.palRight);
            this.Controls.Add(this.qRibbonCaption1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM - SEARCH";
            this.Load += new System.EventHandler(this.frmLoad);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
            this.palRight.ResumeLayout(false);
            this.palTop_Center.ResumeLayout(false);
            this.palCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.palTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
        private Qios.DevSuite.Components.QPanel palRight;
        private Qios.DevSuite.Components.QPanel palTop_Center;
        private Qios.DevSuite.Components.QPanel palCenter;
        private Qios.DevSuite.Components.QPanel palTop;
        private System.Windows.Forms.DataGridView DataGridView;
        private Qios.DevSuite.Components.QButton btnThoat;
        private Qios.DevSuite.Components.QButton btnDongY;
        private Qios.DevSuite.Components.QShape qsButton;
        private Qios.DevSuite.Components.QMarkupLabel qMarkupLabel3;
        private Qios.DevSuite.Components.QTextBox txtTenSearch;
        private Qios.DevSuite.Components.QMarkupLabel qMarkupLabel2;
        private Qios.DevSuite.Components.QTextBox txtMaSearch;
        private Qios.DevSuite.Components.QMarkupLabel qMarkupLabel1;
    }
}