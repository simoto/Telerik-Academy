namespace SomeExercises
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> PathSequence = new List<Point3D>();       

        public Path()
        {
        }

        public void AddNewPath(Point3D asd)
        {            
           this.PathSequence.Add(asd);        
        }

        public void RemovePath(int index)
        {
            PathSequence.RemoveAt(index);
        }

        public List<Point3D> Sequences
        {          
            get
            {
                return this.PathSequence;
            }
        }
    }
}