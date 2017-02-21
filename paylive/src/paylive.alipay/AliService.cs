using System;
using paylive.core;

namespace paylive.alipay
{
    public class AliService : Plug
    {
        public AliService()
        {
            Url = "/wx/index";
            Ua = "alipay";
            Descrpion = "alipay";
        }

        public override string Run()
        {
            throw new NotImplementedException();
        }
    }
}