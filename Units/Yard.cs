class Yard : PhysicsValue {
    public Yard(double value) : base (value) {}
    public static Yard operator+(Yard a, Yard b) => new Yard(a.Value + b.Value);
    public static Yard operator-(Yard a, Yard b) => new Yard(a.Value - b.Value);
    public static Yard operator*(double a, Yard b) => new Yard(a * b.Value);
}