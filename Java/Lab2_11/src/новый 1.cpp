// Gl-frakt.cpp : Defines the entry point for the application.

#include "stdafx.h"

#include "Gl-frakt.h"

#include

#define MAX_LOADSTRING 100

#define MaxIterationsIndex 511

#define MAX_LOADSTRING 100

//#define c1 0.36

// Global Variables:

HINSTANCE hInst; // current instance

TCHAR szTitle[MAX_LOADSTRING]; // The title bar text

TCHAR szWindowClass[MAX_LOADSTRING]; // the main window class name

// Forward declarations of functions included in this code module:

ATOM MyRegisterClass(HINSTANCE hInstance);

BOOL InitInstance(HINSTANCE, int);

LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);

INT_PTR CALLBACK About(HWND, UINT, WPARAM, LPARAM);

int APIENTRY _tWinMain(HINSTANCE hInstance,

HINSTANCE hPrevInstance,

LPTSTR lpCmdLine,

int nCmdShow)

{

UNREFERENCED_PARAMETER(hPrevInstance);

UNREFERENCED_PARAMETER(lpCmdLine);

// TODO: Place code here.

MSG msg;

HACCEL hAccelTable;

// Initialize global strings

LoadString(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);

LoadString(hInstance, IDC_GLFRAKT, szWindowClass, MAX_LOADSTRING);

MyRegisterClass(hInstance);

// Perform application initialization:

if (!InitInstance (hInstance, nCmdShow))

{

return FALSE;

}

hAccelTable = LoadAccelerators(hInstance,

MAKEINTRESOURCE(IDC_GLFRAKT));

// Main message loop:

while (GetMessage(&msg, NULL, 0, 0))

{

if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))

{

TranslateMessage(&msg);

DispatchMessage(&msg);

}

}

return (int) msg.wParam;

}

//

// FUNCTION: MyRegisterClass()

//

// PURPOSE: Registers the window class.

//

// COMMENTS:

//

// This function and its usage are only necessary if you want this code

// to be compatible with Win32 systems prior to the 'RegisterClassEx'

// function that was added to Windows 95. It is important to call this function

// so that the application will get 'well formed' small icons associated

// with it.

//

ATOM MyRegisterClass(HINSTANCE hInstance)

{

WNDCLASSEX wcex;

wcex.cbSize = sizeof(WNDCLASSEX);

wcex.style = CS_HREDRAW | CS_VREDRAW;

wcex.lpfnWndProc = WndProc;

wcex.cbClsExtra = 0;

wcex.cbWndExtra = 0;

wcex.hInstance = hInstance;

wcex.hIcon = LoadIcon(hInstance,

MAKEINTRESOURCE(IDI_GLFRAKT));

wcex.hCursor = LoadCursor(NULL, IDC_ARROW);

wcex.hbrBackground = (HBRUSH)(COLOR_WINDOW+1);

wcex.lpszMenuName = MAKEINTRESOURCE(IDC_GLFRAKT);

wcex.lpszClassName = szWindowClass;

wcex.hIconSm = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

return RegisterClassEx(&wcex);

}

// FUNCTION: InitInstance(HINSTANCE, int)

//

// PURPOSE: Saves instance handle and creates main window

//

// COMMENTS:

//

// In this function, we save the instance handle in a global variable and

// create and display the main program window.

//

BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)

{

HWND hWnd;

hInst = hInstance; // Store instance handle in our global variable

hWnd = CreateWindow(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,

CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, NULL, NULL, hInstance, NULL);

if (!hWnd)

{

return FALSE;

}

ShowWindow(hWnd, nCmdShow);

UpdateWindow(hWnd);

return TRUE;

}

//

// FUNCTION: WndProc(HWND, UINT, WPARAM, LPARAM)

//

// PURPOSE: Processes messages for the main window.

//

// WM_COMMAND - process the application menu

// WM_PAINT - Paint the main window

// WM_DESTROY - post a quit message and return

//

//

void Draw2(HWND hWnd);

void Draw3(HWND hWnd);

void Draw4(HWND hWnd);

void Draw6(HWND hWnd);

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)

{

int wmId, wmEvent;

PAINTSTRUCT ps;

HDC hdc;

switch (message)

{

case WM_COMMAND:

wmId = LOWORD(wParam);

wmEvent = HIWORD(wParam);

// Parse the menu selections:

switch (wmId)

{

case IDM_ABOUT:

DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd,

About);

break;

case 201:

Draw6(hWnd); //Фрактал Мандельброта

break;

case 202:

Draw3(hWnd); //Джулия

break;

case 203:

Draw2(hWnd); //Шары

break;

case IDM_EXIT:

DestroyWindow(hWnd);

break;

default:

return DefWindowProc(hWnd, message, wParam, lParam);

}

break;

case WM_PAINT:

hdc = BeginPaint(hWnd, &ps);

// TODO: Add any drawing code here...

EndPaint(hWnd, &ps);

break;

case WM_DESTROY:

PostQuitMessage(0);

break;

default:

return DefWindowProc(hWnd, message, wParam, lParam);

}

return 0;

}

// Message handler for about box.

INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)

{

UNREFERENCED_PARAMETER(lParam);

switch (message)

{

case WM_INITDIALOG:

return (INT_PTR)TRUE;

case WM_COMMAND:

if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)

{

EndDialog(hDlg, LOWORD(wParam));

return (INT_PTR)TRUE;

}

break;

}

return (INT_PTR)FALSE;

}

//Фрактал Джулия программа

void Dguli(HDC hdc,int xx,int yy,int cx,int cy,

double minX,double maxX,

double minY,double maxY);

int Iterations(double x,double y);

COLORREF IndexToColor(int index);

void Draw3(HWND hWnd)

{

HDC hdc;

RECT rc;

hdc=GetDC(hWnd);

if (hdc==NULL) return;

GetClientRect(hWnd,&rc);

Dguli(hdc,0,0,rc.right/2,rc.bottom/2,

-1,1,-1.2,1.2);

ReleaseDC(hWnd,hdc);

}

//Аргументы:xx,yy,cx,cy-координаты и размеры окна

//--------- minX,maxY- фрагменты комплексной плоскости

void Dguli(HDC hdc,int xx,int yy,int cx,int cy,

double minX,double maxX,

double minY,double maxY)

{

double stepX,stepY;

int i,j,iter;

double x,y;

stepX=(maxX-minX)/(double)cx;

stepY=(maxY-minY)/(double)cy;

y=minY;

for (j=0;j
{

x=minX;

for (i=0;i
{

iter = Iterations(x,y);

SetPixel(hdc,xx+i,yy+j,IndexToColor(iter));

x+=stepX;

}

y+=stepY;

}

}

//цикл итераций для одной точки изображения

int Iterations(double x,double y)

{

int i;

double xx,yy,xk,yk;

double c0=0.36;double c1=0.36;//Константа Джулии

xx=x;

yy=y;

i=0;

while (xx*xx+yy*yy<=4.0)

{

xk=xx*xx-yy*yy+c0;

yk=2.0*xx*yy+c1;

xx=xk;

yy=yk;

i++;

if (i>=MaxIterationsIndex) break;

}

return i;

}

//цвет точки в зависимости от числа итераций

COLORREF IndexToColor(int index)

{

return 8*(MaxIterationsIndex-index);//эмпирически

}

//Программа шары

void MySphere(HDC hdc,int xc,int yc,int R,BYTE red,BYTE gre,BYTE blu);

void Draw2(HWND hWnd)

{

HDC hdc;

RECT rc;

double xc,yc,x,y,r,rmax,d;

//int xc,yc,x,y,r,rmax,d;

hdc=GetDC(hWnd);

if (hdc==NULL) return;

GetClientRect(hWnd,&rc);

Rectangle(hdc,0,0,rc.right,rc.bottom);

xc=(rc.right-rc.left)/2;

yc=(rc.bottom-rc.top)/2;

if (xc <= yc)

rmax=xc/3;

else

rmax=yc/3;

MySphere(hdc,xc,yc,rmax,255,255,0);

d=0;

for (int i=1 ;i<=3; i++)

{

d+=(rmax/i)+rmax/(i+1);

x=(double)d*0.866;

y=(double)d*0.5;

r=rmax/(i+1);

if (i==1) MySphere(hdc,xc,yc-d,r,255,0,0);

if (i<=2)

{

MySphere(hdc,xc+x,yc-y,r,0,255,255);

MySphere(hdc,xc-x,yc-y,r,0,255,255);

}

MySphere(hdc,xc+y,yc+x,r,0,255,0);

MySphere(hdc,xc-y,yc+x,r,0,255,0);

}

ReleaseDC(hWnd,hdc);

}

void MySphere(HDC hdc,int xc,int yc,int R,

BYTE red,BYTE gre,BYTE blu)

{

COLORREF clr;

double R2,r2,k;

int x,y;

R2=R*R;

for (x=0;x<=R;x++)

for (y=0;y<=x;y++)

{

r2=x*x+y*y;

if (r2>R2) break;

k=1-r2/R2;//к=cos в квадрате угла нормали

clr =RGB((BYTE)(k*(double)red),

(BYTE) (k*(double)gre),

(BYTE) (k*(double)blu));

SetPixel(hdc,xc+x,yc+y,clr);

SetPixel(hdc,xc+x,yc-y,clr);

SetPixel(hdc,xc-x,yc+y,clr);

SetPixel(hdc,xc-x,yc-y,clr);

SetPixel(hdc,xc+y,yc+x,clr);

SetPixel(hdc,xc+y,yc-x,clr);

SetPixel(hdc,xc-y,yc+x,clr);

SetPixel(hdc,xc-y,yc-x,clr);

}

}

//Фрактал Мандельброта

void Mandelbrot(HDC hdc,int xx,int yy,int cx,int cy,

double minX,double maxX,

double minY,double maxY);

int Iterations1(double x,double y);

COLORREF IndexToColor(int index);

void Draw6(HWND hWnd)

{

HDC hdc;

RECT rc;

hdc=GetDC(hWnd);

if (hdc==NULL) return;

GetClientRect(hWnd,&rc);

Mandelbrot(hdc,0,0,rc.right/2,rc.bottom/2,

-2.2,1,-1.2,1.2);

//Mandelbrot(hdc,0,0,rc.right/2,rc.bottom/2,

// -1,-0.5,-0.5,0);

// Mandelbrot(hdc,0,0,rc.right/2,rc.bottom/2,

// -0.75,-0.6,-0.5,-0.35);

// Mandelbrot(hdc,0,0,rc.right/2,rc.bottom/2,

// -0.68,-0.65,-0.37,-0.36);

ReleaseDC(hWnd,hdc);

}

//Аргументы:xx,yy,cx,cy-координаты и размеры окна

//--------- minX,maxY- фрагменты комплексной плоскости

void Mandelbrot(HDC hdc,int xx,int yy,int cx,int cy,

double minX,double maxX,

double minY,double maxY)

{

double stepX,stepY;

int i,j,iter;

double x,y;

stepX=(maxX-minX)/(double)cx;

stepY=(maxY-minY)/(double)cy;

y=minY;

for (j=0;j
{

x=minX;

for (i=0;i
{

iter = Iterations1(x,y);

SetPixel(hdc,xx+i,yy+j,IndexToColor(iter));

x+=stepX;

}

y+=stepY;

}

}

//цикл итераций для одной точки изображения

int Iterations1(double x,double y)

{

int i;

double xx,yy,xk,yk;

COLORREF clr;

xx=x;

yy=y;

i=0;

while (xx*xx+yy*yy<=4.0)

{

xk=xx*xx-yy*yy+x;

yk=2.0*xx*yy+y;

xx=xk;

yy=yk;

i++;

if (i>=MaxIterationsIndex) break;

}

return i;

}
}