class DemoRecursion {

    public int recursor = 200;

    static void Main() {
        Recursion(recursor);
    }
    public int Recursion( int recursor ) {
        if (recursor == 0) {
            return 1;
        }
        else {
            System.Console.Out("Recursor: " + recursor);
            recursor--;
            Recursion(recursor);
        }

    }
}