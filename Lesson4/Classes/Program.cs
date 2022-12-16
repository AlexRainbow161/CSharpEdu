using Classes.Cars;
using Classes.Interfaces;

namespace Classes;

public class Program {
    public static void Main(string[] args) {
        List<ICar> cars = new List<ICar>();

        cars.Add(new DodgeViper());
        cars.Add(new ShelbyS500());

        foreach (var car in cars) {
            car.Start();
        }

        foreach (var car in cars) {
            for (int i = 0; i < 5; i++) {
                car.ChangeGear();
            }
        }

        foreach (var car in cars) {
            Console.WriteLine(car.CurrentSpeed);
        }

        foreach (var car in cars) {
            car.Stop();
        }
    }
}




