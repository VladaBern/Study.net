using System;

namespace HomeTask1
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class AccessLevelAttribute : Attribute
    {
        public Access Access { get; }

        public AccessLevelAttribute(Access access)
        {
            Access = access;
        }
    }
}
