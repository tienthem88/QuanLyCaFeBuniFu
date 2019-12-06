using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instances;

        public static MenuDAO Instances
        {
            get { if (instances == null) instances = new MenuDAO(); return MenuDAO.instances; }
            private set { MenuDAO.instances = value; }
        }

        private MenuDAO() { }

        public List<QuanLyQuanCaFe.DTO.Menu> GetListMenuByTable(int id)
        {
            List<QuanLyQuanCaFe.DTO.Menu> listMenu = new List<QuanLyQuanCaFe.DTO.Menu>();
            string query = "select f.name, bi.count ,f.price, f.price*bi.count as totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food  as f where bi.idBill = b.id and bi.idFood = f.id and b.status = 0  and b.idTable = " + id;


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QuanLyQuanCaFe.DTO.Menu menu = new QuanLyQuanCaFe.DTO.Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

    }
}
