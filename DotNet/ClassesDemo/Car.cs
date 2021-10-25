using System;

namespace ClassesDemo
{
    class Car
    {
        // this class "has" the following properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int TopSpeed { get; set; }
        public int CurrentSpeed { get; set; }
        public bool EngineRunning { get; set; }

        // this class "can do" the following methods
        public void StartEngine()
        {
            EngineRunning = true;
        }

        public void StopEngine()
        {
            EngineRunning = false;
        }

        public void Accelerate()
        {
            CurrentSpeed += 10;
        }

        public void Brake()
        {
            CurrentSpeed -= 10;
        }
    }
}
