namespace EatonProject
{
    internal class Monitor
    {
        public string Name { get; }
        public List<int> Measurements { get; }

        public Monitor(string name)
        {
            Name = name;
            Measurements = new List<int>();
        }

        // Encapsulating the measurements adding functionality
        public void AddMeasurement(int measurement)
        {
            Measurements.Add(measurement);
        }
    }

    public static class Program
    {
        // Refactored from Main() a private method for returning the number of measurements
        private static int CalculateTotalMeasurements(IEnumerable<Monitor> monitors)
        {
            // linQ expression for calculating them instead of looping
            return monitors.Sum(monitor => monitor.Measurements.Count);
        }

        public static void Main(string[] args)
        {
            Console.Write("How many monitor devices do you have? ");

            if (int.TryParse(Console.ReadLine(), out var numberOfMonitors)) //valid number checker
            {
                var monitorsArray = new Monitor[numberOfMonitors]; // Each element in the array is a monitor device

                // Fulfill each element with the monitor device
                for (var i = 0; i < numberOfMonitors; i++)
                {
                    monitorsArray[i] = new Monitor("MonitorDevice" + (i + 1));
                }

                // Iterate over each monitor and get it's measurements from user
                foreach (var monitor in monitorsArray)
                {
                    // Prompt for measurements of each monitor with conditional space split between each measurement
                    Console.WriteLine("Enter " + monitor.Name + "'s measurements");
                    var measurements = Console.ReadLine()?.Split(' ');

                    if (measurements == null) continue;
                    foreach (var measurement in measurements)
                    {
                        // Fulfilling the original measurement property of devices with each parsed measurement
                        if (int.TryParse(measurement, out var parsedMeasurement))
                        {
                            monitor.AddMeasurement(parsedMeasurement);
                        }
                        else // Throw an error for uncooperative user's input
                        {
                            Console.WriteLine("Incorrect measurement: " + measurement);
                        }
                    }
                }

                // Printing out the number of messages read from the monitor
                var measurementsCount = CalculateTotalMeasurements(monitorsArray);

                // Output required in a user-friendly message
                Console.WriteLine("Number of correct messages read from all monitor devices: " + measurementsCount);
            }
            // A user-friendly error if the user didn't co-operate
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }

            Console.ReadKey();
        }
    }
}
