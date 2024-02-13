using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DPV.Models
{
    // Since we will be using these classes in more or less the same way it made more sense to keep then all together 

    public class TokenRequest 
    {
        public string Id { get; set; }
        public Dictionary<string,string> Data { get; set; }
    }

     public class TokenResponse 
    {
        public string Id { get; set; }
        public Dictionary<string,string> Data { get; set; }
    }
    
     public class DetokenizeResponse 
    {
        public string Id { get; set; }
        public Dictionary<string,string> Data { get; set; }
    }

    public class TokenData 
    {
        public bool Found { get; set; }
        public string Value { get; set; }
    }
}