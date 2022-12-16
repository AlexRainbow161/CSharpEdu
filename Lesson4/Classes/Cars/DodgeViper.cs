using Classes.Interfaces;

namespace Classes.Cars;

public class DodgeViper : ICar {
    private decimal _currentSpeed = 0m;

    public decimal CurrentSpeed => _currentSpeed;

    public void ChangeGear() {
        _currentSpeed += 20;
    }

    public void Start() {
        Console.WriteLine("Wroooom");
    }

    public void Stop() {
        Console.WriteLine("Bzzzzzzzzz");
        _currentSpeed = 0;
    }
}
