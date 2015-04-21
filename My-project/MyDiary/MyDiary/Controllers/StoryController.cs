using MyDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.SqlClient;
using System.Web.Helpers;

namespace MyDiary.Controllers
{
    public class StoryController : Controller
    {

        StoryContext storyContext = new StoryContext();


        public ActionResult Index(string searchString)
        {
            var story = from m in storyContext.Stories
                        select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                story = story.Where(s => s.Name.Contains(searchString) || s.Text.Contains(searchString));
            }
            var orderedStorie = story.OrderBy(m => m.DateOfCreate);

            return View(orderedStorie.ToList());
        }
      

        public ActionResult Details(int id)
        {
            Story stories = storyContext.Stories.Find(id);

            return View(stories);
        }


         public ActionResult New()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New([Bind(Include = "Name, DateOfCreate, Rate, Text")] Story story, HttpPostedFileBase Picture)
        {
            MemoryStream target = new MemoryStream();
            Picture.InputStream.CopyTo(target);
            story.Picture = target.ToArray();

            if (ModelState.IsValid)
            {
                storyContext.Stories.Add(story);
                storyContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(story);
        }


        public ActionResult Delete(int? id)
        {
            Story story = storyContext.Stories.Find(id);
            if (story == null)
            {
                return HttpNotFound();
            }
            return View(story);
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            Story story = storyContext.Stories.Find(id);
            storyContext.Stories.Remove(story);
            storyContext.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult RenderPhoto(int imageId)
        {
            Story story = storyContext.Stories.Find(imageId);

            return File(story.Picture ?? new byte[] { }, "image/jpeg");
        }
    }
}
