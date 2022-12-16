namespace Classes.Interfaces;

public interface ICar {
    void Start();
    void Stop();
    void ChangeGear();
    decimal CurrentSpeed { get; }
}
