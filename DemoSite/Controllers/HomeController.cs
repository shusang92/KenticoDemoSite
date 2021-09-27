using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

using DemoSite.Controllers;

using CMS.Core;
using CMS.DocumentEngine;

using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;

//[assembly: RegisterPageRoute("NewSite.Home", typeof(HomeController))]

namespace DemoSite.Controllers
{
    public class HomeController : Controller
    {
        // Uncomment when passing a model with page data to the view
        //private readonly IPageRetriever pageRetriever;

        //public HomeController()
        //{
        //    // Consider replacing the call with dependency injection. See the documentation for details on how to set up dependency injection in MVC.
        //    pageRetriever = Service.Resolve<IPageRetriever>();
        //}

        // GET: Home
        public ActionResult Index()
        {
            // See ~/App_Start/ApplicationConfig.cs, ~/Views/Shared/_Layout.cshtml and ~/Views/Home/Index.cshtml
            // In the administration UI, create a Page type with a namespace called 'NewSite', code name 'Home', and set its features to:
            //   Page builder = True
            //   URL = True
            //   Metadata = True
            // In the administration UI, create a Page utilizing the new Page type


            // Uncomment when passing a model with page data to the view
            // The following is an example of retrieving the current page, which can be used, e.g. to populate the model to view.
            // You can filter out the pages by including and modifying the query argument.
            // In this example, by specifying the query argument's Path, only pages on the "/Home" path will be retrieved.
            //TreeNode page = pageRetriever.Retrieve<TreeNode>(query => query.Path("/Home"), cache => cache.Key($"{nameof(HomeController)}|home")).FirstOrDefault();

            return View();
        }
    }
}