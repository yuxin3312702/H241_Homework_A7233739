using A7233739.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A7233739.Controllers
{
    public class UnitConversionController : Controller
    {
        // GET: UnitConversion
        public ActionResult UnitConversion()
        {
            return View();
        }

        [HttpPost]
        //利用Include只要自動繫結UnitConversionViewModel中的Num1
        public ActionResult UnitConversion([Bind(Include ="Num1")] UnitConversionViewModel mathdata, string btnUnitConversion)
        {
            if(!ModelState.IsValid)
            {
                return View(mathdata);
            }

            try
            {
                double num1, result;
                num1 = mathdata.Num1;
                switch(btnUnitConversion)
                {
                    case "毫米":
                        result = num1 * 10;
                        break;
                    case "公尺":
                        result = num1 / 100;
                        break;
                    case "公里":
                        result = num1 / 100000;
                        break;
                    case "英吋":
                        result = num1 / 2.54;
                        break;
                    case "英尺":
                        result = num1 * 0.0328084;
                        break;
                    case "碼":
                        result = num1 * 0.0109361;
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
                string str = "數學運算時發生例外，原因如下：\n" + ex.Message;
                mathdata.Result = str;
                return View(mathdata);
            }
        }
    }
}