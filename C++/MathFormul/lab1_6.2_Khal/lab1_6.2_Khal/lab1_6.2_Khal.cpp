#include<iostream>
#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <iomanip>
#define N    4
#define N1    N+1
#define D 4
using namespace std;
double matrix[N][N1] = { {2,3,-4,1,3},
                                  {1,-2,-5,1,2},
                                  {5,-3,1,-4,1},
                                  {10,2,-1,2,-4} };
                                  
double matrix1[D][D] = {       {2,3,-4,1},
                                  {1,-2,-5,1},
                                  {5,-3,1,-4},
                                  {10,2,-1,2} };



void ShowSLAU(void) //показать СЛАУ
{
    cout << "СЛАУ:" << endl;
    int i, j;
    for (i = 0; i < N; i++)
    {
        for (j = 0; j < N; j++)
            printf("%+3.3f*x%d", matrix[i][j], i + 1);
        printf("=%3.3f\n", matrix[i][N]);
    }
}

void SLAUGauss(void)
{
	float tmp, xx[N1];
    short int i, j, k;
	/*Метод Гаусса*/
    /*прямой ход*/
    for (i = 0; i < N; i++)
    {
        tmp = matrix[i][i];
        for (j = N; j >= i; j--)
            matrix[i][j] /= tmp;
        for (j = i + 1; j < N; j++)
        {
            tmp = matrix[j][i];
            for (k = N; k >= i; k--)
                matrix[j][k] -= tmp * matrix[i][k];
        }
    }
    /*обратный ход*/
    xx[N - 1] = matrix[N - 1][N];
    for (i = N - 2; i >= 0; i--)
    {
        xx[i] = matrix[i][N];
        for (j = i + 1; j < N; j++) xx[i] -= matrix[i][j] * xx[j];
    }
    /*вывод решения*/
    printf("\nМетод Гаусса:\n");
    for (i = 0; i < N; i++)
        printf("x%d=%3.3f\n", i + 1, xx[i]);
}	

void ShowMatrix(void) // показать матрицу
{
    cout<<endl<<"Матрица:"<<endl;
    int i,j;
    for(i=0; i<D; i++)
    {
        for(j=0; j<D; j++)
        cout<<setw(5)<<matrix1[i][j];
        cout<<endl;
    }
}

double det () //вычисление определителя
{
    float kst;
    int i,j,p,k=0,t;
	 double **a;
	 a = new double *[D]; for (i = 0; i < D; i++)
        a[i] = new double[D]; 
	  for (i = 0; i<N; i++)
   {
        for (j = 0; j < N; j++) {
       a[i][j]=matrix1[i][j];
        }
   }
    
p=0;
for (i=0; i<D-1; i++)
{
t=1;
while(a[i][i]==0)
{
for(j=0; j<D; j++)
{
a[i][j]=kst;
a[i][j]=a[i+t][j];
a[i+t][j]=kst;
}
p++;
t++;
}
 
for (k=i+1; k<D; k++)
{
kst=a[k][i]/a[i][i];
for(j=0; j<D; j++)
a[k][j]-=a[i][j]*kst;
}
}
 
kst=pow(-1,p);
for(i=0; i<D; i++)
kst*=a[i][i];

return kst;
}

int Gauss(double **matrica_a, int n, double *massiv_b, double *x) //расчет обратной матрицы методом гаусса
{
    int i, j, k, r;
    double c, M, max, s, **a, *b; a = new double *[n];
    for (i = 0; i<n; i++) a[i] = new double[n];
    b = new double[n]; for (i = 0; i<n; i++)
        for (j = 0; j<n; j++) a[i][j] = matrica_a[i][j];
    for (i = 0; i<n; i++) b[i] = massiv_b[i];
    for (k = 0; k<n; k++){
        max = fabs(a[k][k]);
        r = k;
        for (i = k + 1; i<n; i++)
            if (fabs(a[i][k])>max){
                max = fabs(a[i][k]);
                r = i;}
        for (j = 0; j<n; j++){
            c = a[k][j];
            a[k][j] = a[r][j];
            a[r][j] = c;}
        c = b[k]; b[k] = b[r]; b[r] = c; for (i = k + 1; i<n; i++){
            for (M = a[i][k] / a[k][k], j = k; j<n; j++)
                a[i][j] -= M * a[k][j]; b[i] -= M * b[k];}
 
    }
    if (a[n - 1][n - 1] == 0) if (b[n - 1] == 0)return-1; else return-2;
    else {
        for (i = n - 1; i >= 0; i--){
            for (s = 0, j = i + 1; j<n; j++)
                s += a[i][j] * x[j]; x[i] = (b[i] - s) / a[i][i];
        }return 0;
    } for (i = 0; i<n; i++) delete[] a[i]; delete[] a;
    delete[] b;
 
}

int INVERSE (double **a, int n, double **y){ //обратная матрица
    int i, j, res; double *b, *x; b = new double[n]; x = new double[n]; for (i = 0; i<n; i++){
        for (j = 0; j<n; j++)
            if (j == i)   b[j] = 1; else b[j] = 0;
               res = Gauss(a, n, b, x);
               if (res != 0) break; 
               else for (j = 0; j < n; j++) {
                   y[j][i] = x[j];}
    }  
    delete[] x;
    delete[] b;
    if (res != 0) return -1;
    else return 0;
}



void InverseMatix(void)
{
	 int result, i,j;
    double **a, **b;
     a = new double *[D]; for (i = 0; i < D; i++)
        a[i] = new double[D]; b = new double *[D]; for (i = 0; i<D; i++)
        b[i] = new double[D];
	
   for (i = 0; i<N; i++)
   {
        for (j = 0; j < N; j++) {
       a[i][j]=matrix1[i][j];
        }
   }
	
	result = INVERSE(a, D, b); if (result == 0)
    {
        cout <<endl << "Обратаная матрица: " << endl; for (i = 0; i<D; cout << endl, i++)
            for (j = 0; j<D; j++)
                cout << b[i][j] << "\t";
    }

}
int main()
{
	setlocale (0,"");
	
    ShowSLAU();
	SLAUGauss();         
    ShowMatrix();    
    cout<<endl<<"Определитель матрицы: "<<det()<<endl;
	InverseMatix();
    return 0;
}