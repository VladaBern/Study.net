using System;

namespace HomeTask2
{
    public class Car
    {
        [Obsolete("Don't use Accelerate method", true)]
        public void Accelerate() { }

        [Obsolete("Avoid using the EngineStop method")]
        public void EngineStop() { }

        public void EngineStart() { }
    }
}
