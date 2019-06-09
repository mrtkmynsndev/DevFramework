using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using PostSharp.Aspects;
using DevFramework.Core.CrossCuttingConcerns.Caching;


namespace DevFramework.Core.Aspects.Postsharp.CacheAspects
{
    [Serializable]
    public class CacheRemoveAsepect : OnMethodBoundaryAspect
    {
        string _pattern;
        Type _cacheType;
        ICacheManager _cacheManager;

        public CacheRemoveAsepect()
        {

        }

        public CacheRemoveAsepect(Type cacheType, string pattern)
        {
            _cacheType = cacheType;
            _pattern = pattern;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("Wrong Cache Manager");
            }

            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);

            base.RuntimeInitialize(method);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            var key = string.IsNullOrEmpty(_pattern) ? $"{args.Method.ReflectedType.Namespace}.{args.Method.ReflectedType.Name}.*"
                : _pattern;

            _cacheManager.RemoveByPattern(key);
        }
    }
}
