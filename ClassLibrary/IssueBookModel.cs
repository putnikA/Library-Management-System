using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class IssueBookModel
    {
        public int Id { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime DateReturned { get; set; }
        public StudentModel BorrowedBy { get; set; }
        public BookModel BorrowedBook { get; set; }
    }
}
