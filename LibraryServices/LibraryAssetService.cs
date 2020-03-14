using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAssest
    {
        private readonly LibraryContext _context;

        public LibraryAssetService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges();
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets.Include(x => x.Status).Include(x => x.Location);
        }

        public LibraryAsset GetById(int id)
        {
            return _context.LibraryAssets.Include(x => x.Status).Include(x => x.Location).FirstOrDefault(x => x.Id == id);
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            var location = _context.LibraryAssets.FirstOrDefault(x => x.Id == id).Location;
            return location;
        }

        public string GetDeweyIndex(int id)
        {
            if (_context.Books.Any(x => x.Id == id))
            {
                return _context.Books.FirstOrDefault(x => x.Id == id).DeweyIndex;
            }
            else return "";
        }

        public string GetIsbn(int id)
        {
            if (_context.Books.Any(x => x.Id == id))
            {
                return _context.Books.FirstOrDefault(x => x.Id == id).ISBN;
            }
            else return "";
        }

        public string GetTitle(int id)
        {
            return _context.LibraryAssets.FirstOrDefault(x => x.Id == id).Title;
        }

        public string GetType(int id)
        {
            var book = _context.LibraryAssets.OfType<Book>().Where(x => x.Id == id);
            return book.Any() ? "Book" : "Video";
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = _context.LibraryAssets.OfType<Book>()
                .Where(x => x.Id == id).Any();
            var isVideo = _context.LibraryAssets.OfType<Video>()
                .Where(x => x.Id == id).Any();

            return isBook ?
                _context.Books.FirstOrDefault(x => x.Id == id).Author :
                _context.Videos.FirstOrDefault(x => x.Id == id).Director
                ?? "Unknown";
        }
    }
}
