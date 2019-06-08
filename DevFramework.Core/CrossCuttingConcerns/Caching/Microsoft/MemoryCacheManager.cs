using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevFramework.Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        protected ObjectCache Cache
        {
            get
            {
                return MemoryCache.Default;
            }
        }
        public void Add(string key, object data, int cacheTime = 60)
        {
            if (data == null) return;

            var policy = new CacheItemPolicy()
            {
                AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime),
            };

            Cache.Add(key, data, policy);
        }

        public void Clear()
        {
            foreach (var cacheItem in Cache)
            {
                this.Remove(cacheItem.Key);
            }
        }

        public T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        public bool IsAdd(string key)
        {
            return Cache.Contains(key);
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            var regEx = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRemove = Cache.Where(d => regEx.IsMatch(d.Key)).Select(d => d.Key).ToList();
            foreach (var key in keysToRemove)
            {
                this.Remove(key);
            }
        }
    }
}
