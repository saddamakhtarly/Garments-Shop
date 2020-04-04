using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS341.GarmentsShop
{
    public class PlaceOrder : IListable
    {
        public int Id { get; set; }

        
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Name { get; set; }

        public float Price { get; set; }


        [Column(TypeName = "varchar")]
        [MaxLength(300)]
        public string ImageUrl { get; set; }

        public int SelectedSizeId { get; set; }

        public string Status { get; set; }

        public int Quantity { get; set; }
        public string Login { get; set; }
        public string LandLineNo { get; set; }
        public string MobileNo { get; set; }
        public string FullAddress { get; set; }
        public string InvoiceNo { get; set; }


        public int Amount
        {
            get; set;
        }


        
       

        
    }
}
