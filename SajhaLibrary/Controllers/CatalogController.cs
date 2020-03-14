using LibraryData;
using Microsoft.AspNetCore.Mvc;
using SajhaLibrary.Models.Catalog;
using System.Linq;

namespace SajhaLibrary.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ILibraryAssest _assets;

        public CatalogController(ILibraryAssest assets)
        {
            _assets = assets;
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

            var model = new AssetDetailModel
            {
                AssetId = id,
                Title = asset.Title,
                Year = asset.Year,
                Cost = asset.Cost,
                Status = asset.Status.Name,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = _assets.GetAuthorOrDirector(id),
                CurrentLocation = _assets.GetCurrentLocation(id).Name,
                DeweyCallNumber= _assets.GetDeweyIndex(id),
                ISBN = _assets.GetIsbn(id),
            };

            return View(model);
        }
    }
}