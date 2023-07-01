class Meter : PhysicsValue {
    public Meter(double value) : base (value) {}
    public static implicit operator Meter(Yard x) {
        return new Meter(x.Value * 0.9144);
    }
    public static Meter operator+(Meter a, Meter b) => new Meter(a.Value + b.Value);
    public static Meter operator-(Meter a, Meter b) => new Meter(a.Value - b.Value);
    public static Meter operator*(double a, Meter b) => new Meter(a * b.Value);
}