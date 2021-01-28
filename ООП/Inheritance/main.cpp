#include "inheritance.h"
#include "HomeAnimals.h"
#include "Vehicle.h"
#include <iostream>
using namespace std;

int main()
{
	DerivedTest* der = new DerivedTest(10, 20, 45.2);
	der->SetVal(10);
	der->ShowVal();

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