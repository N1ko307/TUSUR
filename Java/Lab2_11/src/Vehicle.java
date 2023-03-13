import java.util.*;

interface  Cars{ // интерфейс машины
void show();
}
abstract class Truck implements Cars{ // абстрактный класс грузовые машины наследуется от интерфейса машины
public int capacity; //грзоподъемность
public int fuel; //вместимость бака
public int power_engine; // мощность двигателя


    @Override
    public void show(){ // вывод информации в консоль
        System.out.println("Грузоподъемность: "+capacity+" т.\nВместимость бака: "+fuel+" л.\nМощность двигателя: "+power_engine+" л.с.");
    }
}
class KAMAZ extends  Truck{ // класс камаз наследуется от абстрактного класса грузовые машины

    public KAMAZ (int fuel, int power_engine)
    {
        this.fuel = fuel;
        this.power_engine = power_engine;
    }
    public int print_capacity() // ввод с клавиатуры грузопдъемность грузовика
    {
        System.out.print("Введите грузоподъемность в тоннах: ");
        Scanner in = new Scanner(System.in);
        capacity = in.nextInt();
        return 0;
    }

}

public class Vehicle {
    public static void main(String[] args){
KAMAZ kamaz = new KAMAZ(500,440);
kamaz.print_capacity();
kamaz.show();
    }

}
