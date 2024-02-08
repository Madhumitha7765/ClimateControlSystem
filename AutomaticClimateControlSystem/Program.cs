using PeopleCounterLib;
using System;
using TemperatureRegulatorLib;


namespace AutoCimateControlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize dependencies
            IOutsideTempSensor outsideTempSensor = new OutsideTempSensor();
            IPeopleCountSensor peopleCountSensor = new PeopleCountSensor();
            ITempCalculator tempCalculator = new TempCalculator();
            ITempRegulator tempRegulator = new TempRegulator();

            // Create ECU instance
            ECU ecu = new ECU(outsideTempSensor, peopleCountSensor, tempCalculator, tempRegulator);

            // Run temperature control
            Console.WriteLine("Auto Climate Control System is running. Press Ctrl+C to exit.");
            ecu.RunTemperatureControl();
        }
    }
}
