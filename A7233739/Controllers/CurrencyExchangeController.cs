using A7233739.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A7233739.Controllers
{
    public class CurrencyExchangeController : Controller
    {
        // GET: CurrencyExchange
        public ActionResult CurrencyExchange()
        {
            return View();
        }
        [HttpPost]
        //利用Include只要自動繫結CurrencyExchangeViewModel中的Num1
        public ActionResult CurrencyExchange([Bind(Include ="Num1")]CurrencyExchangeViewModel mathdata, string btnCurrency)
        {
            if (!ModelState.IsValid)
            {
                return View(mathdata);
            }
            try
            {
                double num1, result;
                num1 = mathdata.Num1;
                switch (btnCurrency)
                {
                    case "美元":
                        result = num1 / 28.479;
                        break;
                    case "英鎊":
                        result = num1 / 39.172;
                        break;
                    case "人民幣":
                        result = num1 / 4.346;
                        break;
                    case "日圓":
                        result = num1 * 3.876;
                        break;
                    default:
                        result = 0;
                        break;
                }

                mathdata.Result = result.ToString();
                return View(mathdata);
            }
            catch(Exception ex)
            {
                string str = "轉換時發生例外，原因如下:\n" + ex.Message;
                mathdata.Result = str;
                return View(mathdata);
            }
        }
    }
}