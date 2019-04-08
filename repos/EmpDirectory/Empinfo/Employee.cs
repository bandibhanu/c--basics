using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empinfo
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmpId { get; set; }
       public string EmpPhone { get; set; }
      public  string EmpAddress { get; set; }
        private string _empTweetId;
        public string EmpTweetId {
            get { return _empTweetId; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _empTweetId = value;
                }
                else
                {
                    throw new Exception("Start with @");
                }
            }
             }

    }
}
