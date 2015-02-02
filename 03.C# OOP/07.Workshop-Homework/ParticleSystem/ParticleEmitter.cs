//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ParticleSystem
//{
//    public class ParticleEmitter : Particle
//    {
//        const int MaxElementsPerUpdateCount = 5;
//        const int MaxSpeedPerCoordinate = 2;

//        protected Random randomGenerator;

//        public override char[,] GetImage()
//        {
//            return new char[,] {{(char)1}};
//        }
//        public ParticleEmitter( MatrixCoords position, MatrixCoords speed, Random randGenerator)
//            : base (position, speed)
//        {
//            this.randomGenerator = randGenerator;
//        }
//        public override IEnumerable<Particle> Update()
//        {
//            IEnumerable<Particle> objectSpFar = base.Update();
//            List<Particle> allObjects = new List<Particle>();

//            int objectsToCreate = this.randomGenerator.Next(MaxElementsPerUpdateCount + 1);

//            for (int i = 0; i < objectsToCreate; i++)
//            {
//                GetRandomParticle(allObjects);
//            }

//            allObjects.Add(this.GetNewParticle(Position, Speed));

//            return allObjects;
//        }

//        protected virtual  Particle GetNewParticle(MatrixCoords position, MatrixCoords speed)
//        {
//            return new Particle(position, speed);
//        }

//        protected virtual void GetRandomParticle(List<Particle> allObjects)
//        {
//            var createdSpeed = CreatedRandomCoords();

//            while (createdSpeed.Row == 0 && createdSpeed.Col == 0)
//            {
//                createdSpeed = CreatedRandomCoords();
//            }

//            allObjects.Add(new Particle(this.Position, createdSpeed));
//        }

//        private MatrixCoords CreatedRandomCoords()
//        {
//            var createdSpeed = new MatrixCoords(this.randomGenerator.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1),
//                this.randomGenerator.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1));
//            return createdSpeed;
//        }
//    }
//}
