using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDoiTuongVuAn.Entity
{
    public partial class LoaiHinhViPham
    {
        private int _maLH;
        private string _tenLH;
        private string _moTa;
        public int MaLH
        {
            get { return _maLH; }
            set { _maLH = value; }
        }
        public string TenLH
        {
            get { return _tenLH; }
            set { _tenLH = value; }
        }
        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        public LoaiHinhViPham() { }
    }
}
