using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using OfferServices.COfferService.DTOs;

namespace OfferServices.COfferService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OffersController : ControllerBase
    {
        private readonly IConfiguration _config;

        public OffersController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("calculation")]
        public IActionResult Calculation(OfferCalculationRequestDto offerCalculationDto)
        {
            var rnd = new Random();
            var price = rnd.Next(2000, 3800);
            var offerResponse = new CalculationResponseDto
            {
                CompanyName = _config.GetValue<string>("companyName"),
                CompanyLogo = Request.Scheme + "://" + Request.Host + Request.PathBase + "/" + _config.GetValue<string>("logo"),
                OfferDescription = _config.GetValue<string>("offerDescription"),
                PlateNo = offerCalculationDto.PlateNo,
                OfferPrice = price
            };
            return Ok(offerResponse);
        }
    }
}
