using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionManagement.DomainModel.Validator
{
     using FluentValidation;

   
    public class CategoryParentValidator : AbstractValidator<CategoryParent>
    {
        public CategoryParentValidator()
        {
            RuleFor(x => x.IdCategoryParent).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.CategoryId).NotEmpty().WithErrorCode("This field is required.");
            RuleFor(x => x.ParentId).NotEmpty().WithErrorCode("This field is required.");
        }
    }
}
