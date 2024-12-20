﻿using Logistics.Models;
using Logistics.Utility;
using LogisticsWeb.DataAccess.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class PostController : Controller
    {
        private ApplicationDbContext _context;

        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Post> objPostList = _context.Posts.ToList();
            return View(objPostList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post obj)
        {
            if (ModelState.IsValid)
            {
                _context.Posts.Add(obj);
                _context.SaveChanges();
                TempData["success"] = "Categort is created succesfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Post? postFromDB = _context.Posts.Find(id);
            if (postFromDB == null)
            {
                return NotFound();
            }
            return View(postFromDB);
        }

        [HttpPost]
        public IActionResult Edit(Post obj)
        {
            if (ModelState.IsValid)
            {
                _context.Posts.Update(obj);
                _context.SaveChanges();
                TempData["success"] = "Categort is updated succesfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Post? postFromDB = _context.Posts.Find(id);
            if (postFromDB == null)
            {
                return NotFound();
            }
            return View(postFromDB);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Post? post = _context.Posts.Find(id);
            if (post == null)
            {
                return NotFound();
            }
            _context.Posts.Remove(post);
            _context.SaveChanges();
            TempData["success"] = "Categort is deleted succesfully";
            return RedirectToAction("Index");
        }
    }
}
