using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskNunit.Test_Model
{
    public class UserInfoTestModel
    {
#pragma warning disable


        public string Availability { get; set; }
            public string Hours { get; set; }

            [JsonProperty("Earn Target")]
            public string EarnTarget { get; set; }
        


    }
}
