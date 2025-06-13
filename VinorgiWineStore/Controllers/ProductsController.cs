using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VinorgiWineStore.Models;
using VinorgiWineStore.Services;

namespace VinorgiWineStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;

        public IWebHostEnvironment Environment { get; }

        public ProductsController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            this.context = context;
            Environment = environment;
        }

        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p => p.Id).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            // Server-side validation for the image
            if (productDto.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "The image file is required");
            }

            // If the model state is invalid, redisplay the form
            if (!ModelState.IsValid)
            {
                return View(productDto);
            }
            // Generate unique file name using timestamp
            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            newFileName += Path.GetExtension(productDto.ImageFile.FileName);

            // Build the full path for saving the image
            string imageFullPath = Path.Combine(Environment.WebRootPath, "images/products", newFileName);

            // Save the file to disk
            using (var stream = new FileStream(imageFullPath, FileMode.Create))
            {
                productDto.ImageFile.CopyTo(stream);
            }

            var product = new Product
            {
                Name = productDto.Name,
                Brand = productDto.Brand,
                Category = productDto.Category,
                Price = productDto.Price,
                Description = productDto.Description,
                ImageFileName = newFileName,
                CreatedAt = DateTime.Now
            };

            context.Products.Add(product);
            context.SaveChanges();



            // Redirect to the product listing page after successful creation
            return RedirectToAction("Index", "Products");
        }
    }
}