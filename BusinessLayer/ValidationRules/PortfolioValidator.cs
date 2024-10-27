using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Project Name Should Not Be Empty!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image Url Should Not Be Empty!");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Image Url2 Should Not Be Empty!");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Project Url Should Not Be Empty!");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Project Name Should Have At Least 5 Character!");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Project Name Should Have At Most 100 Character!");
        }
    }
}
