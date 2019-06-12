using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.CrossCuttingConcerns.Validation.Fluent;
using FluentValidation;
using PostSharp.Aspects;

namespace DevFramework.Core.Aspects.Postsharp.ValidationAspects
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            //Get first Generic Class
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entites = args.Arguments.Where(x => x.GetType() == entityType);

            foreach (var entity in entites)
            {
                ValidatorTool.FluentValidate(validator, entity);
            }
        }
    }
}
