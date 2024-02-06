using Flecs.NET.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Flecs
{
    public class FlecsContainer : EcsContainer
    {
        public FlecsContainer()
        {
            FlecsEcsWorld = World.Create();
            Systems = new List<ISystem>();
        }

        public World FlecsEcsWorld { get; }
        public List<ISystem> Systems { get; set; } 

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            Systems.Add(new FlecsSystem<A> { System = system, FlecsEcsWorld = FlecsEcsWorld });
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            Systems.Add(new FlecsSystem<A, B> { System = system, FlecsEcsWorld = FlecsEcsWorld });
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            Systems.Add(new FlecsSystem<A, B, C> { System = system, FlecsEcsWorld = FlecsEcsWorld });
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            Systems.Add(new FlecsSystem<A, B, C, D> { System = system, FlecsEcsWorld = FlecsEcsWorld });
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new FlecsEntity()
            {
                Entity = FlecsEcsWorld.Entity()
            };
        }

        public override void DeleteEntity(IUnifiedEntity entity)
        {
            var entityToDelete= entity as FlecsEntity;

            if(entityToDelete is not null)
            {
                FlecsEcsWorld.DeleteWith(entityToDelete.Entity.Id);
            }
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            return new FlecsSystem<A> { System = system, FlecsEcsWorld = FlecsEcsWorld };
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            return new FlecsSystem<A, B> { System = system, FlecsEcsWorld = FlecsEcsWorld };
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            return new FlecsSystem<A, B, C> { System = system, FlecsEcsWorld = FlecsEcsWorld };
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            return new FlecsSystem<A, B, C, D> { System = system, FlecsEcsWorld = FlecsEcsWorld };
        }

        public override void Run()
        {
            foreach(var system in Systems)
            {
                system.ProcessAll();
            }
        }
    }
}