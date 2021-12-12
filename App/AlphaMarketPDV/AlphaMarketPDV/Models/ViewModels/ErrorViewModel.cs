using System;

namespace AlphaMarketPDV.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Message { get; set; }
        public int Codigo { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}