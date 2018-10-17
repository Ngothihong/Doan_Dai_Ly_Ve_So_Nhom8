using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dai_Ly_Ve_So_1.DAL
{
    class DALPhatHanh
    {
        public List<PhatHanh> GetAll()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhatHanhs.ToList();
        }
        public List<PhanPhoi> GetAll_PhanPhoi()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhanPhois.ToList();
        }
        public PhatHanh GetByMa(String ma)
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhatHanhs.Where(a => a.MaPhatHanh == ma).SingleOrDefault();
        }
        public bool Exits_Phathanh_byMa(string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<String> get_MaPhatHanh()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhatHanhs.AsEnumerable().Select(s => s.MaPhatHanh);

        }
        public IEnumerable<String> get_Madaily()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.DaiLies.AsEnumerable().Select(s => s.MaDaiLy);

        }
        public IEnumerable<String> get_Maveso()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.LoaiVesos.AsEnumerable().Select(s => s.MaLoaiVeSo);

        }
        public void insert_Phathanh(PhatHanh a)
        {
            QLVESODataContext db = new QLVESODataContext();
            db.PhatHanhs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void update_PhatHanh(PhatHanh a)
        {
            QLVESODataContext db = new QLVESODataContext();
            PhatHanh b = db.PhatHanhs.Where(x => x.MaPhatHanh == a.MaPhatHanh).Single();
            b.NgayPhatHanh = a.NgayPhatHanh;
            b.SLBan = SL_pp(b.MaPhatHanh) - SL_trave(b.MaPhatHanh);
            b.SoLuong = a.SoLuong;
            b.DoanhThuDPH = a.DoanhThuDPH;
            b.HoaHong = a.HoaHong;
            b.TienThanhToan = a.TienThanhToan;
            db.SubmitChanges();
        }
        public void delete_Phathanh(string Maphathanh)
        {
            QLVESODataContext db = new QLVESODataContext();
            PhatHanh b = db.PhatHanhs.Where(a => a.MaPhatHanh == Maphathanh).Single();
            db.PhatHanhs.DeleteOnSubmit(b);
            db.SubmitChanges();

        }
        public float Tinh_Tien_Thanh_Toan(float Doanhthu, float hoahong)
        {
            return (Doanhthu - Doanhthu * hoahong);
        }
        public int SL_pp(string maphathanh)
        {
            QLVESODataContext db = new QLVESODataContext();
            int SLpp = 0;


            var query = from p in db.PhanPhois
                        where p.MaPhatHanh == maphathanh
                        select p.SoLuongppchoDaiLy;

            if (query.Count() > 0)
            {
                SLpp = Convert.ToInt32(query.Sum());
            }
            return SLpp;
        }
        public int SL_trave(string maphathanh)
        {
            QLVESODataContext db = new QLVESODataContext();
            int SLpp = 0;

            var query1 = from p in db.PhanPhois
                         where p.MaPhatHanh == maphathanh
                         select p.SoLuongvetra;
            if (query1.Count() > 0)
            {
                SLpp = Convert.ToInt32(query1.Sum());

            }
                return (SLpp);


        }
            //public IEnumerable<CongNo> GetCongNosbyMaDaily(String ma)
            //{
            //    QLVESODataContext db = new QLVESODataContext();
            //    return db.CongNos.Where(a => a.MaDaiLy == ma).ToList();
            //}
        
    }
}
