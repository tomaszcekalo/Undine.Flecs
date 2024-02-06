using Flecs.NET.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Flecs
{
    public class FlecsSystem<A> : ISystem
        where A : struct
    {
        public World FlecsEcsWorld { get; set; }
        public UnifiedSystem<A> System { get; set; }

        public void ProcessAll()
        {
            FlecsEcsWorld.Each<A>((ref A aComponent) =>
            {
                System.ProcessSingleEntity(0, ref aComponent);
            });
        }
    }
    public class FlecsSystem<A, B> : ISystem
        where A : struct
        where B : struct
    {
        public World FlecsEcsWorld { get; set; }
        public UnifiedSystem<A, B> System { get; set; }

        public void ProcessAll()
        {
            FlecsEcsWorld.Each<A, B>((ref A aComponent, ref B bComponent) =>
            {
                System.ProcessSingleEntity(0, ref aComponent, ref bComponent);
            });
        }
    }
    public class FlecsSystem<A, B, C> : ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public World FlecsEcsWorld { get; set; }
        public UnifiedSystem<A, B, C> System { get; set; }

        public void ProcessAll()
        {
            FlecsEcsWorld.Each<A, B, C>((ref A aComponent, ref B bComponent, ref C cComponent) =>
            {
                System.ProcessSingleEntity(0, ref aComponent, ref bComponent, ref cComponent);
            });
        }
    }
    public class FlecsSystem<A, B, C, D> : ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public World FlecsEcsWorld { get; set; }
        public UnifiedSystem<A, B, C, D> System { get; set; }

        public void ProcessAll()
        {
            FlecsEcsWorld.Each<A, B, C, D>((ref A aComponent, ref B bComponent, ref C cComponent, ref D dComponent) =>
            {
                System.ProcessSingleEntity(0, ref aComponent, ref bComponent, ref cComponent, ref dComponent);
            });
        }
    }
}
