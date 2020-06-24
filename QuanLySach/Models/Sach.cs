using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLySach.Models
{
    public class Sach
    {
        public int Id { set; get; }
        public string Tilte { set; get; }
        public string  Content { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
    }
}