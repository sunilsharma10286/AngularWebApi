using AngularWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;

namespace AngularWebApi.Controllers
{
    public class ValuesController : ApiController
    {

        // GET api/values

        static int milliseconds = 0;
        public List<LeadCategory> Get()
        {
            Thread.Sleep(5000);
            var listCategory = TestData.GetLeadCategoryTestData().ToList();
            return listCategory;
        }

        // GET api/values/5
        //public HttpResponseMessage Get(string name)

        public IList<Employee> Get(string name)
        {
            IList<Employee> list = new List<Employee>();
            Employee emp1 = new Employee
            {
                id = 1,
                name = "sunil sharma",
                state = "CHD"
            };
            Employee emp2 = new Employee
            {
                id = 2,
                name = "Ashok sharma",
                state = "BLP"
            };
            list.Add(emp1);
            list.Add(emp2);
            //return Newtonsoft.Json.JsonConvert.SerializeObject(list);
            return list;
            //return Request.CreateResponse(HttpStatusCode.OK, list);
            // return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        //[HttpDelete]
        // DELETE api/values/5
        public List<LeadUserDetail> DeleteLead(int id, int categoryId)
        {
            milliseconds = 1000;
            Thread.Sleep(milliseconds);
            var listCategory = TestData.GetLeadUserCategoryTestData();
            return listCategory.Where(x => x.id != id && x.categoryId == categoryId).ToList();
        }
        public List<LeadUserDetail> GetUserLead(int categoryId, int userId)
        {
            if (milliseconds >= 5000)
            {
                milliseconds = 0;
            }
            milliseconds = milliseconds + 1000;
            Thread.Sleep(milliseconds);
            var listCategory = TestData.GetLeadUserCategoryTestData();
            var list = listCategory.Where(n => n.categoryId == categoryId && n.UserId == userId).ToList();
            return list;
        }

        [HttpGet]
        public User AuthenticateUser(string username, string password)
        {
            var userList = TestData.GetUserTestData();
            User userdetail = userList.SingleOrDefault(n => n.username == username && n.password == password);
            return userdetail;
        }

        //public List<LeadUserDetail> GetConfirmedUserLead()
        //{
        //    milliseconds = (milliseconds >= 5000) ? 1000 : milliseconds + 1000;
        //    Thread.Sleep(milliseconds);
        //    var listCategory = TestData.GetLeadUserCategoryTestData();
        //    var list = listCategory.Where(eachLeadDetail => eachLeadDetail.IsConfirm).ToList();
        //    return list;
        //}

        [HttpPost]
        public HttpResponseMessage UploadJsonFile()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/UploadFile/" + postedFile.FileName);
                    postedFile.SaveAs(filePath);
                }
            }
            return response;
        } 
    }



    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
    }
}