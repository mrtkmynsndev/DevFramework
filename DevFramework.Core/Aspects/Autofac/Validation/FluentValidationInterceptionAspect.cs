using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using DevFramework.Core.CrossCuttingConcerns.Validation.Fluent;
using DevFramework.Core.Utilities.Intercepters;
using FluentValidation;

namespace DevFramework.Core.Aspects.Autofac.Validation
{
    public class FluentValidationInterceptionAspect : MethodInterception
    {
        private readonly Type _validatorType;
        public FluentValidationInterceptionAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            if (!typeof(IValidator).IsAssignableFrom(_validatorType))
                throw new Exception("Invalid Validator Type");

            var validator = (IValidator)Activator.CreateInstance(_validatorType);

            if (_validatorType.BaseType != null)
            {
                var entityType = _validatorType.BaseType.GetGenericArguments()[0];
                var entities = invocation.Arguments.Where(x => x.GetType() == entityType).ToList();
                foreach (var entity in entities)
                {
                    ValidatorTool.FluentValidate(validator, entity);
                }
            }
        }
    }
}
