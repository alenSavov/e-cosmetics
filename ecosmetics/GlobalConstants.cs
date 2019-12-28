namespace ecosmetics
{
    public class GlobalConstants
    {
        /*ROLES*/
        public const string ADMINISTRATOR_ROLE = "Admin";
        public const string EMPLOYEE_ROLE = "Employee";

        // Cloudinary
        public const string CategoryPicture = "{0}_categoryPicture";
        public const string ProductPicture = "{0}_productPicture";
        public const string ArticlePicture = "{0}_articlePicture";

        //public const string FilePath = "/{0}/{1}";
        public const string FilePath = "/{0}/{1}";


        public const string InvalidLogin = "Invalid Login.";

        public const string InvalidData = "Invalid data";

        public const string InvalidId = "Invalid data";

        public const string TempDataSuccessMessageKey = "SuccessMessage";
        public const string TempDataErrorMessageKey = "ErrorMessage";

        public const string imageFolderName = "img";
        public const string imageFolderPath = "../../img/";

        public const string WrongMessage = "Something were wrong";

        public const string cultureEn = "en-US";

        public const string PasswordChanged = "Your password has been changed.";

        public class CategoryMessage
        {
            public const string CreateCategorySuccess = "Successful created category";
            public const string DeleteCategorySuccess = "Successful delete category";
            public const string EditCategoryNameRequired = "Name is required";
        }

        public class ProductMessage
        {
            public const string CreateProductSuccess = "Successful created product";
            public const string DeleteProductSuccess = "Successful deleted product";
            public const string DeleteProductUnSuccess = "Something were wrong";
            public const string EditProductSuccess = "Successful updated product";
        }

        public class ArticleMessage
        {
            public const string CreateArticleSuccess = "Successful created article";
            public const string DeleteArticleSuccess = "Successful deleted article";
            public const string EditArticleSuccess = "Successful edited article";
        }
    }
}
