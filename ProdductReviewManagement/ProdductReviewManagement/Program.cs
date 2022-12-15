namespace ProdductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t ================= WELCOME TO PRODUCT REVIEW MANAGEMENT PROBLEM =======================\n");

            // UC1 Create Product reviews mangement
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 2, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 2, Rating = 10, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 5, UserID = 3, Rating = 2, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 6, UserID = 4, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductID = 7, UserID = 3, Rating = 1.5, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 8, UserID = 8, Rating = 9, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 9, UserID = 9, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 11, UserID = 11, Rating = 15, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 12, UserID = 12, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 13, UserID = 13, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 14, UserID = 14, Rating = 5, Review = "Good", isLike = true },

               
            };

            //foreach (ProductReview product in productReviews)
            //{
            //    Console.WriteLine("ProductID : " + product.ProductID + " UserID : " + product.UserID + " Rating : " + product.Rating + " Review : " + product.Review + " IsLike : " + product.isLike + "\n");
            //}

            // UC-2
            // Retrieve top 3 records from list
            Management objManage = new Management();
            objManage.TopThreeRecords(productReviews);
        }
    }
}