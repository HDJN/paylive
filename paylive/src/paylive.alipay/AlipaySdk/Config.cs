using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paylive.alipay.AlipaySdk
{
    public  class Config
    {
        //商户id。
        public static string seller_id = "2088102169920747";

        //应用ID,您的APPID。
        public static string app_id= "2016080400165668";

        //商户私钥，您的原始格式RSA私钥
        public static string  merchant_private_key = "MIIEpAIBAAKCAQEAyMGr6bEP9KFPhrT9l3dJBIU69lBXxD8H1U6yWAyqbFnnCqgUd/tHy/BldF1CMHxmzgOWwhJGcWJe1W5ZnftO22cOTx65T0jCLJQQWhUsOdanpClQ+P9pOc/MRQjwsvHKwunIgDzDnZqv6aCTW0RkmgONPS98FRAUa1LKgs61bEsxWpDKSMgtHnSZtLSFRztd/7uoXLre0N0Rztqn36TkaJY2TNgOdafsJl+lQb+ngE6H1NxOy4yvhmwC/Q5xqoa+jEmzU5R5u/xC+MkjhA13yZOe3YPlCgn3dOwq6MYZZVdiVp9H2CQsf24VWuhCe8F+lYZ915zPx3u2B/B9bZJKiwIDAQABAoIBAQCI3cDeaaB/Hxqgs/PPt7tIIay5EL1FRdOJUUW1Ua0+gWxKj5ykz+N63kHMu2fMtoNAIKI/XUY5Nt+AkuL2GccBPZk7x65+pxP6YFdlktm79OQFv0U8/KQ4jbqtthKjbMTXbZsMEmEqqbMUjCzqJA6SEanQ9PabRYMmSCNYWqTFVqbLqaZA2tBuI0xhY9Ca1Avo0+im63/RAW0UbX+1eZWaQh+SefkTGlN6komNA+kvitUp5BxAVjBnufhkqnwjSCF1hEJIl1Gn/A+BGut92LFBFzL0LwO2tkdWNkZkxkC0tZIw2svyQFHXrrerXow36nPXfD0yQMgbB6Q+fgxVcxhBAoGBAP+2Gxe2LMkycI24AgiqJ3Dj5kW7hGqcjBTY+A1Nr+mOarsaCyEn3FLDCo3k9oTZfu9eghFBtkBHspFapYHsY/lcISdyKG3zVUe/gJMsBh4PqBaTHqoUopXjx3bYYJWpcT443zmcGg3DC72shPrNWtQQVFWvjHIm9y+3hsqOPGiNAoGBAMj7r2U7MIlpRGM758iqQJQoKizkekzN9H/5oQh4axWZW5mEJwW0udKQigJq30jznF5cFJ/hGPCb8YB+UdR7gpahkoXZHcoOtFKmun0KxPAPxTB+RY63SH+Ex/LX5g5fxr+998/SRNwWuc2nYoyJjj9vDmCLc0TC8ViUVI04WrV3AoGAXVepTh+G+6643VKlE2qhWRkn7p6DuLMKg3WsHpcUNspw9XmNRH4bc+6UhLVms5n9Nv2ltwzorVA+w8Z2EhYrbFQQGikWzwP7RmSGV7LDTOfkMNFlaSp9Kv/pyN01bIxctRznh00PSaTAPW2jYTXjCPQpBNo/B1Bn/PgecQQ40uUCgYBafhgm+FOOSztjguGF1EJncv4qYGVAl6ryxC7hZXaxru8zW/FF/G1+hV3eYMhQTH+nbMZMhkl4bH58YGPvy/ysXetfILbs91nxrOhizKqHfFJI11HyREv8PojYqqUG69DNHHertv0SK5lVI3yX0oedwB81ERTBbRTF0WOQgkM1WQKBgQDSsJ/sQa0AIZlEigKDfgRSpQDiFurzcYSy/w/020fLfHkMbGvSxu+QMGyQYhMlT53YDnuGoLRQIaRz2/iQ3xzmMVTIr3vxJppmtiCxENAFaKjcbxgjycUYJFedbLvkOCLdVf9pTsbMKoVqJ3tt9p5pIBtJZ1+FfasRmLWO9fr/Dw==";

        //异步通知地址
        public static string notify_url  =  "http://工程公网访问地址/alipay.trade.wap.pay-PHP-UTF-8/notify_url.php";

        //同步跳转
        public static string return_url  =  "http://mitsein.com/alipay.trade.wap.pay-PHP-UTF-8/return_url.php";

        //编码格式
        public static string charset  =  "UTF-8";

        //签名方式
        public static string sign_type = "RSA2";

        //支付宝网关
        public static string gatewayUrl  =  "https://openapi.alipaydev.com/gateway.do";

        //支付宝公钥,查看地址：https://openhome.alipay.com/platform/keyManage.htm 对应APPID下的支付宝公钥。
        public static string alipay_public_key =
            "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAyMGr6bEP9KFPhrT9l3dJBIU69lBXxD8H1U6yWAyqbFnnCqgUd/tHy/BldF1CMHxmzgOWwhJGcWJe1W5ZnftO22cOTx65T0jCLJQQWhUsOdanpClQ+P9pOc/MRQjwsvHKwunIgDzDnZqv6aCTW0RkmgONPS98FRAUa1LKgs61bEsxWpDKSMgtHnSZtLSFRztd/7uoXLre0N0Rztqn36TkaJY2TNgOdafsJl+lQb+ngE6H1NxOy4yvhmwC/Q5xqoa+jEmzU5R5u/xC+MkjhA13yZOe3YPlCgn3dOwq6MYZZVdiVp9H2CQsf24VWuhCe8F+lYZ915zPx3u2B/B9bZJKiwIDAQAB";
    }
}
