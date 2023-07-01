class Calc02Working {
    private Meter x0_m = new Meter(1); // type is Meter because it's certain
    private DMYard x1_yard= new DMYard(1.5);
    private double c_1 = 0.5;
    private DMNewton f_N = new DMNewton(2);
    public DMJoule Energy_J() {
        // Compile-time error was caused if (DMMeter) cast is omitted. 
        // Try it by uncomment following sentence.
        // return f_N * (x0_m + c_1 * x1_yard);
        return f_N * ((DMMeter)x0_m + (DMMeter)(c_1 * x1_yard)); // #=> 3.5000
    }
}