class Calc03WorkingWithMistake {
    private Meter x0_m = new Meter(1);
    private DMMeter x1_yard= new DMMeter(1.5); // Mistake in guessing its unit!!
    private double c_1 = 0.5;
    private DMNewton f_N = new DMNewton(2);
    public DMJoule Energy_J() {
        // Value doesn't change although there's a mistake in guessing units.
        // It's because casting did nothing but passing value
        return f_N * ((DMMeter)x0_m + c_1 * x1_yard); // #=> 3.5000 
    }
}