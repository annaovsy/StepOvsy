#include "Shape.h"
#include "Embloyer.h"
#include <iostream>
using namespace std;

int main()
{
	Employer* ptr;
	ptr = new President("Joe");
	ptr = new Manager("Bill");
	ptr = new Worker("Ben");
	ptr->Print();
}
