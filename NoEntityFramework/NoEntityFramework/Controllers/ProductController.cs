using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using NoEntityFramework.Models;

namespace NoEntityFramework.Controllers
{
	public class ProductController : Controller
	{
		// GET: ProductController
		string ConnectionString = "Server=DESKTOP-UAD5JOD;Database=MvcCurdDb;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False";
		[HttpGet]
		public ActionResult Index()
		{
			DataTable dt = new DataTable();
			using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
			{
				sqlConn.Open();
				SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Product", sqlConn);
				sqlDa.Fill(dt);
			}
			return View(dt);
		}

		// GET: ProductController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: ProductController/Create
		public ActionResult Create()
		{
			return View(new ProductModel());
		}

		// POST: ProductController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ProductController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: ProductController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ProductController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: ProductController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
