public abstract class PhysicsValue {
    public double Value { get; private set; }
    public PhysicsValue(double value)
    {
        this.Value = value;
    }   
}