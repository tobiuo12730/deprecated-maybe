class DMNewton : PhysicsValue {
    public DMNewton(double value) : base(value) {}    
    public static DMNewton operator+(DMNewton a, DMNewton b) => new DMNewton(a.Value + b.Value);
    public static DMNewton operator-(DMNewton a, DMNewton b) => new DMNewton(a.Value - b.Value);
    public static explicit operator DMNewton (Newton a) => new DMNewton(a.Value);

    public static DMJoule operator*(DMNewton f, DMMeter x) {
        return new DMJoule(f.Value * x.Value); // TODO
    }
}