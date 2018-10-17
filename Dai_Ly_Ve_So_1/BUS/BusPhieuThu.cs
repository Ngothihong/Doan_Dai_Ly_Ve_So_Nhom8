using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dai_Ly_Ve_So_1.DAL;

namespace Dai_Ly_Ve_So_1.BUS
{
    class BusPhieuThu
    {
        DALPhieuThu dALPhieuThu = new DALPhieuThu();
        public List<PhieuThu> GetAll()
        {
            return dALPhieuThu.GetAll();
        }

        public PhieuThu GetByMa(String ma)
        {
            return dALPhieuThu.GetByMa(ma);
        }
        public void insert_PhieuThu(PhieuThu a)
        {
            dALPhieuThu.insert_PhieuThu(a);

        }
        public void update_PhieuThu(PhieuThu a)
        {
            dALPhieuThu.update_PhieuThu(a);
        }
        public void delete_PhieuThu(string a)
        {
            dALPhieuThu.delete_PhieuThu(a);
        }
    }
}
