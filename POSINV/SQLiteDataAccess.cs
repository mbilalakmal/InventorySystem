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
        
        public static List<ProductModel> LoadProducts(String OrderBy = "PRODUCTNAME")
        {
            /// <summary>
            /// Load All Products From DB
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM PRODUCT NATURAL JOIN BRAND NATURAL JOIN CATEGORY";

                var output = cnn.Query<ProductModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }
        
        public static List<ProductModel> LoadSearchedProducts(String searchString)
        {
            /// <summary>
            /// Load Products by matching Product Names with given string
            /// </summary>
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
            /// <summary>
            /// Load All Brands From DB
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM BRAND";

                var output = cnn.Query<BrandModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }
        
        public static List<BrandModel> LoadSearchedBrands(string searchString)
        {
            /// <summary>
            /// Load Brands by matching Brand Names with given string
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM BRAND WHERE BRANDNAME LIKE @search";

                var output = cnn.Query<BrandModel>(sql, new { search = '%' + searchString + '%' });
                return output.ToList();
            }
        }
        
        public static List<CategoryModel> LoadCategories()
        {
            /// <summary>
            /// Load All Brands From DB
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM CATEGORY";

                var output = cnn.Query<CategoryModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }
        
        public static List<CategoryModel> LoadSearchedCategories(string searchString)
        {
            /// <summary>
            /// Load Categories by matching Category Names with given string
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM CATEGORY WHERE CATEGORYNAME LIKE @search";

                var output = cnn.Query<CategoryModel>(sql, new { search = '%' + searchString + '%' });
                return output.ToList();
            }
        }

        public static int SaveProduct(ProductModel product, int brandId, int categoryId)
        {
            /// <summary>
            /// Save New Product to DB
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string idSql = @"SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = @name";

                string sql = @"INSERT INTO PRODUCT(" +
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

                int productId = Convert.ToInt32(cnn.ExecuteScalar(idSql, new { name = "Product" }));

                return productId;

            }
        }
        
        public static int SaveBrand(string brandName)
        {
            /// <summary>
            /// Save New Brand to DB and return BrandId
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string idSql = @"SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = @name";

                string sql = @"INSERT INTO BRAND (BRANDNAME) VALUES (@name)";

                cnn.Execute(sql, new { name = brandName });

                int brandId = Convert.ToInt32(cnn.ExecuteScalar(idSql, new { name = "Brand" }));

                return brandId;
            }
        }

        public static int SaveCategory(string categoryName)
        {
            /// <summary>
            /// Save New Category to DB
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string idSql = @"SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = @name";

                string sql = @"INSERT INTO CATEGORY (CATEGORYNAME) VALUES (@name)";

                cnn.Execute(sql, new { name = categoryName });

                int categoryId = Convert.ToInt32(cnn.ExecuteScalar(idSql, new { name = "Category" }));

                return categoryId;
            }
        }

        public static void DeleteProduct(int productId)
        {
            /// <summary>
            /// Delete Product with given Product ID. Throws exception if references exist in Sale Items
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"PRAGMA foreign_keys = ON;DELETE FROM PRODUCT WHERE PRODUCTID = @search";

                    cnn.Execute(sql, new { search = productId });
            }
        }
        
        public static void DeleteBrand(int brandId)
        {
            /// <summary>
            /// Delete Brand with given Brand ID. Throws exception if references exist in Products
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"PRAGMA foreign_keys = ON;DELETE FROM BRAND WHERE BRANDID = @search";

                cnn.Execute(sql, new { search = brandId });
                
            }
        }
        
        public static void DeleteCategory(int categoryId)
        {
            /// <summary>
            /// Delete Category with given Category ID. Throws exception if references exist in Products
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"PRAGMA foreign_keys = ON;DELETE FROM CATEGORY WHERE CATEGORYID = @search";

                cnn.Execute(sql, new { search = categoryId });
            }
        }
        
        public static void UpdateProduct(ProductModel product, int brandId, int categoryId)
        {
            /// <summary>
            /// Update Product Column(s). Throws Exception if Product Name is not unique
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection( LoadConnectionString()))
            {
                string sql = @"UPDATE PRODUCT SET PRODUCTNAME = @name," + 
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
        
        public static void UpdateBrand(BrandModel brand)
        {
            /// <summary>
            /// Update Brand Column(s). Throws Exception if Brand Name is not unique
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"UPDATE BRAND SET BRANDNAME = @name WHERE BRANDID = @id";

                cnn.Execute(sql, new { name = brand.BrandName, id = brand.BrandId });
            }
        }
        
        public static void UpdateCategory(CategoryModel category)
        {
            /// <summary>
            /// Update Category Column(s). Throws Exception if Category Name is not unique
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"UPDATE CATEGORY SET CATEGORYNAME = @name WHERE CATEGORYID = @id";

                cnn.Execute(sql, new { name = category.CategoryName, id = category.CategoryId });
            }
        }
        
        // <--POS-->
        
        public static List<SaleModel> LoadSales()
        {
            /// <summary>
            /// Load All Sales from DB
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM SALE";

                var output = cnn.Query<SaleModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<SaleModel> LoadSearchedSale(string searchString)
        {
            /// <summary>
            /// Load Sale by matching Sale ID
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM SALE WHERE SALEID = @search";

                var output = cnn.Query<SaleModel>(sql, new { search = searchString });
                return output.ToList();
            }
        }
        
        public static int SaveSale(SaleModel sale, BindingList<CartItemModel> cart)
        {
            /// <summary>
            /// Save New Sale to DB. Also stores Sale Items & Updates Products' quantities
            /// </summary>
            string saleSql = @"INSERT INTO SALE(SALEDATE, MISCPRICE, SALETOTAL) VALUES "+
                "(datetime(CURRENT_TIMESTAMP, 'localtime'), @misc, @total)";

            string idSql = @"SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = @name";

            string itemSql = @"INSERT INTO SALEDETAIL(SALEID, PRODUCTID, UNITPRICE, QUANTITY)" +
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
                        cnn.Execute(saleSql, new { misc = sale.MiscPrice, total = sale.SaleTotal }, transaction: trans);
                        int saleId = Convert.ToInt32(cnn.ExecuteScalar(idSql, new { name = "Sale" }, transaction: trans));
                        
                        //Store SaleDetail
                        foreach (var item in cart)
                        {
                            cnn.Execute(itemSql, new {
                                sale = saleId,
                                product = item.ProductId,
                                unit = item.UnitPrice,
                                quantity = item.Quantity
                            }, transaction: trans);

                            cnn.Execute(productSql, new {
                                quantity = item.Quantity,
                                product = item.ProductId
                            }, transaction: trans);

                        }

                        trans.Commit();

                        return saleId;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        
        public static void DeleteSale(int saleId)
        {
            /// <summary>
            /// Delete Sale by matching Sale ID. Also deletes Sale Items & Updates Products' quantities
            /// </summary>
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                //TURN on foregin key pragma for cascading deletes
                cnn.Execute(@"PRAGMA foreign_keys = ON");
                using (IDbTransaction trans = cnn.BeginTransaction())
                {
                    string saleSql = @"DELETE FROM SALE WHERE SALEID = @search";

                    string itemSql = @"SELECT * FROM SALEDETAIL WHERE SALEID = @sale";

                    string productSql = @"UPDATE PRODUCT SET QUANTITY = QUANTITY + @quantity WHERE PRODUCTID = @product";

                    try
                    {
                        //get cart items
                        List<CartItemModel> cart = cnn.Query<CartItemModel>(itemSql,
                            new { sale = saleId }, transaction: trans
                        ).ToList();

                        //update product quantities
                        foreach(var item in cart)
                        {
                            cnn.Execute(productSql, new
                            {
                                quantity = item.Quantity,
                                product = item.ProductId
                            }, transaction: trans);
                        }

                        //delete sale & sale items(CASCADED)
                        cnn.Execute(saleSql, new { search = saleId }, transaction: trans);

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


        private static string LoadConnectionString(string id = "Default")
        {
            /// <summary>
            /// Returns the connection string from config
            /// </summary>
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /*
         * fin.
        */

    }

}
