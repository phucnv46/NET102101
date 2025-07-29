using KetNoiDatabaseNhieuBang.Extentions;
using KetNoiDatabaseNhieuBang.Models;
using KetNoiDatabaseNhieuBang.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiDatabaseNhieuBang.Views
{
    public partial class FormQLS : Form
    {
        GenericRepository<Sach> _repository;
        GenericRepository<TacGium> _repositoryTG;
        List<Sach> saches = new List<Sach>();
        public FormQLS()
        {
            InitializeComponent();
            _repository = new GenericRepository<Sach>();
            _repositoryTG = new GenericRepository<TacGium>();
            LoadControl();
        }


        private void LoadControl()
        {
            saches = _repository.GetAllWithIncludes(nameof(Sach.MaTacGiaNavigation));
            dataGridView1.DataSource = saches;
            comboBoxTG.DataSource = _repositoryTG.GetAll();
            comboBoxTG.DisplayMember = nameof(TacGium.HoTen);
            comboBoxTG.ValueMember = nameof(TacGium.MaTacGia);
            comboBoxSX.DataSource = new List<dynamic>(){
                 new {TT = nameof(Sach.MaSach), HT= "Mã sách" },
                 new {TT = nameof(Sach.TieuDe), HT= "Tên sách" },
                 new {TT = nameof(Sach.NamXuatBan), HT= "Năm xuất bản" },
                 new {TT = nameof(Sach.SoLuongTonKho), HT= "Số lượng" },
                 new {TT = nameof(Sach.TenTacGia), HT= "Tên tác giả" },

            };

            comboBoxSX.DisplayMember = "HT";
            comboBoxSX.ValueMember = "TT";

            comboBoxCSX.DataSource = new List<dynamic>() {
                new { Key = "ASC", HT = "Tăng"  },
                new { Key = "DESC", HT = "Giảm"  },
            };

            comboBoxCSX.DisplayMember = "Key";
            comboBoxCSX.ValueMember = "HT";

        }

        private void BindingToControl(Sach sach)
        {
            textBoxMaSach.Text = sach.MaSach.ToString();
            textBoxTen.Text = sach.TieuDe;
            textBoxISBN.Text = sach.Isbn;
            comboBoxTG.SelectedItem = sach.MaTacGiaNavigation;
            numericUpDownNamSX.Value = (decimal)sach.NamXuatBan;
            numericUpDownSL.Value = (decimal)sach.SoLuongTonKho;

        }

        private void BindingToModel(Sach sach)
        {

            sach.TieuDe = textBoxTen.Text.Trim();
            sach.Isbn = textBoxISBN.Text.Trim();
            sach.NamXuatBan = (int)numericUpDownNamSX.Value;
            sach.MaTacGia = (int)comboBoxTG.SelectedValue;
            sach.SoLuongTonKho = (int)numericUpDownSL.Value;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)  // Load dữ liệu từ dòng lên controls
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Sach sach && sach != null)
            {
                BindingToControl(sach);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            BindingToModel(sach);
            _repository.Add(sach);
            LoadControl();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Sach sach && sach != null)
            {
                BindingToModel((Sach)sach);
                _repository.Update(sach);
                LoadControl();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Sach sach && sach != null)
            {

                _repository.Delete(sach);
                LoadControl();
            }
        }

        private void comboBoxCSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thuocTinh = ((dynamic)comboBoxSX.SelectedItem).TT;
            string chieuSapXep = ((dynamic)comboBoxCSX.SelectedItem).Key;

            dataGridView1.DataSource = saches.SapXepExp(thuocTinh, chieuSapXep);
        }

        private void buttonLM_Click(object sender, EventArgs e)
        {
            textBoxMaSach.ResetText();
            textBoxTen.ResetText();
            textBoxISBN.ResetText();
            comboBoxCSX.SelectedIndex = 0;
            comboBoxSX.SelectedIndex = 0;
            comboBoxTG.SelectedIndex = 0;
            numericUpDownNamSX.Value = 0;
            numericUpDownSL.Value = 0;
            LoadControl();
        }

        private void textBoxTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == 13)
            {
                dataGridView1.DataSource = saches.TimKiem(textBoxTM.Text.Trim());
            }
        }
    }
}
