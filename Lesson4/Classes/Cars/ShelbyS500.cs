using Classes.Interfaces;

namespace Classes.Cars;

public class ShelbyS500 : ICar {
    private decimal _currentSpeed = 0m;

    public decimal CurrentSpeed => _currentSpeed;

    public void ChangeGear() {
        _currentSpeed += 20.5m;
    }

    public void Start() {
        Console.WriteLine("Wroooomzzz");
    }

    public void Stop() {
        Console.WriteLine("BzzzzzzzzzRrrrra");
        _currentSpeed = 0;
    }
}
