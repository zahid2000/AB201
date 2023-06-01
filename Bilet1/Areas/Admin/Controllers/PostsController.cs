using Bilet1.Areas.Admin.ViewModels;
using Bilet1.DAL;
using Bilet1.Models;
using Bilet1.Utilities.Constants;
using Bilet1.Utilities.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Bilet1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PostsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PostsController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            List<Post> posts = await _context.Posts.Where(p => !p.IsDeleted).OrderByDescending(p => p.Id).ToListAsync();
            return View(posts);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreatePostVM postVM)
        {
            if (!ModelState.IsValid) return View(postVM);
            if (!postVM.Photo.CheckContentType("image/"))
            {
                ModelState.AddModelError("Photo", ErrorMessages.FileMustBeImageType);
                return View(postVM);
            }
            if (!postVM.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", ErrorMessages.FileSizeMustLessThan200KB);
                return View(postVM);
            }

            string rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "images");
            string fileName = await postVM.Photo.SaveAsync(rootPath);

            Post post = new Post
            {
                Title = postVM.Title,
                Description = postVM.Description,
                ImagePath = fileName
            };
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            Post post = await _context.Posts.FindAsync(id);
            if (post == null) return NotFound();
            string filepath = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "images", post.ImagePath);
            if (System.IO.File.Exists(filepath))
            {
                System.IO.File.Delete(filepath);
            }
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Post post = await _context.Posts.FindAsync(id);
            if (post == null) return NotFound();
            UpdatePostVM updatePostVM = new UpdatePostVM()
            {
                Description = post.Description,
                Id = id,
                Title = post.Title
            };
            return View(updatePostVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(UpdatePostVM postVM)
        {

            if (!ModelState.IsValid) return View(postVM);

            if (!postVM.Photo.CheckContentType("image/"))
            {
                ModelState.AddModelError("Photo", ErrorMessages.FileMustBeImageType);
                return View(postVM);
            }
            if (!postVM.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", ErrorMessages.FileSizeMustLessThan200KB);
                return View(postVM);
            }
            string rootPath = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "images");
            Post post = await _context.Posts.FindAsync(postVM.Id);
            string filepath = Path.Combine(rootPath, post.ImagePath);
            if (System.IO.File.Exists(filepath))
            {
                System.IO.File.Delete(filepath);
            }
            string newFileName = await postVM.Photo.SaveAsync(rootPath);

            post.ImagePath = newFileName;
            post.Title = postVM.Title;
            post.Description = postVM.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
