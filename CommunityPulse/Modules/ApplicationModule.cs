using Autofac;

namespace CommunityPulse.Modules
{
    public class ApplicationModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            /*builder.Register(c => new ProfileRepository(_connectionString))
                .As<IProfileRepository>()
                .InstancePerLifetimeScope();*/
        }
    }
}
