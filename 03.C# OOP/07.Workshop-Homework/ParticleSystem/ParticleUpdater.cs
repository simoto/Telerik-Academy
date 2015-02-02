﻿namespace ParticleSystem
{
    using System.Collections.Generic;

    public class ParticleUpdater : IParticleOperator
    {
        public virtual IEnumerable<Particle> OperateOn(Particle p)
        {
            return p.Update();
        }

        public virtual void TickEnded()
        {           
        }
    }
}