//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ParticleSystem
//{
//    public class DyingParticle : Particle
//    {
//        int lifetime = 0;

//        public DyingParticle(MatrixCoords position, MatrixCoords speed, int lifetime)
//            : base(position,speed)
//        {
//            if (lifetime < 0)
//            {
//                throw new ArgumentException("Lifetime must be grater than or equal to zero");
//            }
//            this.lifetime = lifetime;
//        }

//        public override bool Exists
//        {
//            get
//            {
//                return this.lifetime > 0;
//            }
//        }

//        public override IEnumerable<Particle> Update()
//        {
//            this.lifetime--;
            
//            return base.Update();
//        }

//    }
//}