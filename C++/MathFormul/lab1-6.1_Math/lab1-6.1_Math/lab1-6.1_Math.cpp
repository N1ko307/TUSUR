

#include <iostream>
#include <cmath>
using namespace std;

float Fx(float x)
{
    return 1.2 * pow(x, 4) + 2 * pow(x, 3) - 24.1 - 13 * pow(x, 2) - 14.2 * x;

}

int main()
{
    setlocale(LC_ALL, "RUS");
    float a, b, e, delta, g=1.618, delta1, delta2, c,d;
    float fa, fc, fd, fb;
    float a1, b1;
    //f(x)=1.2x^4+2x^3-24.1-13x^2-14.2x
    cout << "Введите начало интервала: ";
    cin >> a;
    cout << endl << "Введите конец интервала: ";
    cin >> b;
    cout << endl << "Введите точность: ";
    cin >> e;


    delta = b - a;//d1
    delta1 = delta / g;//d2 
   
    do {
       
        delta2 = delta*pow((g - 1), 2);//d3 d4=d2*, d5=d3*...

        delta = delta1;//d1=d2,
        
        delta1 = delta2;//d2=d3,d3=d4...
       
       
        c = a + delta2;//d3,d4,d5...
        d = a + delta;//d2,d3,d4....
       

        fa = Fx(a);
        fc = Fx(c);
        fd = Fx(d);
        fb = Fx(b);
        cout << fa << " " << fc << " " << fd << " " << fb << endl;
        if (fa * fd <= 0 )
        {
            a = a;
            b = d;
        }
        else
        {
            a = c;
            b = b;

        }
       
      
    } while (e < delta / 2);

    cout << delta / 2 << endl;
    cout << (b + a) / 2 << endl;
    
    
}
