using BookManagementLibrary.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementLibrary.BussinessLogicLayer
{
    public class BookBussinessLogicLayer
    {
        public int Register()
        {
            DataAccessLayer D = new DataAccessLayer();
            return D.Register();
        }
        public int Login()
        {
            DataAccessLayer D = new DataAccessLayer();
            return D.Login();

        }
    }
}