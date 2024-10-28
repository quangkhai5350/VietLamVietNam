using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViecLamViecNam.Models;
namespace ViecLamViecNam.DAO
{
    public class Video_Dao
    {
        //public static Object GetList_Skip(ModelCty db, int Sec, int pageSize)
        //{
        //    var model = db.Videos.Where(cc => cc.IsVisible == true && cc.PortalId == 81)
        //                .OrderByDescending(cc => cc.Fixdate).ThenByDescending(cc => cc.VideoId)
        //                .Skip(Sec * pageSize)
        //                .Take(pageSize)
        //                .ToList();
        //    return model;
        //}
        //public static Object GetList_NoSkip(ModelCty db, int Sec, int pageSize)
        //{
        //    var model = db.Videos.Where(cc => cc.IsVisible == true && cc.PortalId == 81)
        //                .OrderByDescending(cc => cc.Fixdate).ThenByDescending(cc => cc.VideoId)
        //                .Take(pageSize * (Sec + 1))
        //                .ToList();
        //    return model;
        //}
    }
}