using System;
using System.Web;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Race_boat_app.Models;

namespace Race_boat_app.Controllers
{
    public class UserController : Controller
    {
        static HttpClient client = new HttpClient();
        private static readonly string passPhrase = "l%HJb5N^O@fl0K02H9PsxlR9algJTzK7ARBjJsd3fPG0&GwkrU";
        private static readonly string passPhrase2 = "yUVyb$shjp4*%S6G!fx5t%i!fTZ@b8KQ#ymQyfhgNQ$#mKB0vA";

        public async Task<IActionResult> All()
        {
            List<User> users = await GetUsersAsync("https://localhost:44389/api/1.0/user");
            return View("Users", users);
            //return View("User");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> RegisterUser(User user)
        {
            if (ModelState.IsValid)
            {
                User crypto = new User();
                crypto.FirstName = Crypto.Encrypt(user.FirstName, passPhrase);
                crypto.Posistion = Crypto.Encrypt(user.Posistion, passPhrase);
                crypto.Address = Crypto.Encrypt(user.Address, passPhrase);
                crypto.City = Crypto.Encrypt(user.City, passPhrase);
                crypto.DOB = Crypto.Encrypt(user.DOB, passPhrase);
                crypto.Email = Crypto.Encrypt(user.Email, passPhrase);
                crypto.LastName = Crypto.Encrypt(user.LastName, passPhrase);
                crypto.PostCode = Crypto.Encrypt(user.PostCode, passPhrase);
                crypto.Password = Crypto.Encrypt(user.Password, passPhrase);
                crypto.Team = Crypto.Encrypt(user.Team, passPhrase);
                crypto.Points = Crypto.Encrypt(user.Points, passPhrase);
                crypto.PhoneNumber = Crypto.Encrypt(user.PhoneNumber, passPhrase);
                crypto.MobilePhoneNumber = Crypto.Encrypt(user.MobilePhoneNumber, passPhrase);
                var url = await CreateUserAsync(crypto);
                User encUser = await GetUserAsync(url.ToString());
                User decUser = DecryptUser(encUser);


                //HttpContext.Session.Set("User", Encoding.UTF8.GetBytes(decUser.FirstName));
                HttpContext.Session.SetString("_LoggedIn", "true");
                HttpContext.Session.SetString("_Name", decUser.FirstName);
                
                return View("profile", decUser);
            }

            return View("profile");
        }

        static User DecryptUser(User user) {
            user.Address = Crypto.Decrypt(user.Address, passPhrase);
            user.City = Crypto.Decrypt(user.City, passPhrase);
            user.DOB = Crypto.Decrypt(user.DOB, passPhrase);
            user.Email = Crypto.Decrypt(user.Email, passPhrase);
            user.FirstName = Crypto.Decrypt(user.FirstName, passPhrase);
            user.LastName = Crypto.Decrypt(user.LastName, passPhrase);
            user.PostCode = Crypto.Decrypt(user.PostCode, passPhrase);
            user.Password = Crypto.Decrypt(user.Password, passPhrase);
            user.Team = Crypto.Decrypt(user.Team, passPhrase2);
            user.Posistion = Crypto.Decrypt(user.Posistion, passPhrase);
            user.PhoneNumber = Crypto.Decrypt(user.PhoneNumber, passPhrase);
            user.MobilePhoneNumber = Crypto.Decrypt(user.MobilePhoneNumber, passPhrase);
            return user;
        }

        static async Task<User> GetUserAsync(string path)
        {
            User user = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }
            return user;
        }

        static async Task<Uri> CreateUserAsync(User crypto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://localhost:44389/api/1.0/user", crypto);
            response.EnsureSuccessStatusCode();
            // return URI of the created resource.

            return response.Headers.Location;
        }



        //public async Task<IActionResult> UserAll()
        //{
            
        //}

        static async Task<List<User>> GetUsersAsync(string path)
        {
            List<User> users = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsAsync<List<User>>();
            }
            //List<User> publicEncUsers = new List<User>();

            //foreach (User user in users)
            //{
            //    User crypto = new User();
            //    user.Address = Crypto.Decrypt(user.Address, passPhrase2);
            //    user.City = Crypto.Decrypt(user.City, passPhrase2);
            //    user.DOB = Crypto.Decrypt(user.DOB, passPhrase2);
            //    user.Email = Crypto.Decrypt(user.Email, passPhrase2);
            //    user.FirstName = Crypto.Decrypt(user.FirstName, passPhrase2);
            //    user.LastName = Crypto.Decrypt(user.LastName, passPhrase2);
            //    user.PostCode = Crypto.Decrypt(user.PostCode, passPhrase2);
            //    user.Password = Crypto.Decrypt(user.Password, passPhrase2);
            //    user.Team = Crypto.Decrypt(user.Team, passPhrase2);
            //    user.Posistion = Crypto.Decrypt(user.Posistion, passPhrase2);
            //    user.PhoneNumber = Crypto.Decrypt(user.PhoneNumber, passPhrase2);
            //    user.MobilePhoneNumber = Crypto.Decrypt(user.MobilePhoneNumber, passPhrase2);
            //    publicEncUsers.Add(crypto);
            //}
             return users;
        }
    }
}
