#include <GL/glut.h> 
#include <complex>
#include <iostream>
using namespace std;


void myInit(void);
void myDisplay(void);
void DrawJulia(int iterations);


int main(int argc, char** argv)
{
	glutInit(&argc, argv); //инициализация GLUT and создание окна
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
	glutInitWindowSize(800, 800); // размер окна
	glutInitWindowPosition(350, 20);// расположение окна на экране
	glutCreateWindow("Фрактал Джулия");// название окна
	glutDisplayFunc(myDisplay);//Установка функций, отвечающих за рисование в окне и изменении формы окна.
	glutMainLoop();
}

void myDisplay() 
{
	glClearColor(1.0, 1.0, 1.0, 0.0); // цвет фона окна
	glClear(GL_COLOR_BUFFER_BIT);
	DrawJulia(100);//вызов функции с параметром
	glFlush();
}

void DrawJulia(int iterations)
{	
	glPointSize(1.0); //Размер кисти
	glColor3f(0.0, 0.0, 1.0); //Цвет кисти
	glBegin(GL_POINTS); //определяет границы, внутри которых заданы вершины примитива или группы примитивов.работает с буфером накопления.
	complex<double> c1(0.36, 0.36); // комплексная константа
	for (double a = -1.0; a < 0.7; a += 0.001) //Координаты x0 до xn
	{
		for (double b = -0.9; b < 1.1; b += 0.001)//Координаты y0 до yn
		{

			complex<double> z(a, b);	//комплексное число		
		
			int iterator = 0; //счетчик
			while (iterator < iterations)
			{
				z = pow(z, 2) + c1; //формула итераций для фрактала джулия
				iterator++;
				if (abs(z) > 2)//Условие завершения итерации
					break;
			}
			if (iterator == 100)
				glVertex2d(a, b);//Указывает вершину
		}
	}
	glEnd();// завершение рисования
}