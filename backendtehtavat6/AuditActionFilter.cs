using System;
using Microsoft.AspNetCore.Mvc.Filters;
 
namespace Pelijuttujentaustat
{
    public class AuditActionFilter : ActionFilterAttribute
    {
        private readonly IRepository _repository;
 
        public AuditActionFilter(IRepository repository)
        {
            _repository = repository;
        }
 
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _repository.AuditDeleteStart();
        }
 
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _repository.AuditDeleteSuccess();
        }
    }
}