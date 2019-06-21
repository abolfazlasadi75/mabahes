using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FMFMVC.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string EnglishName { get; set; }
        public string PersianName { get; set; }
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}