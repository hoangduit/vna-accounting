﻿namespace GUI
{
    partial class frmBaoCaoXuatHang
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
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptViewer
            // 
            this.rptViewer.ActiveViewIndex = -1;
            this.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.SelectionFormula = "";
            this.rptViewer.Size = new System.Drawing.Size(631, 458);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptViewer.ViewTimeSelectionFormula = "";
            // 
            // frmBaoCaoXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 458);
            this.Controls.Add(this.rptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBaoCaoXuatHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmBaoCaoXuatHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;

    }
}