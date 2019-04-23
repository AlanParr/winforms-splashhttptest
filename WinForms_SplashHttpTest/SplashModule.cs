using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_SplashHttpTest
{
    public class SplashModule: NancyModule
    {
        public SplashModule()
        {
            Post["/show"] = x =>
            {
                SplashController.GetInstance().Show();
                return new Response() { StatusCode = HttpStatusCode.OK };
            };

            Post["/hide"] = x =>
            {
                SplashController.GetInstance().Hide();
                return new Response() { StatusCode = HttpStatusCode.OK };
            };
        }
    }
}
