class Newton : PhysicsValue {
    public Newton(double value) : base (value) {}
    public static Newton operator+(Newton a, Newton b) => new Newton(a.Value + b.Value);
    public static Newton operator-(Newton a, Newton b) => new Newton(a.Value - b.Value);
    public static Joule operator*(Newton f, Meter x) {
        return new Joule(f.Value * x.Value);
    }
}