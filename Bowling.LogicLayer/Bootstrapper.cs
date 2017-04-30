using SimpleInjector;

namespace Bowling.LogicLayer
{
    public static class Bootstrapper
    {
        public static void Setup(Container container)
        {
            Bootstrapper.IocSetup(container);
        }

        private static void IocSetup(Container container)
        {
            container.Register<BowlingGame, BowlingGame>();
        }
    }
}
