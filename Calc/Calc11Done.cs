class Calc11Done {
    private Meter x0_m = new Meter(1);
    private Yard x1_yard= new Yard(1.5);
    private double c_1 = 0.5 * 1 / 0.9144;
    private Newton f_N = new Newton(2);
    public Joule Energy_J() {
        return f_N * (x0_m + c_1 * x1_yard); // #=> 3.5000
    }
}