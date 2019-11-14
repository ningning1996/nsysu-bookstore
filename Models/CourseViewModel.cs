using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using PagedList;


namespace 宏盈.Models
{
 
        public class CourseRetrieveViewModel
        {
            public IPagedList<COURSE> courses { get; set; }
            public IPagedList<DEPARTMENT> departments { get; set; }

            
        }

        public class BuybookViewModel
        {   
            public COURSE course { get; set; }
            public List<BUYBOOK> Buybooks { get; set; }
            public BUYBOOK Buybook { get; set; }
        }
        public class BuybookUpdateViewModel
        {   
            public BUYBOOK Buybook { get; set; }
        }
}