using System;

namespace pricequotation.Models
{
    //this is error view model that is requesting ID and showing it id it's not null and empty
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
