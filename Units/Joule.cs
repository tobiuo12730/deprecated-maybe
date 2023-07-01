class Joule : PhysicsValue {
    public Joule(double value) : base (value) {}
    public static Joule operator+(Joule a, Joule b) => new Joule(a.Value + b.Value);
    public static Joule operator-(Joule a, Joule b) => new Joule(a.Value - b.Value);
}