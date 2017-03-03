using System;
using Autofac;

namespace Ofl.Google.Maps.DependencyInjection.Autofac
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<IMapsClient>().As<IMapsClient>();
        }
    }
}
