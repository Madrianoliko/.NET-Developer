using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009___Classes_and_Custom_Types.Accounting
{
    //public record Account
    //{
    //    private string accountNumber;

    //    public string AccountNumber
    //    {
    //        get { return accountNumber ;}
    //        set
    //        {
    //            accountNumber = value ;
    //        }
    //    }
    //}
    public record Account(string AccountNumber);
}
