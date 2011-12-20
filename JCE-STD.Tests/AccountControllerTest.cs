using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using JCE_STD;
using NUnit.Framework;


namespace JCE_STD.Test.Controller
{

    [TestFixture]
    public class AccountControllerTest
    {
        [Test]
        public void AControllerTest()
        {
           JCE_STD.Models.LogOnModel model = new Models.LogOnModel();
            JCE_STD.Controllers.AccountController AC = new Controllers.AccountController();
            JCE_STD.Controllers.HomeController success = new Controllers.HomeController();
            RouteValueDictionary rDic = new RouteValueDictionary();
            RedirectToRouteResult r = new RedirectToRouteResult("success",rDic);
            model.UserName = "arielle";
            model.Password = "1234";
           /*  Assert.AreEqual(r, AC.LogOn(model)); */
           
                
             ViewResult abc = new ViewResult();
           
            Assert.AreEqual(abc.View, AC.LogOn(model));

            
        }
    

    }

}