using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdductReviewManagement
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopThreeRecords(List<ProductReview> review)
        {
            var recordeData = (from productReviews in review
                               orderby productReviews.Rating descending
                               select productReviews).Take(3);

            // Console.WriteLine($"topReview : {JsonConvert.SerializeObject(recordeData)}");


            foreach (ProductReview product in recordeData)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.isLike + "\n");
            }
        }
        // UC3--Retrieve rating > 3 and ProductID is 1 or 4 or 9
        public void SelectedRecords(List<ProductReview> reviews)
        {
            var records = (from productReviews in reviews where productReviews.Rating > 3 && (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9) select productReviews);

            foreach (ProductReview productReview in records)
            {
                Console.WriteLine("ProductID : " + productReview.ProductID + " UserID : " + productReview.UserID + " Rating : " + productReview.Rating + " Review : " + productReview.Review + " isLike : " + productReview.isLike);
            }
        }
        // UC4--Retrieve Count of records
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach(var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "------" + list.Count);
            }
        }   
        // UC5--Retriving productId and review

        public void RetrieveProductID_And_Review(List<ProductReview> listProductReview)
        {
            Console.WriteLine("\n-----------Retriving productId and review------------ ");
            var recordsData = (listProductReview.Select(product => new { productID = product.ProductID, review = product.Review })).ToList();
            foreach (var record in recordsData)
            {
                Console.WriteLine("\n" + " ProductId : {0}" + "\t" + " Review : {1} ", record.productID, record.review);
            }
        }
        // UC6--Skip top 5 records

        public void Skiptop5DataFromList(List<ProductReview> list)
        {
            Console.WriteLine("\n ------Skip the Top 5 records display remaining records-----");
            List<ProductReview>afterSkipRecords = list.Skip(5).ToList();
            foreach (var record in afterSkipRecords)
            {
                Console.WriteLine("\n" + "ProductID : " + record.ProductID + " UserID : " + record.UserID + " Rating : " + record.Rating + " Review : " + record.Review + " isLike : " + record.isLike);
            }
        }
    }
}
