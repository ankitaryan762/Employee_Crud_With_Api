using QuantityMeasurment_Repository;

namespace QuantityMeasurement_Manager
{
    public class Manager :IManager
    {
        private IRepository repo;

        public Manager(IRepository repo)
        {
            this.repo = repo;
        }

        public decimal CentimetertoMeter(Model value)
        {
            return this.repo.CentimetertoMeter(value);
        }

        public decimal FeettoInch(Conversion value)
        {
            return this.repo.FeettoInch(value);
        }

        public decimal GmtoKg(Conversion value)
        {
            return this.repo.FeettoInch(value);
        }

        public decimal InchToFeet(Conversion value)
        {
            return this.repo.InchToFeet(value);
        }

        public decimal KgtoGm(Conversion value)
        {
            return this.repo.KgtoGm(value);
        }

        public decimal MetertoCentimeter(Conversion value)
        {
            return this.repo.MetertoCentimeter(value);
        }

    }
}
