using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos
{
    public class AddOrderDto
    {
        [Required(ErrorMessage ="Sipariş numarası boş bırakılamaz")]
        public int SiparisNumarasi { get; set; }
        [Required(ErrorMessage = "TRY bedeli boş bırakılamaz")]
        public int BuyTry { get; set; }
        [Required(ErrorMessage = "USD bedeli boş bırakılamaz")]
        public int BuyUsd { get; set; }
        public int SellUsd { get; set; }
        public int SellTry { get; set; }
        public int SellForCountry { get; set; }
        public string Country { get; set; }
    }
}
