namespace TestEdu;
// пример программы с использованием принципа ООП - Абстракция
// Абстракция позволяет сфокусируется на том, что объект делает, а не как от это делает

interface IVehicle {
    void Drive();
}

class Car : IVehicle {
    public void Drive() {
        Console.WriteLine("Driving a car.");
    }
}

class Bicycle : IVehicle {
    public void Drive() {
        Console.WriteLine("Driving a bicycle.");
    }
}

class TransportService {
    public void StartTrip(IVehicle vehicle) {
        vehicle.Drive();
    }
}