using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_SOF304
{
    public class SinhVienService
    {
        private List<SinhVien> _sinhViens;

        public SinhVienService()
        {
            _sinhViens = new List<SinhVien>();
        }

        public void ThemSinhVien(SinhVien sv)
        {
            _sinhViens.Add(sv);
        }

        public bool XoaSinhVien(string maSV)
        {
            var sv = _sinhViens.FirstOrDefault(s => s.MaSV == maSV);
            if (sv != null)
            {
                _sinhViens.Remove(sv);
                return true;
            }
            return false;
        }

        public List<SinhVien> LayDanhSachSinhVien()
        {
            return _sinhViens;
        }
    }
}
