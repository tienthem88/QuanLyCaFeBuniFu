using QuanLyQuanCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }


        public static int TableWidth = 100;
        public static int TableHeight = 100;

        private TableDAO() { }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[]{id1, id2});
        }

        public List<DTO.Table> LoadTableList()
        {
            List<DTO.Table> tableList = new List<DTO.Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                DTO.Table table = new DTO.Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public Table GetTableByID(int id)
        {
            DTO.Table table = null;

            string query = "select * from TableFood where id =  " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                table = new DTO.Table(item);
                return table;
            }
            return table;
        }

        public List<DTO.Table> GetTableList()
        {
            List<DTO.Table> tableList = new List<DTO.Table>();
            string query = "select * from dbo.TableFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO.Table table = new DTO.Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public List<DTO.Table> SearchTableByName(string name)
        {
            List<DTO.Table> tableList = new List<DTO.Table>();
            string query = string.Format("SELECT * FROM dbo.TableFood WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO.Table table = new DTO.Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public bool InsertTable(string name, string status)
        {
            string query = string.Format("insert TableFood(name,status) values(N'{0}',N'{1}')", name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(string name, string status, int id)
        {
            string query = string.Format("update TableFood set name = N'{0}', status = N'{1}' where id = '{2}'", name, status, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            string query = string.Format("delete TableFood where id = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
