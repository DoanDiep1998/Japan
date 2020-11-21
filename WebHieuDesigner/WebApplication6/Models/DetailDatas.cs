using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class DetailDatas
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  List<SubCategory> lstSubCategory { get; set; }
    }
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  List<Items>  lstItems{ get; set; }
      
    }
        public class Items
        {
            public int Id { get; set; }
            public string Tile { get; set; }
            public string Contents { get; set; }
            public string Images { get; set; }
            public DateTime? CreateDate { get; set; }
        }
    }