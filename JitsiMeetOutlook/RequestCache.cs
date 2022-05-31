using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;


namespace JitsiMeetOutlook
{
    internal class RequestCache<TItem>
    {
        private MemoryCache _cache = new MemoryCache(new MemoryCacheOptions()
        {
            SizeLimit = 50
        });

        public async Task<TItem> GetOrCreate(object key, Func<Task<TItem>> createItem)
        {
            TItem cacheEntry;

            // Look for cache key.
            if (!_cache.TryGetValue(key, out cacheEntry))
            {
                cacheEntry = await createItem();

                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSize(1);

                _cache.Set(key, cacheEntry, cacheEntryOptions);
            }
            return cacheEntry;
        }
    }
}
