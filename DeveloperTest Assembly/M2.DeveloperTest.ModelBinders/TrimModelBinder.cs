using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace M2.DeveloperTest.ModelBinders
{
    public class TrimModelBinder : DefaultModelBinder
    {
        protected override void SetProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, object value)
        {
            // If our property type is of string than see if we can trim it.
            if (propertyDescriptor.PropertyType == typeof(string))
            {
                // Convert our value to a string and than check to see if we can trim it.
                string stringValue = (string)value;

                value = (!string.IsNullOrEmpty(stringValue) ? stringValue.Trim() : stringValue);
            }

            // Call the base class SetProperty method.
            base.SetProperty(controllerContext, bindingContext, propertyDescriptor, value);
        }
    }
}
