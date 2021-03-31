using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace A7233739.ViewModels
{
    public class CurrencyExchangeViewModel
    {
        [DisplayName("請輸入數字:")]
        [Required(ErrorMessage ="請輸入數字!")]
        public double Num1 { get; set; }

        [DisplayName("單位:台幣")]
        public string Tw { get; set; }

        [DisplayName("轉換結果:")]
        public string Result { get; set; }
    }
}