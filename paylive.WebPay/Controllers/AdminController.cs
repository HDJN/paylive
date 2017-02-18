using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using paylive.WebPay.MVCFilter;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace paylive.WebPay.Controllers
{
    
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
             
            return View();
        }

        /// <summary>
        /// 商户管理
        /// </summary>
        /// <returns></returns>
        public IActionResult Merchant()
        {
            return View();
        }

        /// <summary>
        /// 配置支付方式
        /// </summary>
        /// <returns></returns>
        public IActionResult PayModelSetting()
        {
            return View();
        }

        /// <summary>
        /// 订单管理
        /// </summary>
        /// <returns></returns>
        public IActionResult Order()
        {
            return View();
        }
    }
}
