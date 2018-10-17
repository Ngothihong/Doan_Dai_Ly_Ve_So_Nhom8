using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dai_Ly_Ve_So_1.DAL;

namespace Dai_Ly_Ve_So_1.BUS
{
    class BusPhieuChi
    {
        DALPhieuChi dALPhieuChi = new DALPhieuChi();
        public List<PhieuChi> GetAll()
        {
            return dALPhieuChi.GetAll();
        }

        public PhieuChi GetByMa(String ma)
        {
            return dALPhieuChi.GetByMa(ma);
        }
        public void insert_PhieuChi(PhieuChi a)
        {
            dALPhieuChi.insert_PhieuChi(a);

        }
        public void update_PhieuChi(PhieuChi a)
        {
            dALPhieuChi.update_PhieuChi(a);
        }
        public void delete_PhieuChi(string a)
        {
            dALPhieuChi.delete_PhieuChi(a);
        }
    }
}
