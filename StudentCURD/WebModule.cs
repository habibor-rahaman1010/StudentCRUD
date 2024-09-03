using Autofac;
using Core.Interface;
using Infrastructure.Services;

namespace StudentCURD
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FileService>()
                 .As<IFileService>()
                 .InstancePerLifetimeScope();
        }
    }
}
