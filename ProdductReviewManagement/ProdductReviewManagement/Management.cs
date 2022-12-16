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
            
            foreach(ProductReview productReview in records)
            {
                Console.WriteLine("ProductID : " + productReview.ProductID + " UserID : " + productReview.UserID + " Rating : " + productReview.Rating + " Review : " + productReview.Review + " isLike : " + productReview.isLike);
            }
        }
    }
}
