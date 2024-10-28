using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViecLamViecNam.Models;

namespace ViecLamViecNam.DAO
{
    public class NTV_KhachHang_Dao
    {
        ModelCty dbc = new ModelCty();
        
        public KhachHang GetNTV_ByKHID(int KH_ID)
        {
            var mode = dbc.KhachHangs.Find(KH_ID);
             
            return mode;
        }
    }
}