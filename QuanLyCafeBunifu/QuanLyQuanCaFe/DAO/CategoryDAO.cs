﻿using QuanLyQuanCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }


        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from FoodCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public List<Category> SearchCategoryByName(string name)
        {
            List<Category> list = new List<Category>();

            string query = string.Format("SELECT * FROM dbo.Category WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;

            List<Category> list = new List<Category>();

            string query = "select * from FoodCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }

        public DataTable GetAllCategory()
        {
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool insertCategory(string name)
        {
            string queryInsert = string.Format("insert FoodCategory(name) values (N'{0}')", name);

            int result = DataProvider.Instance.ExecuteNonQuery(queryInsert);
            return result > 0;

        }
        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("update FoodCategory set name = N'{0}' where id = {1}", name, id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public bool DeleteCategory(int idCategory)
        {
            string query = string.Format("delete FoodCategory where id = '{0}'", idCategory);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }


    }
}
