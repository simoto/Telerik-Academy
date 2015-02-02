//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ParticleSystem
//{
//    public class VariousLifetimeParticleEmmiter : ParticleEmitter
//    {
//        const int MaxParticleLifetime = 7;

//        public VariousLifetimeParticleEmmiter(MatrixCoords position,MatrixCoords speed, Random generator)
//            : base(position,speed,generator)
//        {

//        }

//        protected override Particle GetNewParticle(MatrixCoords position, MatrixCoords speed)
//        {
//            bool createDying = this.randomGenerator.Next(0, MaxParticleLifetime) % 2 == 0;

//            if (createDying)
//            {
//                return new DyingParticle(position, speed,this.randomGenerator.Next());
//            }

//            return base.GetNewParticle(position, speed);
//        }
//    }
//}
