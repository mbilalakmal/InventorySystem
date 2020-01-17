using Dapper;
using POSINV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        
        //Load All Products (Joined with Brand & Category)
        public static List<ProductModel> LoadProducts(String OrderBy = "PRODUCTNAME")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM PRODUCT NATURAL JOIN BRAND NATURAL JOIN CATEGORY";

                var output = cnn.Query<ProductModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        //Load Products containing the search string
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

        //Load All Brands
        public static List<BrandModel> LoadBrands()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM BRAND";

                var output = cnn.Query<BrandModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        //Load Brands containing the search string
        public static List<BrandModel> LoadSearchedBrands(string searchString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM BRAND WHERE BRANDNAME LIKE @search";

                var output = cnn.Query<BrandModel>(sql, new { search = '%' + searchString + '%' });
                return output.ToList();
            }
        }

        //Load All Categories
        public static List<CategoryModel> LoadCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM CATEGORY";

                var output = cnn.Query<CategoryModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }
        
        //Load Categories containing the search string
        public static List<CategoryModel> LoadSearchedCategories(string searchString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM CATEGORY WHERE CATEGORYNAME LIKE @search";

                var output = cnn.Query<CategoryModel>(sql, new { search = '%' + searchString + '%' });
                return output.ToList();
            }
        }

        //Save newly created category
        public static void SaveCategory(string categoryName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"INSERT OR IGNORE INTO CATEGORY (CATEGORYNAME) VALUES (@name)";

                cnn.Execute(sql, new { name = categoryName });
            }
        }

        //Save newly created brand
        public static void SaveBrand(string brandName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"INSERT OR IGNORE INTO BRAND (BRANDNAME) VALUES (@name)";

                cnn.Execute(sql, new { name = brandName });
            }
        }

        //save newly created product with brandId and categoryId
        public static void SaveProduct(ProductModel product, int brandId, int categoryId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"INSERT OR IGNORE INTO PRODUCT(" +
                    "PRODUCTNAME, COSTPRICE, LISTPRICE, QUANTITY, DESCRIPTION, " +
                    "UPDATEDON, BRANDID, CATEGORYID, PICTURE)" +
                    " VALUES (@name, @cost, @list, @quantity, @description, " +
                    "datetime(CURRENT_TIMESTAMP, 'localtime'), @brand, @category, @picture)";

                cnn.Execute(sql, new
                {
                    name = product.ProductName,
                    cost = product.CostPrice,
                    list = product.ListPrice,
                    quantity = product.Quantity,
                    description = product.Description,
                    brand = brandId,
                    category = categoryId,
                    picture = product.Picture
                });
            }
        }

        //Delete product with given productId, CASCADING
        public static void DeleteProduct(int productId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"PRAGMA foreign_keys = ON;DELETE FROM PRODUCT WHERE PRODUCTID = @search";

                cnn.Execute(sql, new { search = productId });
            }
        }

        //Delete brand with given brandId,  CASCADING
        public static void DeleteBrand(int brandId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"PRAGMA foreign_keys = ON;DELETE FROM BRAND WHERE BRANDID = @search";

                cnn.Execute(sql, new { search = brandId });
            }
        }

        //Delete product with given productId, CASCADING
        public static void DeleteCategory(int categoryId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"PRAGMA foreign_keys = ON;DELETE FROM CATEGORY WHERE CATEGORYID = @search";

                cnn.Execute(sql, new { search = categoryId });
            }
        }


        //Update existing product
        public static void UpdateProduct(ProductModel product, int brandId, int categoryId)
        {
            using (IDbConnection cnn = new SQLiteConnection( LoadConnectionString()))
            {
                string sql = @"UPDATE OR IGNORE PRODUCT SET PRODUCTNAME = @name," + 
                    " COSTPRICE = @cost, LISTPRICE = @list, QUANTITY = @quantity," +
                    " DESCRIPTION = @description, UPDATEDON = datetime(CURRENT_TIMESTAMP, 'localtime')," +
                    " BRANDID = @brand, CATEGORYID = @category," +
                    " PICTURE = @picture WHERE PRODUCTID = @id";

                cnn.Execute(sql, new
                {
                    name = product.ProductName,
                    cost = product.CostPrice,
                    list = product.ListPrice,
                    quantity = product.Quantity,
                    description = product.Description,
                    brand = brandId,
                    category = categoryId,
                    picture = product.Picture,
                    id = product.ProductId
                });
            }
        }

        //Update existing brand
        public static void UpdateBrand(BrandModel brand)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"UPDATE OR IGNORE BRAND SET BRANDNAME = @name WHERE BRANDID = @id";

                cnn.Execute(sql, new { name = brand.BrandName, id = brand.BrandId });
            }
        }

        //Update existing category
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

        // <--POS-->
        
        public static List<SaleModel> LoadSales()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM SALE";

                var output = cnn.Query<SaleModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<SaleModel> LoadSearchedSale(string searchString)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM SALE WHERE SALEID = @search";

                var output = cnn.Query<SaleModel>(sql, new { search = searchString });
                return output.ToList();
            }
        }

        //save newly created product with brandId and categoryId
        public static void SaveSale(SaleModel sale, BindingList<CartItemModel> cart)
        {
            string saleSql = @"INSERT INTO SALE(SALEDATE, MISCPRICE, SALETOTAL) VALUES "+
                "(datetime(CURRENT_TIMESTAMP, 'localtime'), @misc, @total)";

            string idSql = @"SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = @name";

            string itemSql = @"INSERT INTO SALEDETAIL(SALEID, PRODUCTID, UNITPRICE, PRODUCTQUANTITY)" +
                " VALUES (@sale, @product, @unit, @quantity)";

            string productSql = @"UPDATE PRODUCT SET QUANTITY = QUANTITY - @quantity WHERE PRODUCTID = @product";

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (IDbTransaction trans = cnn.BeginTransaction())
                {
                    try
                    {
                        //Store Sale, and return SaleId
                        cnn.Execute(saleSql, new { misc = sale.MiscPrice, total = sale.SaleTotal });

                        var queryResult = cnn.ExecuteScalar(idSql, new { name = "Sale" });
                        int saleId = Convert.ToInt32(queryResult);
                        
                        //Store SaleDetail
                        foreach (var item in cart)
                        {
                            cnn.Execute(itemSql, new {
                                sale = saleId,
                                product = item.ProductId,
                                unit = item.UnitPrice,
                                quantity = item.Quantity
                            });

                            cnn.Execute(productSql, new {
                                quantity = item.Quantity,
                                product = item.ProductId
                            });

                        }

                        //Update Product

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }

            }
        }

    }

}
