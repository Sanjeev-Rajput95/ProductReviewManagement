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

        public void TopRecords(List<ProductReview> review)
        {
            var recordeData = (from productReviews in review
                               orderby productReviews.Rating descending
                               select productReviews).Take(3);

            Console.WriteLine($"topReview : {JsonConvert.SerializeObject(recordeData)}");
        }
         
}
}
