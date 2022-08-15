using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iMessengerCoreAPI.Models
{

    public class RGDialogsClients
    {
        [Key]
        public Guid IDUnique { get; set; }

        public Guid IDRGDialog { get; set; }
        public Guid IDClient { get; set; }
        public DateTime? DateEvent { get; set; }
    }
}