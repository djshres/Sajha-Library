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
    }
}