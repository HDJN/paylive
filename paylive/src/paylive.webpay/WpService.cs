using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using paylive.core;

namespace paylive.webpay
{
    public class WpService : Plug
    {
        public WpService()
        {
            Url = "/webpay/index";
            Ua = "web";
            Descrpion = "webpay";
        }

        public override string Run()
        {
            throw new NotImplementedException();
        }
    }
}
