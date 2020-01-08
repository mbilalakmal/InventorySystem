using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSINV
{
    public class SQLiteDataAccess
    {

        public static List<ProductModel> LoadProducts(String OrderBy = "PRODUCTNAME")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProductModel>(
                    "SELECT * FROM PRODUCT NATURAL JOIN BRAND NATURAL JOIN CATEGORY", new DynamicParameters()
                    );
                return output.ToList();
            }
        }

        public static List<ProductModel> LoadSearchedProducts(String searchString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM PRODUCT NATURAL JOIN " +
                    "BRAND NATURAL JOIN CATEGORY WHERE PRODUCTNAME LIKE @search";

                var output = cnn.Query<ProductModel>(sql, new { search = '%' + searchString + '%' } );
                return output.ToList();
            }
        }

        public static List<BrandModel> LoadBrands()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<BrandModel>(
                    "SELECT * FROM BRAND", new DynamicParameters()
                    );
                return output.ToList();
            }
        }


        public static List<BrandModel> LoadSearchedBrands(string searchString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM BRAND WHERE BRANDNAME LIKE @search";

                var output = cnn.Query<BrandModel>(sql, new { search = '%' + searchString + '%' });
                return output.ToList();
            }
        }

        public static List<CategoryModel> LoadCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CategoryModel>(
                    "SELECT * FROM CATEGORY", new DynamicParameters()
                    );
                return output.ToList();
            }
        }


        public static List<CategoryModel> LoadSearchedCategories(string searchString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM CATEGORY WHERE CATEGORYNAME LIKE @search";

                var output = cnn.Query<CategoryModel>(sql, new { search = '%' + searchString + '%' });
                return output.ToList();
            }
        }

        public static void SaveCategory(string categoryName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"INSERT OR IGNORE INTO CATEGORY (CATEGORYNAME) VALUES (@name)";

                cnn.Execute(sql, new { name = categoryName });
            }
        }

        public static void SaveBrand(string brandName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"INSERT OR IGNORE INTO BRAND (BRANDNAME) VALUES (@name)";

                cnn.Execute(sql, new { name = brandName });
            }
        }

        public static void SaveProduct(ProductModel product, int brandId, int categoryId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"INSERT OR IGNORE INTO PRODUCT(" +
                    "PRODUCTNAME, COSTPRICE, LISTPRICE, QUANTITY, DESCRIPTION, BRANDID, CATEGORYID, PICTURE)" +
                    " VALUES (@name, @cost, @list, @quantity, @description, @brand, @category, @picture)";

                cnn.Execute(sql, new {
                    name = product.ProductName, cost = product.CostPrice, list = product.ListPrice,
                    quantity = product.Quantity, description = product.Description,
                    brand = brandId, category = categoryId, picture = product.Picture
                });
            }
        }

        public static void DeleteProduct(int productId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()) ){
                string sql = @"DELETE FROM PRODUCT WHERE PRODUCTID = @search";

                cnn.Execute(sql, new { search = productId });
            }
        }

        public static void DeleteBrand(int brandId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"DELETE FROM BRAND WHERE BRANDID = @search";

                cnn.Execute(sql, new { search = brandId });
            }
        }

        public static void DeleteCategory(int categoryId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"DELETE FROM CATEGORY WHERE CATEGORYID = @search";

                cnn.Execute(sql, new { search = categoryId });
            }
        }

        public static void UpdateBrand(BrandModel brand)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"UPDATE OR IGNORE BRAND SET BRANDNAME = @name WHERE BRANDID = @id";

                cnn.Execute(sql, new { name = brand.BrandName, id = brand.BrandId });
            }
        }

        public static void UpdateCategory(CategoryModel category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"UPDATE OR IGNORE CATEGORY SET CATEGORYNAME = @name WHERE CATEGORYID = @id";

                cnn.Execute(sql, new { name = category.CategoryName, id = category.CategoryId });
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }

}
