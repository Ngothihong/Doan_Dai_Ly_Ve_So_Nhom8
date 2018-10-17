using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dai_Ly_Ve_So_1.DAL
{
    class DALPhieuChi
    {
        public List<PhieuChi> GetAll()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhieuChis.ToList();
        }

        public PhieuChi GetByMa(String ma)
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhieuChis.Where(a => a.MaPhieuChi == ma).SingleOrDefault();
        }
        public void insert_PhieuChi(PhieuChi a)
        {
            QLVESODataContext db = new QLVESODataContext();
            db.PhieuChis.InsertOnSubmit(a);
            db.SubmitChanges();

        }
        public void update_PhieuChi(PhieuChi a)
        {
            QLVESODataContext db = new QLVESODataContext();
            PhieuChi b = new PhieuChi();
            b = db.PhieuChis.Where(ax => ax.MaPhieuChi == a.MaPhieuChi).Single();
            b.MaPhatHanh = a.MaPhatHanh;
            b.Ngay = a.Ngay;
            b.NoiDung = a.NoiDung;
            b.SoTien = a.SoTien;
            db.SubmitChanges();
        }
        public void delete_PhieuChi(string ma)
        {
            QLVESODataContext db = new QLVESODataContext();
            PhieuChi b = new PhieuChi();
            b = db.PhieuChis.Where(ax => ax.MaPhieuChi == ma).Single();
            db.PhieuChis.DeleteOnSubmit(b);
            db.SubmitChanges();
        }
    }
}
