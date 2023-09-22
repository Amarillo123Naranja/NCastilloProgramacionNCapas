using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Result
    {

        public string ErrorMessage { set; get; }
        public bool Correct { set; get; }
        public object Object { set; get; }  
        public List<object> Objects { set; get; }
        public Exception Ex { set; get; }   



    }
}
