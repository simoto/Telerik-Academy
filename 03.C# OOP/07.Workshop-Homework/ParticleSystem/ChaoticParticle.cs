namespace ParticleSystem
{
    using System;

    public class ChaoticParticle : Particle
    {        
        const int MaxSpeedPerCoordinate = 2;
        Random randomSpeed;

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random randomSpeed)
            : base(position,speed)
        {
            this.randomSpeed = randomSpeed;          
        }

        public override char[,] GetImage()
        {
            return new char[,] {{'$'}};
        }

        protected override void Move()
        {
            this.Speed = CreatedRandomCoords();
            this.Position += this.Speed;
        }

        private MatrixCoords CreatedRandomCoords()
        {
            var createdSpeed = new MatrixCoords(this.randomSpeed.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1),
                this.randomSpeed.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1));
            return createdSpeed;
        }
    }
}