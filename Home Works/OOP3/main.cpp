#include "flat.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	Overcoat overcoat("polto", 200);
	overcoat.Print();
	Overcoat overcoat2("шуба", 300);
	overcoat2.Print();
	overcoat2 = overcoat;
	overcoat2.Print();




}