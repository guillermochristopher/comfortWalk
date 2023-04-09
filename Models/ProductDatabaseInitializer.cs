using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace comfortWalk.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Sport Shoes"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Casual Shoes"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Trekking Shoes"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Boots Shoes"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Summer Shoes"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Reebok_Nano",
                    Description = "We Have No Plans to Walk Away’ From the CrossFit Community, we jump we rock!!" +
                                  "It all rides on award-winning Floatride Energy Foam that gives you lightweight cushioning to make that run the easiest part of the workout. ",
                    ImagePath="Reebok_Nano.png",
                    UnitPrice = 78.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Geox Casual",
                    Description = "Enjoy conscious comfort, durability and quality with our responsible leather promise" +
                    "This shoe’s leather uppers are sourced from tanneries committed to actively auditing their facilities for water use, energy use, and waste production.",
                    ImagePath="Geox.png",
                    UnitPrice = 108.00,
                     CategoryID = 2
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "MountainAction",
                    Description = "These waterproof boots let you progress with good support on relatively difficult trails with a moderate to steep slope.",
                    ImagePath="MountainAction.png",
                    UnitPrice = 159.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Dr_Marteens",
                    Description = "490 10-eyelet boots feature a classic punk silhouette. They're laced even higher for an amped-up attitude."+
                    "Sharing the brand's signature DNA with features including grooves on the sides, yellow topstitching and a heel-loop.",
                    ImagePath="Dr_Marteens.png",
                    UnitPrice = 98.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Birkenstock",
                    Description = "The mastery of shoe making and the devotion to bring style and comfort to the people have persisted from one generation to the next" +
                                  "Over many generations, the Birkenstock company has gathered extensive knowledge in the area of foot health. This knowledge and experience is the foundation of their proven, high quality Birkenstock sandals and shoes.",
                    ImagePath="BIRKENSTOCK.png",
                    UnitPrice = 70.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Gazzelle",
                    Description = "A low-profile classic. The Gazelle shoe started life as a football trainer and grew into an iconic streetwear staple.",
                    ImagePath="AdidasShoes.png",
                    UnitPrice = 75.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Atticus Casual",
                    Description = "Lightweight dress shoe Atticus LT Cap makes sure you look the part and feel completely comfortable on any occasion this season."+
                    " Finished with fine stitching and prepped with slimline breathable features, it’s perfectly poised between smart and casual – ideal for garden get-togethers or alfresco evening drinks.",
                    ImagePath="Atticus.png",
                    UnitPrice = 84.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Rogue",
                    Description = "The Rogue is a firm favourite the waterproof, breathable lining and absorbent anti shock polyurethane memory foam mid sole adds the perfect comfort and ease for walking those long gruelling distances"+
                    "The non slip Vibram rubber sole helps with those tough terrains and the arch support and step stabiliser keeps your feet comfortable and protected.",
                    ImagePath="Rogue.png",
                    UnitPrice = 102.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Timberland",
                    Description = "Padded top collar for comfort. Direct-inject construction for durability",
                    ImagePath="Timberland.png",
                    UnitPrice = 132.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Crocs",
                    Description = "A technology that gives each pair of shoes the soft, comfortable, lightweight, non-marking and odor-resistant qualities that Crocs wearers know and love.",
                    ImagePath="Crocs.png",
                    UnitPrice = 45.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Arlo Lace",
                    Description = "A natural match to smart tailoring, Oxford shoe CraftArlo Lace keeps things classic with its leather construction and sleek, streamlined silhouette." +
                    "Joining you in the boardroom and at black-tie events, this lace-up pair quickly feels like an old favourite.",
                    ImagePath="Craft-Arlo-Lace.png",
                    UnitPrice = 129.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Nike Air Max 270",
                    Description = "The Nike Air Max 270 takes sneaker design to a new level." +
                    "With the visible Air unit in the heel mounted at 270 degrees, the sneaker offers greater cushioning and an eye-catching ultramodern look" + 
                    " Get the best of style and comfort with these unique sneakers.",
                    ImagePath="Nike Air Max 270.png",
                    UnitPrice = 86.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Salomon",
                    Description = "Get ready to power through uphills and descents with the updated X ULTRA 4." +
                    " It is as agile as a trail-running shoe but with all the stability and grip you need to tackle technical terrain.",
                    ImagePath="Salomonadvc.png",
                    UnitPrice = 95.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Chelsea Boots",
                    Description = "Choosing sustainable leather means sourcing from suppliers certified by the Leather Working Group."+
                    " They are committed to reducing their environmental impact by using less water and less energy. Beautiful and smart at the same time.",
                    ImagePath="Chelsea Boots.png",
                    UnitPrice = 104.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Spherica",
                    Description = "Practical and comfortable trekking sandal from Geox." +
                    "Thanks to the three adjustable Velcro straps, the model can be optimally adjusted to the foot and thus offers perfect support.",
                    ImagePath="Spherica.png",
                    UnitPrice = 52.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "BlueNano",
                    Description = "VERSATILE FITNESS SHOES WITH A SUPPORTIVE BUILD!!",
                    ImagePath="BlueNano.png",
                    UnitPrice = 122.95,
                    CategoryID = 1
                }
            };

            return products;
        }
    }
}