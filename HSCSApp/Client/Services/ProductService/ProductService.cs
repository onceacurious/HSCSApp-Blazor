using HSCSApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSCSApp.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Title = "Planning & Design",
                    Description = "Planning and designing at your preference.",
                    Icon = "images/planning_icon.png",
                    Image = "images/planning.jpg",
                },
                new Product
                {
                    Id = 2,
                    Title = "Construction",
                    Description = "Build according to your dreams.",
                    Icon = "images/construction_icon.png",
                    Image = "images/construction.jpg",
                },
                new Product
                {
                    Id = 3,
                    Title = "Electrical",
                    Description = "Sophisticated electrical techniques that will help you minimize cost while maximizing efficiency.",
                    Icon = "images/electrical_icon.png",
                    Image = "images/electrical.jpg",
                },
                new Product
                {
                    Id = 4,
                    Title = "Electronics",
                    Description = "Electronics that will help you automate household or office chores.",
                    Icon = "images/electronics_icon.png",
                    Image = "images/electronics.jpg",
                },
                new Product
                {
                    Id = 5,
                    Title = "Mechanical",
                    Description = "Helping you build and assemble machines or mechanical components according to requirements.",
                    Icon = "images/mechanic_icon.png",
                    Image = "images/mechanical.jpg",
                },
                new Product
                {
                    Id = 6,
                    Title = "Renovation",
                    Description = "House or building improvements that suits your budget with design beyond expectation.",
                    Icon = "images/renovation_icon.png",
                    Image = "images/renovation.jpg",
                },
                new Product
                {
                    Id = 7,
                    Title = "Plumbing",
                    Description = "Install pipes and plumbing fixtures is not an easy chores. Leave it to us!",
                    Icon = "images/plumbing_icon.png",
                    Image = "images/plumbing.jpg",
                },
                new Product
                {
                    Id = 8,
                    Title = "Consultation",
                    Description = "Let us help you Plan, Design, Budget and Build your Dreams.",
                    Icon = "images/consult_icon.png",
                    Image = "images/consultation.jpg",
                },
            };
        }
    }
}