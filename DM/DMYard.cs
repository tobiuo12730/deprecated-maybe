class DMYard : PhysicsValue {
    public DMYard(double value) : base(value) {}
    public static DMYard operator+(DMYard a, DMYard b) => new DMYard(a.Value + b.Value);
    public static DMYard operator-(DMYard a, DMYard b) => new DMYard(a.Value - b.Value);
    public static DMYard operator*(double a, DMYard b) => new DMYard(a * b.Value);
    public static explicit operator DMYard (Yard a) => new DMYard(a.Value);
}
