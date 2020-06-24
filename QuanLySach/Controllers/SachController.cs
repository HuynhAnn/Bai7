using QuanLySach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach {Id =1,Tilte="Toi thay hoa vang tren co xanh",AuthorName="Nguyen Nhat Anh",Price=1,Content="Truyen ke ve tuoi tho ..." },
            new Sach {Id =2,Tilte="Pro ASP.NET MVC5",AuthorName="Adam freeman",Price=3.75M,Content="The ASP.NET MVC 5 Framework is the latest evolution of MicroSoft's ASP.NET web platform." },
        };
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if(sach ==null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
