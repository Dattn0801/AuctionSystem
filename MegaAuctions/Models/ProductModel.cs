using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;

namespace MegaAuctions.Models
{
    public class ProductModel
    {
        DBEntitiesAuction db = new DBEntitiesAuction();
        public IEnumerable<Product> ListProduct()
        {
            return db.Products.ToList();
        }
        public IEnumerable<TypeProduct> ListTypeProduct()
        { 
            return db.TypeProducts.ToList();
        }
        public IEnumerable<Review> ListReview()
        {
            return db.Reviews.ToList();
        }
        public Review OneReview(int id)
        {
            return db.Reviews.First(m => m.idproduct == id);
        }
        public Product OneProduct(int id)
        {
            return db.Products.First(m => m.idproduct == id);
        }
        public ImageProduct OneListImgae(int id)
        {
            return db.ImageProducts.First(m => m.idimgpro == id);
        }
        public DesciptionProduct OneDespro(int id)
        {
            return db.DesciptionProducts.First(m => m.iddespro == id);
        }

        public void add_product(Product pro, DesciptionProduct despro, ImageProduct imgpro, TypeProduct typepro) 
        {
            ImageProduct img = new ImageProduct();
            DesciptionProduct des = new DesciptionProduct();
            Product p = new Product();
            try
            {                
                img.image1 = MegaAuctions.Models.Content.ran + imgpro.image1;
                img.image2 = MegaAuctions.Models.Content.ran + imgpro.image2;
                img.image3 = MegaAuctions.Models.Content.ran + imgpro.image3;
                img.image4 = MegaAuctions.Models.Content.ran + imgpro.image4;
                img.image5 = MegaAuctions.Models.Content.ran + imgpro.image5;
                db.ImageProducts.Add(img);
                db.SaveChanges(); //1 id img dc tao
                des.color = despro.color;
                des.size = despro.size;
                des.origin = despro.origin;
                des.material = despro.material;
                des.condition = despro.condition;
                des.other = despro.other;
                db.DesciptionProducts.Add(des);
                db.SaveChanges(); //1 id des dc tao
                p.namepro = pro.namepro;
                p.descriptionpro = pro.descriptionpro;
                p.priceauction = pro.priceauction;
                p.pricebuy = pro.pricebuy;
                p.datestart = pro.datestart;
                p.dateend = pro.dateend;
                p.timestart = pro.timestart;
                p.timeend = pro.timeend;
                p.statuspro = "Action";
                string[] idtype = typepro.nametp.Split('.');
                p.idtypepro = int.Parse(idtype[0]);
                p.idimgpro = img.idimgpro;
                p.iddespro = des.iddespro;
                p.idUser = Content.userinformation.idUser;
                db.Products.Add(p);
                db.SaveChanges();
            }
            catch
            {
                try
                {
                    des.color = despro.color;
                    des.size = despro.size;
                    des.origin = despro.origin;
                    des.material = despro.material;
                    des.condition = despro.condition;
                    des.other = despro.other;
                    db.DesciptionProducts.Add(des);
                    db.SaveChanges(); //1 id des dc tao 
                    p.namepro = pro.namepro;
                    p.descriptionpro = pro.descriptionpro;
                    p.priceauction = pro.priceauction;
                    p.pricebuy = pro.pricebuy;
                    p.datestart = pro.datestart;
                    p.dateend = pro.dateend;
                    p.timestart = pro.timestart;
                    p.timeend = pro.timeend;
                    p.statuspro = "Action";
                    string[] idtype = typepro.nametp.Split('.');
                    p.idtypepro = int.Parse(idtype[0]);
                    p.idimgpro = img.idimgpro;
                    p.iddespro = des.iddespro;
                    p.idUser = Content.userinformation.idUser;
                    db.Products.Add(p);
                    db.SaveChanges();
                }
                catch
                {
                    p.namepro = pro.namepro;
                    p.descriptionpro = pro.descriptionpro;
                    p.priceauction = pro.priceauction;
                    p.pricebuy = pro.pricebuy;
                    p.datestart = pro.datestart;
                    p.dateend = pro.dateend;
                    p.timestart = pro.timestart;
                    p.timeend = pro.timeend;
                    p.statuspro = "Action";
                    string[] idtype = typepro.nametp.Split('.');
                    p.idtypepro = int.Parse(idtype[0]);
                    p.idimgpro = img.idimgpro;
                    p.iddespro = des.iddespro;
                    p.idUser = Content.userinformation.idUser;
                    db.Products.Add(p);
                    db.SaveChanges();
                }                   
            }
                        
        }
        public void delete_product(int id)
        {
            Product pro = OneProduct(id);
            ImageProduct imgpr = OneListImgae(pro.ImageProduct.idimgpro);           
            DesciptionProduct despro = OneDespro(pro.DesciptionProduct.iddespro);
            db.Products.Remove(pro);
            db.ImageProducts.Remove(imgpr);
            db.DesciptionProducts.Remove(despro);
            db.SaveChanges();
        }
        public void EditEndStatusPro(int idpro) 
        {
            Product pro = OneProduct(idpro);
            pro.statuspro = "End";
            db.SaveChanges();
        }
        public void edit_product(Product pro, DesciptionProduct despro, TypeProduct typepro)
        {
            Product p = OneProduct(pro.idproduct);
            DesciptionProduct des = OneDespro(p.DesciptionProduct.iddespro);
            des.color = despro.color;
            des.size = despro.size;
            des.origin = despro.origin;
            des.material = despro.material;
            des.condition = despro.condition;
            des.other = despro.other;
            db.SaveChanges(); //1 id des dc tao
            p.namepro = pro.namepro;
            p.descriptionpro = pro.descriptionpro;
            p.priceauction = pro.priceauction;
            p.pricebuy = pro.pricebuy;
            p.datestart = pro.datestart;
            p.dateend = pro.dateend;
            p.timestart = pro.timestart;
            p.timeend = pro.timeend;
            //p.statuspro = "Action";
            //string[] idtype = typepro.nametp.Split('.');
            //p.idtypepro = int.Parse(idtype[0]);
            //p.idimgpro = img.idimgpro;
            //p.iddespro = des.iddespro;
            //p.idUser = Content.userinformation.idUser;
            db.SaveChanges();
        }
        public void addReview(Review review,Product pro)
        {
            Review rv = new Review();
            Product pr = OneProduct(pro.idproduct);
            DateTime day = DateTime.Now;
            string h = Convert.ToString(day.Hour);
            string m = Convert.ToString(day.Minute);
            string s = Convert.ToString(day.Second);
            string time = h + ":" + m + ":" + s;

            rv.contentrev = review.contentrev;
            rv.daterev = DateTime.Now.Date;
            rv.timerev = time;
            rv.numstart = review.numstart;
            rv.idUser = Content.userinformation.idUser;
            //rv.idproduct = pr.idproduct;
            db.Reviews.Add(rv);
            db.SaveChanges();
        }
    }
}