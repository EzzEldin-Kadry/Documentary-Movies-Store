using ClassicM.DataAccess.Repository.IRepository;
using ClassicM.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ClassicM.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShoppingCartViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if(claim is not null)
            {
                if(HttpContext.Session.GetInt32(SD.SessionCart) == null)
                {
                    var cartsList = _unitOfWork.ShoppingCart.GetAll(x => x.ApplicationUserId == claim.Value).ToList();
                    HttpContext.Session.SetInt32(SD.SessionCart, cartsList.Count);
                }
                return View(HttpContext.Session.GetInt32(SD.SessionCart));
            }
            else
            {
                HttpContext.Session.Clear();
                return View(0);
            }
        }
    }
}
