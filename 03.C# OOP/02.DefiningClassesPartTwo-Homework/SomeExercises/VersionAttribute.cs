namespace SomeExercises
{
    using System;

    [AttributeUsage(AttributeTargets.Class |
     AttributeTargets.Struct |
     AttributeTargets.Enum |
     AttributeTargets.Method)]

    public class VersionAttribute : Attribute
    {
        private static double Version;

        public VersionAttribute(double version)
        {
            Version = version;
        }

        public double GetVersion()
        {
            return Version;
        }
    }
}