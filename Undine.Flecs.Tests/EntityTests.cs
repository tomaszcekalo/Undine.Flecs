//using NSubstitute;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Undine.Core;
//using Undine.Flecs.Tests.Components;

//namespace Undine.Flecs.Tests
//{
//    [TestClass]
//    public class EntityTests
//    {
//        [TestInitialize]
//        public void Init()
//        {
//        }

//        [TestMethod]
//        public void ComponentCanBeAdded()
//        {
//            var container = new FlecsContainer();
//            container.Init();
//            var entity = container.CreateNewEntity();
//            entity.AddComponent(new AComponent());
//        }

//        [TestMethod]
//        public void ComponentCanBeRetrieved()
//        {
//            var container = new FlecsContainer();
//            var mock = Substitute.For<UnifiedSystem<AComponent>>();
//            container.AddSystem(mock);
//            container.Init();
//            var entity = (FlecsEntity)container.CreateNewEntity();
//            entity.AddComponent(new AComponent());
//            container.Run();
//            ref var component = ref entity.GetComponent<AComponent>();
//            Assert.IsNotNull(component);
//        }
//        [TestMethod]
//        public void ComponentCanBeRemoved()
//        {
//            var container = new FlecsContainer();
//            var mock = Substitute.For<UnifiedSystem<AComponent>>();
//            container.AddSystem(mock);
//            container.Init();
//            var entity = (FlecsEntity)container.CreateNewEntity();
//            entity.AddComponent(new AComponent());
//            container.Run();
//            ref var component = ref entity.GetComponent<AComponent>();
//            entity.RemoveComponent<AComponent>();
//        }
//    }
//}
