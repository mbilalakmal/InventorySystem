using Dapper;
using POSINV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace POSINV
{
    /// <summary>
    /// Provides static functions to access SQLite database
    /// </summary>
    public class SQLiteDataAccess
    {
        
        /// <summary>
        /// Load all Products from DB
        /// </summary>
        /// <param name="OrderBy"></param>
        /// <returns></returns>
        public static List<ProductModel> LoadProducts(String OrderBy = "PRODUCTNAME")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM PRODUCT NATURAL JOIN BRAND NATURAL JOIN CATEGORY";

                var output = cnn.Query<ProductModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// Load all Brands from DB
        /// </summary>
        /// <returns></returns>
        public static List<BrandModel> LoadBrands()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM BRAND";

                var output = cnn.Query<BrandModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }
        
        /// <summary>
        /// Load all Categories from DB
        /// </summary>
        /// <returns></returns>
        public static List<CategoryModel> LoadCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM CATEGORY";

                var output = cnn.Query<CategoryModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// Save a new Product. Also returns the ID of the stored row
        /// </summary>
        /// <param name="product"></param>
        /// <param name="brandId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public static int SaveProduct(ProductModel product, int brandId, int categoryId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string idSql = @"SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = @name";

                string sql = @"INSERT INTO PRODUCT(" +
                    "COSTPRICE, LISTPRICE, QUANTITY, DESCRIPTION, " +
                    "UPDATEDON, BRANDID, CATEGORYID, PICTURE)" +
                    " VALUES (@cost, @list, @quantity, @description, " +
                    "datetime(CURRENT_TIMESTAMP, 'localtime'), @brand, @category, @picture)";

                cnn.Execute(sql, new
                {
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

        /// <summary>
        /// Save a new Brand. Also returns the ID of the stored row
        /// </summary>
        /// <param name="brandName"></param>
        /// <returns></returns>
        public static int SaveBrand(string brandName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string idSql = @"SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = @name";

                string sql = @"INSERT INTO BRAND (BRANDNAME) VALUES (@name)";

                cnn.Execute(sql, new { name = brandName });

                int brandId = Convert.ToInt32(cnn.ExecuteScalar(idSql, new { name = "Brand" }));

                return brandId;
            }
        }

        /// <summary>
        /// Save a new Category. Also returns the ID of the stored row
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public static int SaveCategory(string categoryName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string idSql = @"SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = @name";

                string sql = @"INSERT INTO CATEGORY (CATEGORYNAME) VALUES (@name)";

                cnn.Execute(sql, new { name = categoryName });

                int categoryId = Convert.ToInt32(cnn.ExecuteScalar(idSql, new { name = "Category" }));

                return categoryId;
            }
        }

        /// <summary>
        /// Delete Product with given Product ID. Throws exception if any constraint is failed
        /// </summary>
        /// <param name="productId"></param>
        public static void DeleteProduct(int productId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"PRAGMA foreign_keys = ON;DELETE FROM PRODUCT WHERE PRODUCTID = @search";

                    cnn.Execute(sql, new { search = productId });
            }
        }

        /// <summary>
        /// Delete Brand with given Brand ID. Throws exception if any constraint is failed
        /// </summary>
        /// <param name="brandId"></param>
        public static void DeleteBrand(int brandId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"PRAGMA foreign_keys = ON;DELETE FROM BRAND WHERE BRANDID = @search";

                cnn.Execute(sql, new { search = brandId });
                
            }
        }

        /// <summary>
        /// Delete Category with given Category ID. Throws exception if any constraint is failed
        /// </summary>
        /// <param name="categoryId"></param>
        public static void DeleteCategory(int categoryId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"PRAGMA foreign_keys = ON;DELETE FROM CATEGORY WHERE CATEGORYID = @search";

                cnn.Execute(sql, new { search = categoryId });
            }
        }

        /// <summary>
        /// Update Product column(s). Throws exception if any constraint is failed
        /// </summary>
        /// <param name="product"></param>
        /// <param name="brandId"></param>
        /// <param name="categoryId"></param>
        public static void UpdateProduct(ProductModel product, int brandId, int categoryId)
        {
            using (IDbConnection cnn = new SQLiteConnection( LoadConnectionString()))
            {
                string sql = @"UPDATE PRODUCT SET" + 
                    " COSTPRICE = @cost, LISTPRICE = @list, QUANTITY = @quantity," +
                    " DESCRIPTION = @description, UPDATEDON = datetime(CURRENT_TIMESTAMP, 'localtime')," +
                    " BRANDID = @brand, CATEGORYID = @category," +
                    " PICTURE = @picture WHERE PRODUCTID = @id";

                cnn.Execute(sql, new
                {
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

        /// <summary>
        /// Update Brand column(s). Throws exception if any constraint is failed
        /// </summary>
        /// <param name="brand"></param>
        public static void UpdateBrand(BrandModel brand)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"UPDATE BRAND SET BRANDNAME = @name WHERE BRANDID = @id";

                cnn.Execute(sql, new { name = brand.BrandName, id = brand.BrandId });
            }
        }
        
        /// <summary>
        /// Update Category column(s). Throws exception if any constraint is failed
        /// </summary>
        /// <param name="category"></param>
        public static void UpdateCategory(CategoryModel category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"UPDATE CATEGORY SET CATEGORYNAME = @name WHERE CATEGORYID = @id";

                cnn.Execute(sql, new { name = category.CategoryName, id = category.CategoryId });
            }
        }
        
        // <--POS-->
        
        /// <summary>
        /// Load All Sales from DB
        /// </summary>
        /// <returns>List of SaleModel</returns>
        public static List<SaleModel> LoadSales()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM SALE";

                var output = cnn.Query<SaleModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }
        
        /// <summary>
        /// Save a new Sale to DB. Also saves Sale Items and updates Products' quantities
        /// </summary>
        /// <param name="sale"></param>
        /// <param name="cart"></param>
        /// <returns></returns>
        public static int SaveSale(SaleModel sale, BindingList<CartItemModel> cart)
        {
            string saleSql = @"INSERT INTO SALE(SALEDATE, MISCPRICE, SALETOTAL) VALUES "+
                "(datetime(CURRENT_TIMESTAMP, 'localtime'), @misc, @total)";

            string idSql = @"SELECT SEQ FROM SQLITE_SEQUENCE WHERE NAME = @name";

            string itemSql = @"INSERT INTO SALEDETAIL(SALEID, PRODUCTID, DESCRIPTION, UNITCOST, UNITPRICE, QUANTITY)" +
                " VALUES (@sale, @productId, @description, @unitCost, @unitPrice, @quantity)";

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
                                productId = item.ProductId,
                                description = item.Description,
                                unitCost = item.UnitCost,
                                unitPrice = item.UnitPrice,
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
        
        /// <summary>
        /// Delete Sale by matching sale ID. Also deletes Sale Items and updates Products' quantities
        /// </summary>
        /// <param name="saleId"></param>
        public static void DeleteSale(int saleId)
        {
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

        /// <summary>
        /// View Sale details: returns cart items
        /// </summary>
        /// <param name="saleId"></param>
        public static List<CartItemModel> ViewSale(int saleId)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"SELECT * FROM SALEDETAIL WHERE SALEID = @search";

                var output = cnn.Query<CartItemModel>(sql, new { search = saleId });

                return output.ToList();
            }

        }

        /// <summary>
        /// Returns the connection string specified by the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /*
         * fin.
        */

    }

}
