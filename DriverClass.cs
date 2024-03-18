namespace lab1ef
{
    internal class DriverClass
    {
        public int DriverID {  get; private set; }
        public string DriverFirstname { get; private set; }
        public string DriverSurname { get; private set; }
        public string DriverMiddlename { get; private set; }
        public int CarID { get; private set; }
        public string CarModel { get; private set; }
        public string CarNumber { get; private set; }
        public string CarColor { get; private set; }
        public DriverClass(drivers driver) 
        {
            DriverID = driver.id_driver;
            DriverFirstname = driver.firstname;
            DriverSurname = driver.surname;
            DriverMiddlename = driver.middlename;

            if (driver.cars != null)
            {
                CarID = driver.cars.id_car;
                CarModel = driver.cars.model;
                CarNumber = driver.cars.number;
                CarColor = driver.cars.color;
            }
        }
    }
}
