using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BookModel
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        //public List<StudentModel> BorrowedBy { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime DateReturned { get; set; }
    }
}
