﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNA_Project.Entity;
using VNA_Project.BIZ;
using Qios.DevSuite.Components;

namespace VNA_Project.DANHMUC.LyDoTangGiamTaiSanFolder
{
    public partial class frmDMLyDoTangGiamTaiSan : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        #region khai báo
        public static List<LyDoTangGiamTaiSan> Ldata = new List<LyDoTangGiamTaiSan>();
        int vtIndex = 0;    //vị trí dòng cell đang được chọn trong datagridview
        #endregion

        public frmDMLyDoTangGiamTaiSan()
        {
            InitializeComponent();
        }

        private void frmLoad(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Function
        void FixDataGirdView()
        {
            FixDataGirdView(DataGridView);
        }
        void FixDataGirdView(System.Windows.Forms.DataGridView DataGridView)
        {
            for (int j = 1; j < DataGridView.ColumnCount; j++) DataGridView.Columns[j].Visible = false;
            DataGridView.ReadOnly = true;

            DataGridView.Columns["LoaiTangGiamTaiSanVIEW"].HeaderText = "Loại lý do tăng giảm tài sản";
            DataGridView.Columns["MaLyDoTangGiamTaiSan"].HeaderText = "Mã lý do tăng giảm tài sản";
            DataGridView.Columns["TenLyDoTangGiamTaiSan"].HeaderText = "Tên tên lý do tăng giảm tài sản";

            DataGridView.Columns["LoaiTangGiamTaiSan"].Visible = false;
            DataGridView.Columns["LoaiTangGiamTaiSanVIEW"].Visible = true;
            DataGridView.Columns["MaLyDoTangGiamTaiSan"].Visible = true;
            DataGridView.Columns["TenLyDoTangGiamTaiSan"].Visible = true;

            DataGridView.Columns["LoaiTangGiamTaiSanVIEW"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DataGridView.Columns["MaLyDoTangGiamTaiSan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DataGridView.Columns["TenLyDoTangGiamTaiSan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AllowUserToResizeRows = false;
            DataGridView.RowHeadersVisible = false;
        }
        #endregion

        #region Nghiệp vụ
        private void HienThi()
        {
            Ldata = LyDoTangGiamTaiSanBiz.getListLyDoTangGiamTaiSan();
            DataGridView.DataSource = Ldata.ToArray();
            FixDataGirdView();
        }
        private void Them()
        {
            try
            {
                frmXuLyDMLyDoTangGiamTaiSan frm = new frmXuLyDMLyDoTangGiamTaiSan();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                HienThi();
                if (Ldata.Count != 0) DataGridView.Rows[vtIndex == -1 ? 0 : vtIndex].Selected = true;   //nếu ko có phần tử nào thì thôi
            }
            catch (Exception ex)
            {
                MSG.Error(ex);
            }
        }
        private void Sua()
        {
            try
            {
                if (vtIndex != -1)  //khi click lên tiêu đề header của datagrid thì bỏ qua
                {
                    frmXuLyDMLyDoTangGiamTaiSan frm = new frmXuLyDMLyDoTangGiamTaiSan(DataGridView.Rows[vtIndex]);
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog();
                    HienThi();
                    if (Ldata.Count != 0) DataGridView.Rows[vtIndex == -1 ? 0 : vtIndex].Selected = true;   //nếu ko có phần tử nào thì thôi
                }
            }
            catch (Exception ex)
            {
                MSG.Error(ex);
            }
        }
        private void Xoa()
        {
            try
            {
                if (vtIndex != -1)  //khi click lên tiêu đề header của datagrid thì bỏ qua
                {
                    if (MSG.BanCoChacChanMuonXoaKhong() == System.Windows.Forms.DialogResult.Yes)
                    {
                        LyDoTangGiamTaiSan temp = Utils.DataGridViewRow_to_LyDoTangGiamTaiSan(DataGridView.Rows[vtIndex]);
                        int kq = LyDoTangGiamTaiSanBiz.DeleteLyDoTangGiamTaiSan(temp);
                        //if (kq > 0) MSG.XoaThanhCong();
                        //else MSG.XoaThatBai();
                        if (kq <= 0) MSG.XoaThatBai();
                        HienThi();
                    }
                }
            }
            catch (Exception ex)
            {
                MSG.Error(ex);
            }
        }
        #endregion

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Khi click vào Datagridview thì lấy vị trí của dòng vừa click vào và lưu lại vào biến vtIndex
            vtIndex = e.RowIndex;
        }
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Sua();
        }

        private void txtMaSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<LyDoTangGiamTaiSan> Ltemp = new List<LyDoTangGiamTaiSan>();
                string search = txtMaSearch.Text.ToUpper();
                foreach (LyDoTangGiamTaiSan item in Ldata)
                {
                    if (item.MaLyDoTangGiamTaiSan.ToUpper().Contains(search)) Ltemp.Add(item);
                }
                DataGridView.DataSource = Ltemp.ToArray();
                FixDataGirdView();
            }
            catch (Exception ex)
            {
                MSG.Error(ex);
            }
        }

        private void txtTenSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<LyDoTangGiamTaiSan> Ltemp = new List<LyDoTangGiamTaiSan>();
                string search = txtTenSearch.Text.ToUpper();
                foreach (LyDoTangGiamTaiSan item in Ldata)
                {
                    if (item.TenLyDoTangGiamTaiSan.ToUpper().Contains(search)) Ltemp.Add(item);
                }
                DataGridView.DataSource = Ltemp.ToArray();
                FixDataGirdView();
            }
            catch (Exception ex)
            {
                MSG.Error(ex);
            }
        }
    }
}