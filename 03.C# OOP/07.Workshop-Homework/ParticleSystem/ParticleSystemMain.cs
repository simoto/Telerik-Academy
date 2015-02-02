namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

    class ParticleSystemMain
    {
        const int SimulationRows = 30;
        const int SimulationCols = 30;

        static void Main()
        {
            var renderer = new ConsoleRenderer(SimulationRows, SimulationCols);
            var particleOperator = new ParticleUpdater();
            
            var particles = new List<Particle>()
            {
                new ChaoticParticle(new MatrixCoords(10,10), new MatrixCoords(1, 1),new Random()),
                new ChickenParticle(new MatrixCoords(15,15), new MatrixCoords(1, 1),new Random())
                //new ParticleEmitter(new MatrixCoords(5, 10),new MatrixCoords(0,0), new Random()),
               // new VariousLifetimeParticleEmmiter(new MatrixCoords(10, 20),new MatrixCoords(0,0), new Random())
            };

            var engine = new Engine(renderer, particleOperator, particles);

            engine.Run();
        }
    }
}