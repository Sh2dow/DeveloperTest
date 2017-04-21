using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeveloperTest.Models.Participant
{
    public class Add
    {
        [Required(ErrorMessage = M2.DeveloperTest.Constants.Constant.RequiredErrorMessage)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = M2.DeveloperTest.Constants.Constant.RequiredErrorMessage)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = M2.DeveloperTest.Constants.Constant.RequiredErrorMessage)]
        [Display(Name = "Gender")]
        public M2.DeveloperTest.Enumerators.Gender? Gender { get; set; }
        
        [Required(ErrorMessage = M2.DeveloperTest.Constants.Constant.RequiredErrorMessage)]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        
        [Required(ErrorMessage = M2.DeveloperTest.Constants.Constant.RequiredErrorMessage)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = M2.DeveloperTest.Constants.Constant.RequiredErrorMessage)]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = M2.DeveloperTest.Constants.Constant.RequiredErrorMessage)]
        [RegularExpression(M2.DeveloperTest.Constants.Constant.ZipRegularExpression, ErrorMessage = M2.DeveloperTest.Constants.Constant.InvalidFormatErrorMessage)]
        [Display(Name = "Zip")]
        public string Zip { get; set; }

        public SelectList StateList { get; set; }
    }
}