using Microsoft.AspNetCore.Mvc.Filters;

namespace BestPracticesProject.Services.Filter
{
    public class FluentValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values.SelectMany(v => v.Errors)
                                                      .Select(e => e.ErrorMessage)
                                                      .ToList();

                var resultModel = ServiceResult.Fail(errors);
                context.Result = new Microsoft.AspNetCore.Mvc.BadRequestObjectResult(resultModel);
                return;
            }

            await next();
        }
    }
}
