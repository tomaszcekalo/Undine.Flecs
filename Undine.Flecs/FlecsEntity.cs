using Flecs.NET.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Flecs
{
    public class FlecsEntity : IUnifiedEntity
    {
        public Entity Entity { get; internal set; }

        public void AddComponent<A>(in A component) where A : struct
        {
            this.Entity.Set<A>(component);
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref this.Entity.GetMut<A>();
        }

        public void RemoveComponent<A>() where A : struct
        {
            this.Entity.Remove<A>();
        }

        public bool HasComponent<A>() where A : struct
        {
            return this.Entity.Has<A>();
        }
    }
}
