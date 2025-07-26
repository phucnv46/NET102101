using KetNoiDatabaseNhieuBang.Models;
using KetNoiDatabaseNhieuBang.Repositories;
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
    public partial class QuanLySach : UserControl
    {
        GenericRepository<Sach> _repository;
        GenericRepository<TacGium> _repositoryTG;
        public QuanLySach()
        {
            InitializeComponent();
            _repository = new GenericRepository<Sach>();
            _repositoryTG = new GenericRepository<TacGium>();
            LoadControl();
        }


        private void LoadControl()
        {
            dataGridView1.DataSource = _repository.GetAllWithIncludes(nameof(Sach.MaTacGiaNavigation));
            comboBoxTG.DataSource = _repositoryTG.GetAll();
            comboBoxTG.DisplayMember = nameof(TacGium.HoTen);
            comboBoxTG.ValueMember = nameof(TacGium.MaTacGia);
        }



    }
}
