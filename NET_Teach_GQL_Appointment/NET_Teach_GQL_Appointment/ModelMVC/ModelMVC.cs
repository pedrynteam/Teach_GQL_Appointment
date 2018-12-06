using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NET_Teach_GQL_Appointment.MVCModel
{


    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Inserted")]
        public DateTime Inserted { get; set; }

        [Required]
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Inserted")]
        public DateTime Inserted { get; set; }

        public virtual List<Order> Orders { get; set; }

    }

    // 1 to Many sample - Steven Sandersons
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

    }

    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        public virtual List<Player> Players { get; set; }
    }

}
