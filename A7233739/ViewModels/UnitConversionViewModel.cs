using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace A7233739.ViewModels
{
    public class UnitConversionViewModel
    {
        [DisplayName("數值:")]
        [Required(ErrorMessage ="請輸入數字!")]
        public double Num1 { get; set; }

        [DisplayName("單位:公分")]
        public string Cm { get; set; }

        [DisplayName("換算結果:")]
        public string Result { get; set; }
        
    }
}