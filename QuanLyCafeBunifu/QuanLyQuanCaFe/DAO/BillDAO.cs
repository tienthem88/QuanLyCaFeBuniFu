using QuanLyQuanCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Bill where idTable = " + id + "and status = 0"); //"select id from dbo.Bill where idTable = " + id + " and status = 0"
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);  //Thành công : bill ID , Thất bại : -1
                return bill.ID;
            }

            return -1;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            return (int)DataProvider.Instance.ExecuteScalar("select max(id) from Bill");
        }
    }
}
