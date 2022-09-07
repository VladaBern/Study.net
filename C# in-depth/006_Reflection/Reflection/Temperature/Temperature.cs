namespace Temperature
{
    public class Temperature
    {
        private double temperature;

        public Temperature(double temperature)
        {
            this.temperature = temperature;
        }

        public double ConvertToFahrenheit()
        {
            return (temperature * 9 / 5) + 32;
        }

        public double ConvertToCelsius()
        {
            return (temperature - 32) * 5 / 9;
        }
    }
}
