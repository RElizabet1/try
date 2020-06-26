using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Countries.Open
{
    public class Open
    {
        public string  name { get; set; }
        public string  alpha3Code { get; set; }
            public string  capital { get; set; }
            public double  area { get; set; }
            public double  population{ get; set; }
            public string region { get; set; }            
    }
   
}
