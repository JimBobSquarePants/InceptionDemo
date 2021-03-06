﻿using InceptionDemo.Models.RenderModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace InceptionDemo.Controllers
{
    //Umbraco route hijacking: http://our.umbraco.org/documentation/Reference/Mvc/custom-controllers
    public class PersonController:InceptionControllerBase
    {
        public override ActionResult Index(RenderModel model)
        {
            base.HandleLanguage();
            return View(new PersonRenderModel(model.Content, _language));
        }
    }
}