using LibraryData;
using Microsoft.AspNetCore.Mvc;
using SajhaLibrary.Models.Catalog;
using SajhaLibrary.Models.CheckoutModels;
using System.Linq;

namespace SajhaLibrary.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ILibraryAssest _assets;
        private readonly ICheckoutService _checkouts;

        public CatalogController(ILibraryAssest assets,ICheckoutService checkout)
        {
            _assets = assets;
            _checkouts = checkout;
        }

        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();

            var listingResult = assetModels.Select(x => new AssetIndexListingModel
            {
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                AuthorOrDirector = _assets.GetAuthorOrDirector(x.Id),
                DeweyCallNumber = _assets.GetDeweyIndex(x.Id),
                Title = x.Title,
                Type = _assets.GetType(x.Id)
            });

            var model = new AssetIndexModel
            {
                Assets = listingResult
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var asset = _assets.GetById(id);

            var currentHolds = _checkouts.GetCurrentHolds(id)
                .Select(x => new AssetHoldModel
                {
                    HoldPlaced=_checkouts.GetCurrentHoldPlaced(x.Id),
                    PatronName=_checkouts.GetCurrentHoldPatron(x.Id)
                });

            var model = new AssetDetailModel
            {
                AssetId = id,
                Title = asset.Title,
                Type=_assets.GetType(id),
                Year = asset.Year,
                Cost = asset.Cost,
                Status = asset.Status.Name,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = _assets.GetAuthorOrDirector(id),
                CurrentLocation = _assets.GetCurrentLocation(id).Name,
                DeweyCallNumber= _assets.GetDeweyIndex(id),
                ISBN = _assets.GetIsbn(id),
                CheckoutHistory=_checkouts.GetCheckoutHistory(id),
                LatestCheckout=_checkouts.GetLatestCheckout(id),
                PatronName=_checkouts.GetCurrentPatron(id),
                CurrentHolds=currentHolds
            };

            return View(model);
        }

        public IActionResult Checkout(int id)
        {
            var asset = _assets.GetById(id);

            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                IsCheckedOut = _checkouts.IsCheckedOut(id)
            };
            return View(model);
        }

        public IActionResult Hold(int id)
        {
            var asset = _assets.GetById(id);

            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                HoldCount = _checkouts.GetCurrentHolds(id).Count()
            };
            return View(model);
        }

        public IActionResult CheckIn(int id)
        {
            _checkouts.CheckInItem(id);
            return RedirectToAction("Detail", new { id });
        }

        public IActionResult MarkLost(int id)
        {
            _checkouts.MarkLost(id);
            return RedirectToAction("Detail", new { id });
        }

        public IActionResult MarkFound(int id)
        {
            _checkouts.MarkFound(id);
            return RedirectToAction("Detail", new { id });
        }

        [HttpPost]
        public IActionResult PlaceCheckout(int assetId, int libraryCardId)
        {
            _checkouts.CheckoutItem(assetId, libraryCardId);
            return RedirectToAction("Detail", new { id = assetId });
        }

        [HttpPost]
        public IActionResult PlaceHold(int assetId, int libraryCardId)
        {
            _checkouts.PlaceHold(assetId, libraryCardId);
            return RedirectToAction("Detail", new { id = assetId });
        }
    }
}