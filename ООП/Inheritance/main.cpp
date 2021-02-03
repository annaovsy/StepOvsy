#include "inheritance.h"
#include "HomeAnimals.h"
#include "Vehicle.h"
#include "MultipleInheritance.h"
#include <iostream>
using namespace std;

int main()
{
	Derived1 der1;
	der1.i = 50;
	der1.ShowI();

	Derived2 der2;
	der2.i = 30;
	der2.ShowI();

	Derived3 der3;
	der3.i = 100; //доступ к базовому классу у множественного наследования только через virtual
	der3.SetD3(20);
	der3.ShowD3();



	//DerivedTest* der = new DerivedTest(10, 20, 45.2);
	//der->SetVal(10);
	//der->ShowVal();

	//Derived der(15,25);
	////der.SetXY(10, 20, 9.2);
	////der.SetX(50);
	//der.Show(); 

	//Dog dog("Dog", "dhgh");
	//dog.ShowDog();
	//Cat cat("Cat", "white");
	//cat.ShowCat();
	//Parrot parrot("Parrot", true);
	//parrot.ShowParrot();

	//Car car(1, 2, 5);
	//car.Show();
	//cout << endl;
	//Truck truck(2, 2, 6);
	//truck.Show();

}