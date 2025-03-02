using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairOdev
{
    public class Corporate : Customer
    {
        private string CompanyName { get; set; }
        public void SetCompanyName(string CompanyName) { CompanyName = CompanyName; }
        public string GetCompanyName() { return CompanyName; }

    }
}
