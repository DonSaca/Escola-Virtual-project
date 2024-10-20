using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual
{
    public class InfoChangeRequest
    {
        public string FieldName { get; set; }
        public string RequestedValue { get; set; }  // The new value requested
        public string CurrentValue { get; set; }  // The current value (for reference)
        public string Username { get; set; }  
        public string NIF { get; set; }
        public bool IsApproved { get; set; }  // Status of the request (pending/approved/rejected)
        public bool IsRejected { get; set; }
        public string Status { get; set; }

    }
}
