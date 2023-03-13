import java.util.Scanner;

public class Complex { //класс комплпекс
    double r; //действительное число
    double i; //мнимое число

    public Complex(double r, double i) { // коснтуркоктор класса с двумя параметрами
        this.r = r;
        this.i = i;
    }

    public String toString() { //метод
        if (i == 0) return r + "";
        if (r == 0) return i + "i";
        if (i < 0) return r + " - " + (-i) + "i";
        return r + "+" + i + "i";
    }

    public double re() {
        return r;
    } //метод вывод действительного числа

    public double im() {
        return i;
    } //метод минмого числа

    public static void main(String[] args) {
        double a, b;
        Scanner in = new Scanner(System.in);
        System.out.print("Введите a: ");
        a = in.nextDouble();
        System.out.print("Введите b: ");
        b = in.nextDouble();
        Complex complex = new Complex(a, b);
        System.out.println(complex.toString());
        System.out.println("Аргумент 1: " + complex.re() + "\nАргумент 2: " + complex.im());


    }
}
