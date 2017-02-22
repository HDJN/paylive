using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using paylive.core;
using paylive.wxpay.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace paylive.wxpay.Controllers
{
    public class WxController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> NativePay()
        {

            //MD5加密
            var md5 = MD5.Create();
            var bs = md5.ComputeHash(Encoding.UTF8.GetBytes("123"));
            var sb = new StringBuilder();
            foreach (var b in bs)
                sb.Append(b.ToString("x2"));
            //所有字符转为大写
            var ss=sb.ToString().ToUpper();

            Log.Info(GetType().ToString(), "page load");

            var nativePay = new NativePay();

            //生成扫码支付模式二url
            var url = await nativePay.GetPayUrl("123456789");

            //将url生成二维码图片
            var imageUrl = "MakeQRCode.aspx?data=" + UrlEncoder.Default.Encode(url);
            return Content(imageUrl);
        }
    }
}