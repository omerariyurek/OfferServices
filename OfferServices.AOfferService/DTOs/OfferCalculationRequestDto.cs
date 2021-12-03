using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfferServices.AOfferService.DTOs
{
    public class OfferCalculationRequestDto
    {
        [Required(ErrorMessage = "TC identity number is required!")]
        public string TcIdentityNo { get; set; }
        [Required(ErrorMessage = "Plate number is required!")]
        public string PlateNo { get; set; }
        [Required(ErrorMessage = "License serial number is required!")]
        public string LicenseSerialNo { get; set; }
        [Required(ErrorMessage = "License serial code is required!")]
        public string LicenseSerialCode { get; set; }
    }
}
