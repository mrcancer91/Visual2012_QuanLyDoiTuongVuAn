using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDoiTuongVuAn.Entity
{
    public partial class DoiTuong
    {
        private int _maDT;
        private string _hoTen;
        private DateTime _ngaySinh;
        private string _queQuan;
        private string _gioiTinh;

        public DoiTuong()
        { }
        public int MaDT
        {
            get { return _maDT; }
            set { _maDT = value; }
        }
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        public string QueQuan
        {
            get { return _queQuan; }
            set { _queQuan = value; }
        }
        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

    }
}
