class DMJoule : PhysicsValue {
    public DMJoule(double value) : base(value) {}
    public static DMJoule operator+(DMJoule a, DMJoule b) => new DMJoule(a.Value + b.Value);
    public static DMJoule operator-(DMJoule a, DMJoule b) => new DMJoule(a.Value - b.Value);
    public static explicit operator DMJoule (Joule a) => new DMJoule(a.Value);
}