using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfferServices.AOfferService.DTOs
{
    public class CalculationResponseDto
    {
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public string OfferDescription { get; set; }
        public decimal OfferPrice { get; set; }
        public string PlateNo { get; set; }
    }
}
