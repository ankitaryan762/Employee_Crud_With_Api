using QuantityMeasurement_Model;
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

        public decimal FeettoInch(Model value)
        {
            return this.repo.FeettoInch(value);
        }

        public decimal GmtoKg(Model value)
        {
            return this.repo.FeettoInch(value);
        }

        public decimal InchToFeet(Model value)
        {
            return this.repo.InchToFeet(value);
        }

        public decimal KgtoGm(Model value)
        {
            return this.repo.KgtoGm(value);
        }

        public decimal MetertoCentimeter(Model value)
        {
            return this.repo.MetertoCentimeter(value);
        }

    }
}
