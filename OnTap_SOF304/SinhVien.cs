using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_SOF304
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public float DiemTrungBinh { get; set; }
        public int KyHoc { get; set; }
        public string ChuyenNganh { get; set; }
        public SinhVien()
        {
            
        }

        public SinhVien(string maSV, string ten, int tuoi, float diemTrungBinh, int kyHoc, string chuyenNganh)
        {
            MaSV = maSV;
            Ten = ten;
            Tuoi = tuoi;
            DiemTrungBinh = diemTrungBinh;
            KyHoc = kyHoc;
            ChuyenNganh = chuyenNganh;
        }
    }
}
