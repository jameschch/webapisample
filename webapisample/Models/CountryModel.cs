using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{

    [DataContract(Name = "Country", Namespace = "")]
    public class CountryModel
    {

        [DataMember]
        public string CountryCode { get; set; }
        [DataMember]
        public string CountryName { get; set; }

    }
}