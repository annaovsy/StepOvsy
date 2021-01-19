#include "flat.h"
#include "overcoat.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	//Overcoat overcoat("польто", 200);
	//overcoat.Print();
	//Overcoat overcoat2("шуба", 300);
	//overcoat2.Print();
	//overcoat2 = overcoat;
	//overcoat2.Print();

	Flat flat1(58, 2000000);
	Flat flat2;
	flat1 = flat2;
	flat1.Print();





}