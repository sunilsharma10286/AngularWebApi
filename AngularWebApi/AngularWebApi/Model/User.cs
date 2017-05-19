using System;
using System.Collections.Generic;

namespace AngularWebApi.Model
{

    public static class ApiData
    {
        public static List<LeadCategory> Categories { get; set; }
        public static List<LeadUserDetail> LeadsUserDetail { get; set; }
    }





    public class User
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string profileImage { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class LeadCategory
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public bool isloading { get; set; }
    }

    public class LeadUserDetail
    {
        public int id { get; set; }
        public string leadname { get; set; }
        public string Description { get; set; }
        public int categoryId { get; set; }
        public int UserId { get; set; }
        public string planmonthdate { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsActive { get; set; }
        public string Comment { get; set; }
    }

    public class TestData
    {
        public static List<User> GetUserTestData()
        {
            List<User> userList = new List<User>();
            User user1 = new User
            {
                userId = 1,
                username = "admin@evry.com",
                password = "admin123",
                profileImage = "",
                firstName = "admin",
                lastName = "evry"
            };

            User user2 = new User
            {
                userId = 1,
                username = "deepak.dhamija@evry.com",
                password = "admin123",
                profileImage = "",
                firstName = "deepak",
                lastName = "dhamija"
            };
            userList.Add(user1);
            userList.Add(user2);

            return userList;
        }


        public static List<LeadCategory> GetLeadCategoryTestData()
        {
            if (ApiData.Categories != null)
                return ApiData.Categories;


            List<LeadCategory> listCategory = new List<LeadCategory>();
            LeadCategory cat1 = new LeadCategory
            {
                categoryid = 1001,
                categoryname = "Category 1",
                isloading = true
            };

            LeadCategory cat2 = new LeadCategory
            {
                categoryid = 1002,
                categoryname = "Category 2",
                isloading = true
            };
            LeadCategory cat3 = new LeadCategory
            {
                categoryid = 1003,
                categoryname = "Category 3",
                isloading = true
            };
            LeadCategory cat4 = new LeadCategory
            {
                categoryid = 1004,
                categoryname = "Category 4",
                isloading = true
            };
            LeadCategory cat5 = new LeadCategory
            {
                categoryid = 1005,
                categoryname = "Category 5",
                isloading = true
            };
            listCategory.Add(cat1);
            listCategory.Add(cat2);
            listCategory.Add(cat3);
            listCategory.Add(cat4);
            listCategory.Add(cat5);

            ApiData.Categories = listCategory;

            return listCategory;
        }

        public static List<LeadUserDetail> GetLeadUserCategoryTestData()
        {
            if (ApiData.LeadsUserDetail != null)
                return ApiData.LeadsUserDetail;


            List<LeadUserDetail> listUserCategory = new List<LeadUserDetail>();
            LeadUserDetail catLeadUser1 = new LeadUserDetail
            {
                id = 1,
                categoryId = 1001,
                UserId = 1,
                leadname = "facebook app",
                Description = "facebook app detail",
                planmonthdate = "2017-02-17",
            };
            LeadUserDetail catLeadUser2 = new LeadUserDetail
            {
                id = 2,
                categoryId = 1001,
                UserId = 1,
                leadname = "test app",
                Description = "test app detail",
                planmonthdate = "2017-04-18",
            };
            LeadUserDetail catLeadUser3 = new LeadUserDetail
            {
                id = 3,
                categoryId = 1002,
                UserId = 1,
                leadname = "google app",
                Description = "google app detail",
                planmonthdate = "2017-06-19",
            };
            LeadUserDetail catLeadUser4 = new LeadUserDetail
            {
                id = 4,
                categoryId = 1002,
                UserId = 1,
                leadname = "span app",
                Description = "span app detail",
                planmonthdate = "2017-01-20",
            };
            LeadUserDetail catLeadUser5 = new LeadUserDetail
            {
                id = 5,
                categoryId = 1003,
                UserId = 1,
                leadname = "evry app",
                Description = "evry app detail",
                planmonthdate = "2017-04-10",
            };
            LeadUserDetail catLeadUser6 = new LeadUserDetail
            {
                id = 6,
                categoryId = 1003,
                UserId = 1,
                leadname = "yahoo app",
                Description = "yahoo app detail",
                planmonthdate = "2017-08-09",

            };
            LeadUserDetail catLeadUser7 = new LeadUserDetail
            {
                id = 7,
                categoryId = 1004,
                UserId = 1,
                leadname = "evry app",
                Description = "evry app detail",
                planmonthdate = "2017-06-12",
            };
            LeadUserDetail catLeadUser8 = new LeadUserDetail
            {
                id = 8,
                categoryId = 1004,
                UserId = 1,
                leadname = "yahoo app",
                Description = "yahoo app detail",
                planmonthdate = "2017-12-17",
            };
            LeadUserDetail catLeadUser9 = new LeadUserDetail
            {
                id = 9,
                categoryId = 1005,
                UserId = 1,
                leadname = "evry app",
                Description = "evry app detail",
                planmonthdate = "2017-03-13",
            };
            LeadUserDetail catLeadUser10 = new LeadUserDetail
            {
                id = 10,
                categoryId = 1005,
                UserId = 1,
                leadname = "yahoo app",
                Description = "yahoo app detail",
                planmonthdate = "2017-05-15",
            };
            listUserCategory.Add(catLeadUser1);
            listUserCategory.Add(catLeadUser2);
            listUserCategory.Add(catLeadUser3);
            listUserCategory.Add(catLeadUser4);
            listUserCategory.Add(catLeadUser5);
            listUserCategory.Add(catLeadUser6);
            listUserCategory.Add(catLeadUser7);
            listUserCategory.Add(catLeadUser8);
            listUserCategory.Add(catLeadUser9);
            listUserCategory.Add(catLeadUser10);

            ApiData.LeadsUserDetail = listUserCategory;

            return listUserCategory;
        }
    }
}