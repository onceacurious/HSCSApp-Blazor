using System;
using System.Collections.Generic;

namespace HSCSApp.Shared
{
    public class ServiceQuotation
    {
        public int Id { get; set; }

        public string ClientName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public List<Service> Services { get; set; }
        public int ServiceId { get; set; }

        public string Details { get; set; }
        public DateTime DateInquired { get; set; } = DateTime.Now;
        public DateTime DateOpened { get; set; }
        public DateTime DateAccommodated { get; set; }
    }
}