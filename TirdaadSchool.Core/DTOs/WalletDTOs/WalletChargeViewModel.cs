using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirdaadSchool.Core.DTOs.WalletDTOs
{
    public class WalletChargeViewModel
    {
        [Required(ErrorMessage ="مقدار{0} را وارد کنید")]
        [Display(Name ="مبلغ")]
        public int Amount { get; set; }
    }
}
