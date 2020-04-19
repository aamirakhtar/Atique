using DataAccessService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.Templates
{
    class EntryPoint
    {
        public static void Main()
        {
            Book book = new Book() { Title = "Novel", Author = "Shakespear", Price = 500 };
            SmartPhone phone = new SmartPhone() { Model = "IphoneXS", Brand = "Apple", CameraMP = "16", Price = 2000, ScreenSize = 5 };
            Food food = new Food() { Type = "Steak", NonVeg = true, Origin = "France", Price = 300 };

            #region This Should not be used because we have to define Transportation class for all the products, which is unrealistic

            TransportBook transportBook = new TransportBook();
            transportBook.Departure(book);
            transportBook.Arrival(book);
            transportBook.Delivery(book);

            TransportSmartPhone transportPhone = new TransportSmartPhone();
            transportPhone.Departure(phone);
            transportPhone.Arrival(phone);
            transportPhone.Delivery(phone);

            TransportFood transportFood = new TransportFood();
            transportFood.Departure(food);
            transportFood.Arrival(food);
            transportFood.Delivery(food);

            #endregion

            #region Object Transportation it has type casting issue, thus should not be used
            //Object transportation, here type casting issue will arise
            Transport transport = new Transport();
            transport.Departure(book);
            transport.Arrival(book);
            transport.Delivery(book);

            #endregion

            #region This should be used, bcz we dont have to type cast the Types, and we dont suppose to make different Transportation class for each product

            //Templated class usage, Means Transport is a template which can have any type of product to Ship, bcz shipping process is same for all the products
            Transportation<Book> transportationB = new Transportation<Book>();
            transportationB.Departure(book);
            transportationB.Arrival(book);
            transportationB.Delivery(book);

            //Templated function
            Helper.AddTransportationRecord<Book>(book);

            Transportation<SmartPhone> transportationP = new Transportation<SmartPhone>();
            transportationP.Departure(phone);
            transportationP.Arrival(phone);
            transportationP.Delivery(phone);

            //Templated function
            Helper.AddTransportationRecord<SmartPhone>(phone);

            Transportation<Food> transportationF = new Transportation<Food>();
            transportationF.Departure(food);
            transportationF.Arrival(food);
            transportationF.Delivery(food);



            //Templated function
            Helper.AddTransportationRecord<Food>(food);

            #endregion

            //When to use Template Class:-
            //We use template class when we have to restrict all the function to the same type.
            //For coding perspective, we make template class so that we dont have to write Type name along with each function.
            //So the rule of thumb is, when you have same type of business in a class and most of the fucntions are using tempate type then template class should be made.

            //When to use Template Function:-
            //Template Functions should be used when you have hetrogenous or different functinalities in a class which is not tightly coupled with the class business.
            //eg see Helper Class

            Helper.CalculateTax<Book>(book);
            Helper.CalculateTax<SmartPhone>(phone);
            Helper.CalculateTax<Food>(food);

            //Here is implicit type casting is performed as book is type casted to product and product is a parent of book so type casting will be implicit
            Helper.CalculateTaxN(book);
            Helper.CalculateTaxN(phone);
            Helper.CalculateTaxN(food);

            //Class contraint usage, because Transportation will always handle some object but not the int, double, bool etc its not aligned with the business of transportation
            //Transportation<int> t = new Transportation<int>();
            //t.Departure(1);
            //t.Arrival(2);
            //t.Delivery(2);

            ValueTypeList<int> lst = new ValueTypeList<int>();
            lst.Add(1);
            lst.Remove(2);

            int i = 10;
            if (i.CompareTo(5) == 0)
                Console.WriteLine("Compared");
            else
                Console.WriteLine("Not-Compared");

            if (i.Equals(5))
                Console.WriteLine("Equal");

            Book b1 = new Book() { Title = "A", Author = "XYZ", Price = 50 };
            Book b2 = new Book() { Title = "A", Author = "XYZ", Price = 50 };

            Helper.IsBookCampared(b1, b2);

            Helper.IsCompared<Book>(b1, b2);

            Console.ReadLine();

            DataAccessLayer obj = new DataAccessLayer();
            //obj.connectionString it will not be available here bcz its protected internal, means protected outside the dll
        }
    }

    public class A : DataAccessLayer
    {
        public A()
        {
            this.connectionString = "connection string";
        }
    }

    #region Products
    public class Product
    {
        public double Price { get; set; }
    }

    public class Book : Product, IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public int CompareTo(Book book)
        {
            if (this.Title == book.Title)
                return 0;
            else
                return 1;
        }
    }

    public class SmartPhone : Product, IComparable<SmartPhone>
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int ScreenSize { get; set; }
        public string CameraMP { get; set; }

        public int CompareTo(SmartPhone phone)
        {
            if (this.Model == phone.Model && this.Brand == phone.Brand)
                return 0;
            else
                return 1;
        }
    }

    public class Food : Product
    {
        public string Origin { get; set; }
        public string Type { get; set; }
        public bool NonVeg { get; set; }
    }
    #endregion

    public class TransportBook
    {
        public void Departure(Book book)
        {
            Console.WriteLine("Book is Departing.");
        }

        public void Arrival(Book book)
        {
            Console.WriteLine("Book is Arrived.");
        }

        public void Delivery(Book book)
        {
            Console.WriteLine("Book is Delivered.");
        }
    }

    public class TransportSmartPhone
    {
        public void Departure(SmartPhone book)
        {
            Console.WriteLine("SmartPhone is Departing.");
        }

        public void Arrival(SmartPhone book)
        {
            Console.WriteLine("SmartPhone is Arrived.");
        }

        public void Delivery(SmartPhone book)
        {
            Console.WriteLine("SmartPhone is Delivered.");
        }
    }

    public class TransportFood
    {
        public void Departure(Food book)
        {
            Console.WriteLine("Food is Departing.");
        }

        public void Arrival(Food book)
        {
            Console.WriteLine("Food is Arrived.");
        }

        public void Delivery(Food book)
        {
            Console.WriteLine("Food is Delivered.");
        }
    }

    public class Transport
    {
        public void Departure(object product)
        {
            Console.WriteLine("Object is Departing.");
        }

        public void Arrival(object product)
        {
            Console.WriteLine("Object is Arrived.");
        }

        public void Delivery(object product)
        {
            Console.WriteLine("Object is Delivered.");
        }
    }

    //Generic Class, C# Generics, Templates
    public class Transportation<T> where T : class
    {
        public void Departure(T product)
        {
            Console.WriteLine(string.Format("{0} is Departing.", typeof(T)));
        }

        public void Arrival(T product)
        {
            Console.WriteLine("{0} is Arrived.", typeof(T));
        }

        public void Delivery(T product)
        {
            Console.WriteLine("{0} is Delivered.", typeof(T));
        }
    }

    public class ValueTypeList<T> : List<T> where T : struct
    {
        //private List<T> list = new List<T>();

        //public void Insert(T item)
        //{
        //    list.Add(item);
        //}

        //public void Delete(T item)
        //{
        //    list.Remove(item);
        //}
    }

    public class Helper
    {
        #region This Should not be used because we have to define record function for all the products, which is unrealistic and senseless
        public void AddBookTransportRecord(Book book)
        {
            Console.WriteLine("Book is recorded.");
        }

        public void AddPhoneTransportRecord(SmartPhone phone)
        {
            Console.WriteLine("Phone is recorded.");
        }

        public void AddFoodTransportRecord(Food food)
        {
            Console.WriteLine("Food is recorded.");
        }
        #endregion

        #region Object Transport record fuction has type casting issue, thus should not be used
        public void AddTransportRecord(object product)
        {
            Console.WriteLine("Object is recorded.");
        }
        #endregion

        #region This should be used, bcz we dont have to type cast the Types, and we dont suppose to make different Transportation Record functions for each product
        public static void AddTransportationRecord<T>(T product)
        {
            Console.WriteLine("{0} is recorded.", typeof(T));
        }

        public static bool IsNull<T>(T obj)
        {
            return obj == null;
        }

        //New Constraint: its used to create object of Templated Type
        public static T GetNewIfNull<T>(T obj) where T : new()
        {
            if (obj == null)
                return new T();
            else
                return obj;
        }

        //Parent Constraint
        //When you suppose to use a property of a family of classes in this case we want to use price which is a property of product family. Then we use Parent constraint
        public static void CalculateTax<T>(T product) where T : Product
        {
            product.Price = product.Price + 50;
            Console.WriteLine("Amount after Tax applied: {0}", product.Price);
        }

        //Normal scenario, it will have parent class as parameter but here is type casting issue
        public static void CalculateTaxN(Product product)
        {
            product.Price = product.Price + 50;
            Console.WriteLine("Amount after Tax applied: {0}", product.Price);
        }

        public static void Login<T>(T obj)
        {

        }

        public static void Logout<T>(T obj)
        {

        }

        public static void ShowProductNameByTitle(Book book)
        {
            book.Title = "Fiction";
            Console.WriteLine(book.Title);
        }

        public static bool IsCompared<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) == 0;
        }

        public static bool IsBookCampared(Book b1, Book b2)
        {
            if (b1.Title == b2.Title)
            {
                Console.WriteLine("Both books are same.");
                return true;
            }

            return false;
        }

        #endregion
    }
}