using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlBinary
{
    [Serializable]
     public class Book
    {
        public string name;
        public string author;
        public int cost;
        public Book()
        {

        }
        public Book(string name, string author,int cost)
        {
            this.name = name;
            this.author = author;
            this.cost = cost;
        }
        public override string ToString()
        {
            return String.Format(" '{0}'{1},{2}", name, author, cost);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Maze Runner", "Khaled Xoiseini", 2500);

            /*FileStream fs = new FileStream("book.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(Book));
            xm.Serialize(fs, b);
            fs.Close();

            FileStream fs1 = new FileStream("book.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Book b1 = (Book)xm.Deserialize(fs1); 
            fs1.Close();
            Console.WriteLine(b1);*/
            IFormatter f = new BinaryFormatter();
            Stream fs = new FileStream("book.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            f.Serialize(fs,b);
            fs.Close();

            Stream fs1 = new FileStream("book.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Book b1 = (Book)f.Deserialize(fs1);
            fs1.Close();
            Console.WriteLine(b1);
        }
    }
}
