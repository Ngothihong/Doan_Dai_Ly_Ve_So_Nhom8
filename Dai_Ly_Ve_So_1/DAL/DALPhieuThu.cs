using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dai_Ly_Ve_So_1.DAL
{
    class DALPhieuThu
    {
        public List<PhieuThu> GetAll()
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhieuThus.ToList();
        }

        public PhieuThu GetByMa(String ma)
        {
            QLVESODataContext db = new QLVESODataContext();
            return db.PhieuThus.Where(a => a.MaPhieuThu== ma).SingleOrDefault();
        }
        public void insert_PhieuThu(PhieuThu a)
        {
            QLVESODataContext db = new QLVESODataContext();
            db.PhieuThus.InsertOnSubmit(a);
            db.SubmitChanges();

        }
        public void update_PhieuThu(PhieuThu a)
        {
            QLVESODataContext db = new QLVESODataContext();
            PhieuThu b = new PhieuThu();
            b = db.PhieuThus.Where(ax => ax.MaPhieuThu == a.MaPhieuThu).Single();
            b.MaCongNo = a.MaCongNo;
            b.NgayThu =a.NgayThu;
            b.SoTienNop = a.SoTienNop;
            b.Flag = a.Flag;
            db.SubmitChanges();
        }
        public void delete_PhieuThu(string ma)
        {
            QLVESODataContext db = new QLVESODataContext();
           PhieuThu b =  db.PhieuThus.Where(a => a.MaPhieuThu == ma).Single();
            db.PhieuThus.DeleteOnSubmit(b);
            db.SubmitChanges();
        }
    }
}
