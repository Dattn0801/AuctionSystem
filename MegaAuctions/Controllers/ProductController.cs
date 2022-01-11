using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MegaAuctions.Models;

namespace MegaAuctions.Controllers
{
    public class ProductController : Controller
    {
        User userseller = MegaAuctions.Models.Content.userinformation;
        ProductModel promodel = new ProductModel();
        public ActionResult Index()
        {            
            ViewBag.ListProduct = promodel.ListProduct();
            return View(userseller);
        }
        // Edit 
        public ActionResult Edit(int id)
        {
            ViewBag.TypeProduct = promodel.ListTypeProduct();
            ViewBag.EditProduct = promodel.OneProduct(id);
            return View(userseller);
        }
        [HttpPost]
        public ActionResult Edit(Product pro, DesciptionProduct despro, TypeProduct typepro)
        {
            promodel.edit_product(pro,despro,typepro);
            return RedirectToAction("Edit");
        }
        //Review
        public ActionResult Review(int id)
        {
            ViewBag.ReViewList = promodel.ListReview();
            ViewBag.ReView = promodel.OneReview(id);
            return View(userseller);
        }
        [HttpPost]
        public ActionResult Review(Review rv, Product pro)
        {
            promodel.addReview(rv, pro);
            return RedirectToAction("Index");
        }

        //DETAIL
        public ActionResult Detail(int id)
        {
            ViewBag.DetailProduct = promodel.OneProduct(id);
            return View(userseller);
        }
        //ADD
        public ActionResult Create()
        {
            ViewBag.TypeProduct = promodel.ListTypeProduct();
            return View(userseller);
        }

        [HttpPost]
        public ActionResult Create(Product pro, DesciptionProduct despro, ImageProduct imgpro, TypeProduct typepro)
        {
            try
            {
                MegaAuctions.Models.Content.ran = MegaAuctions.Models.Content.RandomString(5);
                if (pro.upfiles.Length > 0)
                {   //iterating through multiple file collection   
                    for (int i = 0; i < pro.upfiles.Length; i++)
                    {
                        string file = Path.GetFileNameWithoutExtension(pro.upfiles[i].FileName);
                        string exten = Path.GetExtension(pro.upfiles[i].FileName);
                        file = MegaAuctions.Models.Content.ran + file + exten;
                        pro.upfiles[i].SaveAs(Path.Combine(Server.MapPath("~/img/products/ProductofUser/"), file));
                    }
                }
                promodel.add_product(pro, despro, imgpro, typepro);
                MegaAuctions.Models.Content.ran = "";
                return RedirectToAction("Index");
            }
            catch
            {
                promodel.add_product(pro, despro, imgpro, typepro);
                MegaAuctions.Models.Content.ran = "";
                return RedirectToAction("Index");
            }
        }
        public ActionResult Delete(int id)
        {           
            try
            {
                promodel.delete_product(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }    
}