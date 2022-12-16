namespace Classes;

public class Counter {
    protected static int _count = 0;
    public int Count => _count;

    public void DoCount() {
        _count += 1;
    }

    public static void Decrement() {
        _count--;
    }
}

public class B : Counter {
    public void DoSomething() {
        var c = _count;
    }
}

public class C {
    public void Do() {
        var b = new B();
    }
}

public static class CounterStatic {
    static CounterStatic() {
        _count = 10;
    }
    private static int _count;
    public static int Count => _count;
    public static void DoCount() {
        _count++;
    }
}