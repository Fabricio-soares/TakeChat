using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using TakeChat.Domain.Adapters;
using TakeChat.Domain.Exceptions;
using TakeChat.Domain.Models;
using TakeChat.TmdbAdapter.Clients;
using Otc.Caching.Abstractions;
using Refit;

namespace TakeChat.TmdbAdapter
{
    internal class TmdbAdapter : ITmdbAdapter
    {
        private readonly ITmdbApi tmdbApi;
        private readonly TmdbAdapterConfiguration tmdbAdapterConfiguration;
        private readonly ITypedCache typedCache;
        private readonly IMapper mapper;

        public TmdbAdapter(ITmdbApi tmdbApi,
            TmdbAdapterConfiguration tmdbAdapterConfiguration,
            ITypedCache typedCache,
            IMapper mapper)
        {
            this.tmdbApi = tmdbApi ??
                throw new ArgumentNullException(nameof(tmdbApi));

            this.tmdbAdapterConfiguration = tmdbAdapterConfiguration ??
                throw new ArgumentNullException(nameof(tmdbAdapterConfiguration));

            this.typedCache = typedCache ??
                throw new ArgumentNullException(nameof(typedCache));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


    }

}
