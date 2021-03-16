using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Runtime.Serialization;

namespace Student.Models
{
    [DataContract]
    public class StudentInfor : ApiController
    {
        [DataMember(Name = "MSSV")]
        public string MSSV { get; set; }
        [DataMember(Name = "HoTen")]
        public string HoTen { get; set; }
        [DataMember(Name = "Lop")]
        public string Lop { get; set; }
    }
}