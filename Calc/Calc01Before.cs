class Calc01Before {
    private double x0_m = 1; // Real unit is m, and its unit is certain.
    private double x1_yard = 1.5; // yard, uncertain
    private double c_1 = 0.5; // m/yard, uncertain
    private double f_N = 2; // Newton, uncertain
    public double Energy_J() { // Joule
        return f_N * (x0_m + c_1 * x1_yard); // #=> 3.5000
    }
}