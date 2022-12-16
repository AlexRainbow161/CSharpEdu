namespace Classes;

public abstract class Animal {
    public Animal(string name) {
        Name = name;
    }
    public string Name { get; }
    public abstract string Family { get; }
    public abstract void MakeSound();
}