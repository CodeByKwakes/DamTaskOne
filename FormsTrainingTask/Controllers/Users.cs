using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsTrainingTask.Models;

namespace FormsTrainingTask.Controllers
{
    public class Users
    {
        public List<UserModel> userList = new List<UserModel>();

        //public Users()
        //{
        //    userList.Add(new UserModel { Id = 1, FirstName = "kwakes", LastName = "prempeh", City = "london", Email = "kwakes@me.com" });
        //}

        // Create User Method
        public void CreateUser(UserModel userModel)
        {
            userList.Add(userModel);
        }

        // Updating User Method
        public void UpdateUser(UserModel userModel)
        {
            foreach (UserModel ulist in userList)
            {
                if (ulist.Id == userModel.Id)
                {
                    userList.Remove(ulist);
                    userList.Add(userModel);
                }
            }
        }


    }
    
}