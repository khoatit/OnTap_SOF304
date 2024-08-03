using OnTap_SOF304;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class Test_SinhVien
    {
        private SinhVienService _service;
        [SetUp]
        public void Setup()
        {
            _service = new SinhVienService();
        }
        //Test Thêm
        [Test]
        public void Them1()
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", 20, 7.5f, 3, "CNTT");
            _service.ThemSinhVien(sv);

            var danhSach = _service.LayDanhSachSinhVien();
            Assert.AreEqual(1, danhSach.Count);
            Assert.AreEqual(sv, danhSach[0]);
        }
        [Test]
        public void Them2()
        {
            Assert.Throws<System.ArgumentNullException>(() => _service.ThemSinhVien(null));
        }

        [Test]
        public void Them3()
        {
            var sv1 = new SinhVien("SV01", "Nguyen Van A", 20, 7.5f, 3, "CNTT");
            var sv2 = new SinhVien("SV01", "Tran Thi B", 22, 8.0f, 5, "KT");

            _service.ThemSinhVien(sv1);
            Assert.Throws<System.ArgumentException>(() => _service.ThemSinhVien(sv2));
        }

        [Test]
        public void Them4()
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", 15, 7.5f, 3, "CNTT");
            Assert.Throws<System.ArgumentException>(() => _service.ThemSinhVien(sv));
        }

        [Test]
        public void Them5()
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", 20, -1.0f, 3, "CNTT");
            Assert.Throws<System.ArgumentException>(() => _service.ThemSinhVien(sv));
        }

        [Test]
        public void Them6()
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", 20, 9.0f, 3, "CNTT");
            _service.ThemSinhVien(sv);

            var danhSach = _service.LayDanhSachSinhVien();
            Assert.AreEqual(1, danhSach.Count);
            Assert.AreEqual(sv, danhSach[0]);
        }

        [Test]
        public void Them7()
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", 20, 7.5f, 0, "CNTT");
            Assert.Throws<System.ArgumentException>(() => _service.ThemSinhVien(sv));
        }

        [Test]
        public void Them8()
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", 20, 7.5f, 6, "CNTT");
            _service.ThemSinhVien(sv);

            var danhSach = _service.LayDanhSachSinhVien();
            Assert.AreEqual(1, danhSach.Count);
            Assert.AreEqual(sv, danhSach[0]);
        }

        [Test]
        public void Them9()
        {
            var sv = new SinhVien("", "Nguyen Van A", 20, 7.5f, 3, "CNTT");
            Assert.Throws<System.ArgumentException>(() => _service.ThemSinhVien(sv));
        }

        [Test]
        public void Them10()
        {
            var sv = new SinhVien("SV01", "", 20, 7.5f, 3, "CNTT");
            Assert.Throws<System.ArgumentException>(() => _service.ThemSinhVien(sv));
        }
        //Test Xóa 
        [Test]
        public void Xoa1()
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", 20, 7.5f, 3, "CNTT");
            _service.ThemSinhVien(sv);
            var result = _service.XoaSinhVien("SV01");

            Assert.IsTrue(result);
            var danhSach = _service.LayDanhSachSinhVien();
            Assert.AreEqual(0, danhSach.Count);
        }

        [Test]
        public void Xoa2()
        {
            var result = _service.XoaSinhVien("SV01");
            Assert.IsFalse(result);
        }
        [Test]
        public void Xoa3()
        {
            Assert.Throws<System.ArgumentException>(() => _service.XoaSinhVien(""));
        }   
    }
}
