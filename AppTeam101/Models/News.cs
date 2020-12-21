using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTeam101.Models
{
    public class News
    {
        public int Id { get; set; }
        public string News_Name { get; set; }
        public string About { get; set; }
        public string Date { get; set; }
        public string UrlImg { get; set; }
    }
}