using Autofac;
using Business.ValidationRules.FluentValidation;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Client-Side Validation
            //builder.RegisterType<ProductValidator>().As<IValidator<Product>>().SingleInstance();
        }
    }
}
