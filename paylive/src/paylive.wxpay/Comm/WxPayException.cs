using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paylive.wxpay.Comm
{
    public class WxPayException : Exception
    {
        public WxPayException(string msg) : base(msg)
        {

        }
    }
}
