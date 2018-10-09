using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
 

namespace Pelijuttujentaustat
{
    public class ValidateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
           NewItem item = (NewItem)validationContext.ObjectInstance;

           if(DateTime.Compare(item.CreationDate, DateTime.Now)>0){
               return new ValidationResult(GetErrorMessage());
           } 
           return ValidationResult.Success;
        }
        private string GetErrorMessage()
        {
            return "Itemiä ei voida luoda tulevaisuudessa";
        }
    }
}