using AbstractFactoryDesingPattern;

Console.WriteLine("Abstract Factory Desing Pattern");

VehicleCompany tatacommpany = new TataCompany();

IBike tataBike = tatacommpany.GetBike();
tataBike.GetBike();

ICar tataCar = tatacommpany.GetCar();
tataCar.GetCar();

VehicleCompany toyotacommpany = new ToyotaCompany();

IBike toyotaBike = toyotacommpany.GetBike();
toyotaBike.GetBike();

ICar toyotaCar = toyotacommpany.GetCar();
toyotaCar.GetCar();





