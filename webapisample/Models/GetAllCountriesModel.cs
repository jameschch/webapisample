using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{

    public class GetAllCountriesModel : SearchModel
    {

        [Display(Name = "GetAllCountriesModel_ZoneId")]
        public int? ZoneId { get; set; }

    }

}