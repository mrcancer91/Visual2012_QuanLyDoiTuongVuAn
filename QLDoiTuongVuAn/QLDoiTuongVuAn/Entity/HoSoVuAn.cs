using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDoiTuongVuAn.Entity
{
    public partial class HoSoVuAn
    {
        private int _maHoSo;
        private int _maCB;
        private int _maDT;
        private int _maLH;
        private DateTime _ngayXayRa;
        private DateTime _ngayLap;
        private string _diaDiem;
        private string _toiDanh;
        private string _nguoiBiHai;
        private string _thietHai;
        private string _hinhThucXuLy;
        private DateTime _ngayXuLy;
        private string _ghiChu;

        public HoSoVuAn()
        { }

        public int MaHoSo
        {
            get { return _maHoSo; }
            set { _maHoSo = value; }
        }
        public int MaCB
        {
            get { return _maCB; }
            set { _maCB = value; }
        }
        public int MaDT
        {
            get { return _maDT; }
            set { _maDT = value; }
        }
        public int MaLH
        {
            get { return _maLH; }
            set { _maLH = value; }
        }
        public DateTime NgayXayRa
        {
            get { return _ngayXayRa; }
            set { _ngayXayRa = value; }
        }
        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }
        public string DiaDiem
        {
            get { return _diaDiem; }
            set { _diaDiem = value; }
        }
        public string ToiDanh
        {
            get { return _toiDanh; }
            set { _toiDanh = value; }
        }
        public string NguoiBiHai
        {
            get { return _nguoiBiHai; }
            set { _nguoiBiHai = value; }
        }
        public string ThietHai
        {
            get { return _thietHai; }
            set { _thietHai = value; }
        }
        public string HinhThucXuLy
        {
            get { return _hinhThucXuLy; }
            set { _hinhThucXuLy = value; }
        }
        public DateTime NgayXuLy
        {
            get { return _ngayXuLy; }
            set { _ngayXuLy = value; }
        }
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
    }
}
