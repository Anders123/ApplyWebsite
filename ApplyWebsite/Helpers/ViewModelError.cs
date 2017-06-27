using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ApplyWebsite.Helpers
{
    public class ViewModelError
    {

        public static void AddViewModelError(ModelStateDictionary modelState, string validationMessageName, string message)
        {
            modelState.AddModelError(validationMessageName, message);
        }

        public static void AddViewModelError(ModelStateDictionary modelState, string validationMessageName, Exception ex)
        {
            //if (ex is DbEntityValidationException)
            //{
            //    var exception = ex as DbEntityValidationException;
            //    var dbEntityValidationResult = exception.EntityValidationErrors.FirstOrDefault();
            //    var dbValidationError = dbEntityValidationResult?.ValidationErrors.FirstOrDefault();
            //    if (dbValidationError != null)
            //    {
            //        var innerException = "";
            //        if (exception.InnerException?.InnerException != null)
            //        {
            //            innerException = ex.InnerException.InnerException.Message;
            //        }
            //        modelState.AddModelError(validationMessageName, $"{exception.Message}, {innerException}");
            //    }
            //}
            //else
            //{
            var innerException = "";
            if (ex.InnerException?.InnerException != null)
            {
                innerException = ex.InnerException.InnerException.Message;
            }
            modelState.AddModelError(validationMessageName, $"{ex.Message}, {innerException}");
            //}
        }

    }
}
