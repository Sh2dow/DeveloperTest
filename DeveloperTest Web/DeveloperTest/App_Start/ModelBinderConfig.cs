using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeveloperTest
{
    public class ModelBinderConfig
    {
        public static void RegisterModeBinders()
        {
            // Register our trim model binder to make sure all strings are trimmed.
            ModelBinders.Binders.DefaultBinder = new M2.DeveloperTest.ModelBinders.TrimModelBinder();
        }
    }
}