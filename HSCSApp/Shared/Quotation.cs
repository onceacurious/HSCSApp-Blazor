using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCSApp.Shared
{
    public class Quotation
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientNumber { get; set; }

        public string ClientEmail { get; set; }
        public string ClientLocation { get; set; }
        public DateTime InquiryDate { get; set; } = DateTime.Now;
        public DateTime DateAcknowledge { get; set; }
        public DateTime DateResponded { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public bool IsUrgent { get; set; }
        public bool WithMaterial { get; set; }
    }
}