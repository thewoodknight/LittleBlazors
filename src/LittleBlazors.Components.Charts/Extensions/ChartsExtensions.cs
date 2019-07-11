﻿using LittleBlazors.Components.Charts;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ChartsExtensions
    {
        public static IServiceCollection AddCharts(this IServiceCollection services)
        {
            services.AddTransient<GoogleChartsInterop>();
            return services;
        }
    }
}
