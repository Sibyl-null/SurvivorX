using NUnit.Framework;
using VContainer;
using VContainer.Unity;

namespace Tests
{
    public abstract class VContainerTestFixture
    {
        private ContainerBuilder _builder;
        
        [SetUp]
        public void SetUp()
        {
            _builder = new ContainerBuilder();
        }

        protected RegistrationBuilder RegisterComponent<TInterface>(TInterface component)
        {
            return _builder.RegisterComponent(component);
        }

        protected RegistrationBuilder RegisterInstance<TInterface>(TInterface instance)
        {
            return _builder.RegisterInstance(instance);
        }

        protected RegistrationBuilder Register<T>(Lifetime lifetime = Lifetime.Singleton)
        {
            return _builder.Register<T>(lifetime);
        }

        protected T Resolve<T>()
        {
            IObjectResolver resolver = _builder.Build();
            return resolver.Resolve<T>();
        }

        protected T RegisterAndResolve<T>(Lifetime lifetime = Lifetime.Singleton)
        {
            _builder.Register<T>(lifetime);
            return Resolve<T>();
        }
    }
}