namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

   public class ChickenParticle : Particle
    {
        Random randomSpeed;
        const int MaxSpeedPerCoordinate = 2;

        public ChickenParticle(MatrixCoords position, MatrixCoords speed,Random randomSpeed)
            : base(position,speed)
        {
            this.randomSpeed = randomSpeed;
        }

        protected override void Move()
        {
            this.Speed = CreatedRandomCoords();
            this.Speed = CreatedRandomCoords();
            if (this.randomSpeed.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate) == 0)
            {
                while (this.randomSpeed.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate) != 0)
               {               
               }
            }
            else
            {
                this.Position += this.Speed;
            }
        }

        public override char[,] GetImage()
        {
            return new char[,] {{'#'}};
        }

        public override IEnumerable<Particle> Update()
        {
            IEnumerable<Particle> objectSpFar = base.Update();
            List<Particle> allObjects = new List<Particle>();
          
            if (this.randomSpeed.Next(-MaxSpeedPerCoordinate,MaxSpeedPerCoordinate) == 0)
            {               
                allObjects.Add(new ChickenParticle(this.Position, this.Speed,new Random()));
            }

            return allObjects;
        }

        private MatrixCoords CreatedRandomCoords()
        {
            var createdSpeed = new MatrixCoords(this.randomSpeed.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1),
                this.randomSpeed.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1));
            return createdSpeed;
        }

        protected virtual void GetRandomParticle(List<Particle> allObjects)
        {
            var createdSpeed = CreatedRandomCoords();

            while (createdSpeed.Row == 0 && createdSpeed.Col == 0)
            {
                createdSpeed = CreatedRandomCoords();
            }

            allObjects.Add(new Particle(this.Position, createdSpeed));
        }
    }
}