using Abp.Runtime.Session;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qgb48.Tests.Dto.TestDto
{
    public class TestDto: ICustomValidate
{
    public int? AssignedPersonId { get; set; }

    
    [Required]
    public string Description { get; set; }

    public void AddValidationErrors(CustomValidationContext context)
    {
        var session=  context.IocResolver.Resolve<IAbpSession>();
        if ( (!AssignedPersonId.HasValue || AssignedPersonId.Value <= 0))
        {
            context.Results.Add(new ValidationResult("AssignedPersonId must be set if SendEmailToAssignedPerson is true!"));
        }
    }
}
    
}
