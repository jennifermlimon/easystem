using BusinessLogic;
using DataAccess;
using DataAccess.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace EaSystemTest
{
    [TestClass]
    public class BusinessLogicTest
    {
        private readonly Model _context = new Model();

        [TestMethod]
        public void Product_Has_Been_Inserted_Test()
        {
            var sub = _context.Products.FirstOrDefault();
            Product product = new Product
            {
                ProductId = Guid.NewGuid(),
                Earns = 5.0,
                Price = 50,
                ProductDescription = "test!",
                ProductName = "test",
                Quantity = 1,
                SubcategoryId = sub.SubcategoryId
            };
            var insert = BusinessProduct.InsertProduct(product);            
            Assert.AreEqual(insert, true);
        }

        [TestMethod]
        public void Product_Has_Been_Updated_Test()
        {
            var product = _context.Products.Where(x => x.ProductName == "test").FirstOrDefault();
            product.ProductDescription = "testUpdated";
            var update = BusinessProduct.UpdateProduct(product);
            Assert.AreEqual(update, true);
        }

        [TestMethod]
        public void Search_Product_Test()
        {
            string word = "t";
            bool wordContais = false;
            var product = BusinessProduct.SearchProducts(word);

            if (product.Any())
            {
                wordContais = true;
            }
            Assert.AreEqual(wordContais, true);
        }

        [TestMethod]
        public void Product_Has_Been_Deleteded_Test()
        {
            var product = _context.Products.Where(x => x.ProductName == "test").FirstOrDefault();
            var deleted = BusinessProduct.DeleteProduct(product.ProductId);
            Assert.AreEqual(deleted, true);
        }

       
    }
}
