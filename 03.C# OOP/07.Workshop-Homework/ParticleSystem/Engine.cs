namespace ParticleSystem
{
    using System.Collections.Generic;
    using System.Threading;

    public class Engine
    {
        private IParticleOperator particleOperator;
        private List<Particle> particles;
        private IRenderer renderer;
        private int waitMilliseconds;

        public Engine(IRenderer renderer, IParticleOperator particleOperator, List<Particle> particles = null, int waitMlls = 300)
        {
            this.renderer = renderer;
            this.particleOperator = particleOperator;
            this.waitMilliseconds = waitMlls;
            if (particles != null)
            {
                this.particles = particles;
            }
            else
            {
                this.particles = new List<Particle>();
            }
        }

        public void AddParticle(Particle p)
        {
            this.particles.Add(p);
        }
        
        public void Run()
        {
            while (true)
            {
                renderer.RenderAll();
                renderer.ClearQueue();

                List<Particle> producedObjects = new List<Particle>();

                foreach (var particle in particles)
                {
                    producedObjects.AddRange(particleOperator.OperateOn(particle));                   
                }

                foreach (var particle in this.particles)
                {
                    renderer.EnqueueForRendering(particle);
                }

                this.particles.RemoveAll((p) => !p.Exists);
                this.particles.AddRange(producedObjects);

                particleOperator.TickEnded();

                Thread.Sleep(this.waitMilliseconds);
            }
        }
    }
}