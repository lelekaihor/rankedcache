﻿namespace IL.RankedCache.CacheProvider
{
    public interface ICacheProvider
    {
        Task Add<T>(string key, T? obj, DateTimeOffset? absoluteExpiration = null);

        Task<T> Get<T>(string key);

        Task Delete(string key);

        bool HasKey(string key);
    }
}