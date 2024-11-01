﻿using Business_Layer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.View_Components.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
