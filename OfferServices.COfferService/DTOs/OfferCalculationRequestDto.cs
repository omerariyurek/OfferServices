using System.ComponentModel.DataAnnotations;

namespace OfferServices.COfferService.DTOs
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
