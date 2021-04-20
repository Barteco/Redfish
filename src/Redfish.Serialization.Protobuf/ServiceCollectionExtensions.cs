﻿using Microsoft.Extensions.DependencyInjection;

namespace Redfish.Serialization.Protobuf
{
    public static class ServiceCollectionExtensions
    {
        public static IRedfishServiceCollectionBuilder AddRedisProtobufSerializer(this IRedfishServiceCollectionBuilder builder)
        {
            builder.Services.AddScoped<IRedfishSerializer, ProtobufSerializer>();

            return builder;
        }
    }
}