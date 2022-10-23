using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DarulAman.Models;

namespace DarulAman.Utills
{
    public class BaseHelper
    {
        public static tbl_Admin Currentdonation { get; set; }
        public static tbl_Admin Currentevent { get; set; }
        public static tbl_Admin Currentteachingquran { get; set; }
        public static tbl_Admin Currentmarriage { get; set; }
        public static tbl_Admin Currentfuneral { get; set; }
        public static tbl_Admin Currenttranslationservices { get; set; }
        public static tbl_Admin Currentmember { get; set; }

    }
}