namespace ProdductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t ================= WELCOME TO PRODUCT REVIEW MANAGEMENT PROBLEM =======================\n");

            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 2, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 2, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 3, Rating = 2, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 6, UserID = 4, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductID = 7, UserID = 3, Rating = 1.5, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 8, UserID = 8, Rating = 4, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 9, UserID = 9, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 11, UserID = 11, Rating = 4, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 12, UserID = 12, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 13, UserID = 13, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 14, UserID = 14, Rating = 5, Review = "Good", isLike = true },

               
            };



            //foreach (var list in productReviews)
            //{
            //    Console.WriteLine($"ProductID : {list.ProductID}\n" +
            //                      $"UserID    : {list.UserID}\n" +
            //                      $"Rating    : {list.Rating}\n" +
            //                      $"Review    : {list.Review}\n" +
            //                      $"isLike    : {list.isLike}\n");
            //}

            foreach (ProductReview product in productReviews)
            {
                Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.isLike + "\n");
            }

            // Create object of Management class
            Management objManage = new Management();
            objManage.TopRecords(productReviews);
           
        }
    }
}