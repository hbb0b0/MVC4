using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Step1
{
    public class Customer
    {
        public string CustomerID
        {
            get;
            set;
        }

        public int CompanyName
        {
            get;
            set;
        }
    }
}
