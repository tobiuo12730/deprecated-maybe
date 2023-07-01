class DMMeter : PhysicsValue {
    public DMMeter(double value) : base(value) {}
    public static DMMeter operator+(DMMeter a, DMMeter b) => new DMMeter(a.Value + b.Value);
    public static DMMeter operator-(DMMeter a, DMMeter b) => new DMMeter(a.Value - b.Value);
    public static DMMeter operator*(double a, DMMeter b) => new DMMeter(a * b.Value);
    public static explicit operator DMMeter (Meter a) => new DMMeter(a.Value);
    public static explicit operator DMMeter (DMYard x) {
        return new DMMeter(x.Value); // TODO : Migrate to non-prefixed Meter
    }
    public static DMJoule operator*(Newton f, DMMeter x) {
        return new DMJoule(f.Value * x.Value); // TODO
    }
}
