using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDoiTuongVuAn.Entity
{
    public partial class CanBo 
    {

       
        private int _maCB;
        private string _hoTen;
        private string _chucVu;
        private string _diaChi;
        private string _dienThoai;
      
        public int MaCB
        {
            get { return _maCB; }
            set { _maCB = value;}
        }
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value;}
        }
        public string ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value;}
        }
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value;}
        }
        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value;}
        }
    }
}
