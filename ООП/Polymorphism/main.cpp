#include"Polymorphism.h"
#include<iostream>
#include <ctime>
using namespace std;

class Base
{
	int x;

public:
	void SetX(int _x) { x = _x; }
	int GetX() { return x; }

	virtual void Show()
	{
		cout << "Base " << "x = " << x << endl;
	}
};

class Derived:public Base
{
	int y;

public:
	void SetY(int _y) { y = _y; }
	int GetY() { return y; }
	void SetXY(int _y, int _x)
	{
		y = _y;
		SetX(_x);
	}

	void Show()
	{
		cout << "Derived " << "y = " << y << endl;
	}
};

int main(int argc, char* argv[])
{
	srand(time(NULL));

	Figure* ptr;
	Figure obFigure;
	//Rectangle obRect(10,11);
	//Circle obCircle(12.5);
	//Triangle obTriangle(11, 15.5);

	string str = argv[1];
	if (argc <= 1)
	{
		return -1;
	}

	if (str == "1")
	{
		ptr = new Rectangle(10, 11);
	}
	else if (str == "2")
	{
		ptr = new Circle(10.2);
	}
	else if (str == "3")
	{
		ptr = new Triangle(11, 15.5);
	}
	cout << "Area = " << ptr->GetArea() << endl;
	

	//Base* ptrB;	//указатель на базовый класс
	//Base obB;	//объект базового класса
	//Derived obDer;	//объект производного класса
	//obB.SetX(10);
	//obDer.SetXY(20,15);

	//int j = 0;
	//for (int i = 0; i < 10; i++)
	//{
	//	j = rand();
	//	if (j % 2) //если j четное, то присваиваем объект производного класса
	//		ptrB = &obDer;
	//	else       //если нет, то объект базового класса
	//		ptrB = &obB;

	//	ptrB->Show();
	//}

	//ptrB->Show(); 
	//ptrB = &obDer;  //присвоили указателю ссылку на объект производного класса
	//ptrB->Show();	//в зависимости от того на что ссылается указатель,
					//вызывается та функция show ,которая нужна. это ПОЛИМОРФИЗМ

	//ptrB = &obB;
	//cout << " GetX = " << ptrB->GetX() << endl;
	//ptrB = &obDer; //разные типы данных, нельзя. нужно использовать наследование

	//ptrB = &obDer;
	//cout << " GetX = " << ptrB->GetX() << endl;
}