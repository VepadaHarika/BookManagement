using BookManagementLibrary.BusinessLogicLayer;
using BookManagementLibrary.UserEnities;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementLibrary.PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Book Management System ");
            Console.WriteLine("Press 1 :Register");
            Console.WriteLine("Press 2 : Login ");

            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
                Register();
            else if (choice == 2)
                Login();
            else
                Console.WriteLine("Enter either 1 or 2 ");

        }
        public static UserEntity Register()

        {
            UserEntity user = new UserEntity();
            Console.WriteLine("Enter User ID ");
            user.userId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            user.firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName ");
            user.lastName = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            user.gender = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            user.dataOfBirth = Console.ReadLine();
            Console.WriteLine("Enter Email");
            user.email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            user.password = Console.ReadLine();

            Console.WriteLine("Press 1: Submit ");
            Console.WriteLine("Press 2: Cancel and Go Back");

            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
                return user;
            else if (choice == 2)
                user = null;
            else
                Console.WriteLine("Enter either 1 or 2 ");

            return null;

        }
        static void Login()
        {
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            Console.WriteLine("Press 1: Submit & quot");
            Console.WriteLine("Press 2: Cancel and Go Back");

            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
                DisplayBookManagementApp(email, password);

        }

        static void DisplayBookManagementApp(string email, string password)
        {
            Console.WriteLine("Welcome to Book Management System");
            Console.WriteLine("Press 1: Create new Book");
            Console.WriteLine("Press 2: View All Book ");
            Console.WriteLine("Press 3: Edit My Book");
            Console.WriteLine("Press 4: Search Book By ID");
Console.WriteLine("Press 5: Delete My Book ");

            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
                 CreateNewBook(email, password);
            else if (choice == 2)

                ViewAllBook(email, password);
            else if (choice == 3)
                EditMyBook(email, password);
            else if (choice == 4)
                SearchBookByID(email, password);
            else if (choice == 5)
                DeleteMyBook(email, password);

        }

        static void BookDetails(string email, string password)
        {
            Console.WriteLine("Enter Book Id ");
            int BookId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Book Name ");
            String BookName = Console.ReadLine();

            Console.WriteLine("Press 1: Submit");
            Console.WriteLine("Press 2: Cancel and Go Back");

            UserEntity userBook = new UserEntity();
            userBook.BookId = BookId;
            userBook.BookName = BookName;
            userBook.password = password;
            userBook.email = email;

            BusinessLogicLayer businessLogicLayerReference = new BusinessLogicLayer();
            UserEntity entity = businessLogicLayerReference.EnterBookDetails(userBook);

        }
        static void ViewAllBook(string email, string password)
        {

            UserEntity viewUser = new UserEntity();
            viewUser.email = email;
            viewUser.password = password;

            BusinessLogicLayer bussinessLogicLayerRference = new BusinessLogicLayer();
            UserEntity entity = bussinessLogicLayerRference.ViewAllBook(viewUser);

            foreach (UserEntity reference in entity)
            {
                Console.WriteLine("Book ID" +entity.password);

                Console.WriteLine("Book Name" +entity.bookname);
                Console.WriteLine("First Name" +entity.firstName);

            }
        }

        static void DeleteMyBook(string email, string password)
        {
            Console.WriteLine("Book ID");
            int bookId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Press 1: Submit");
            Console.WriteLine("Press 2: Cancel and Go Back");

            int choice = Convert.ToInt16(Console.ReadLine());

            UserEntity user = new UserEntity();
            user.email = email;
            user.password = password;
            user.bookId = bookId;

            if (choice == 1)
                BusinessLogicLayer businessLogicLayerReference = new BusinessLogicLayer();
            UserEntity entity = businessLogicLayerReference.DeleteMyBook(user);

        }

        static void ResetPassword(string email, string password)
        {
            Console.WriteLine("Enter New Password ");
            string newPassword = Console.ReadLine();

            Console.WriteLine(" Press 1: Submit new Password");
            Console.WriteLine("Press 2: Cancel and Go Back");

            UserEntity user = new UserEntity();
            user.email = email;
            user.password = password;
            user.password = newPassword;

            if (choice == 1)
                BusinessLogicLayer businessLogicLayerReference = new BusinessLogicLayer();
            businessLogicLayerReference.EnterBookDetails(user);
        }
    }
}
            
            
           
    
