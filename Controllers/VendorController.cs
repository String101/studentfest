using Microsoft.AspNetCore.Mvc;
using studentfest.Interface;
using studentfest.Models;

namespace studentfest.Controllers
{
    public class VendorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public VendorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var vendors =  _unitOfWork.Vendor.GetAll();
            foreach (var vendor in vendors)
            {
                vendor.ContactDetails = _unitOfWork.ContactDetails.Get(u => u.Id == vendor.ContactDetailsId);
                vendor.ResidentalAddress=_unitOfWork.ResidentialAddress.Get(u=>u.Id == vendor.ResidentalAddressId);
            }
            return View(vendors);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Vendor vendor)
        {
            vendor.Id=Guid.NewGuid().ToString();
            if (ModelState.IsValid)
            {
                ResidentalAddress residentalAddress = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    StreetName = vendor.ResidentalAddress.StreetName,
                    HouseNumber = vendor.ResidentalAddress.HouseNumber,
                    suburb = vendor.ResidentalAddress.suburb,
                    City = vendor.ResidentalAddress.City,
                    Region = vendor.ResidentalAddress.Region,
                    Country = vendor.ResidentalAddress.Country,
                    PostalCode = vendor.ResidentalAddress.PostalCode,
                    VendorId = vendor.Id,

                };

                ContactDetails contactDetails = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    CountryCode = vendor.ContactDetails.CountryCode,
                    MobileNumber = vendor.ContactDetails.MobileNumber,
                    AlternativeNumber = vendor.ContactDetails.AlternativeNumber,
                    AlternativeEmailAddress = vendor.ContactDetails.AlternativeEmailAddress,
                    VendorId = vendor.Id,
                };
                vendor.ContactDetailsId = contactDetails.Id;
                vendor.ResidentalAddressId= residentalAddress.Id;
                _unitOfWork.Vendor.Add(vendor);
                _unitOfWork.ContactDetails.Add(contactDetails);
                _unitOfWork.ResidentialAddress.Add(residentalAddress);
              
                _unitOfWork.Save();
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
