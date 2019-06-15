using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace DevFramework.Core.Utilities.Intercepters
{
    public class AspectIntercepterSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();
            var methodAttributes =
                (type.GetMethod(method.Name) ?? throw new InvalidOperationException())
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);

            classAttributes.AddRange(methodAttributes);

            // ReSharper disable once CoVariantArrayConversion
            return classAttributes.ToArray();

        }
    }
}
