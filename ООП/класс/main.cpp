#include "NumStor.h"
#include <iostream>
#include <ctime>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	
	//NumberStorage::SetNumber();

	NumberStorage numStor1(10);
	numStor1.Print();
	//NumberStorage::GetNumber();

	NumberStorage numStor2(10);
	numStor2.Print();
	//NumberStorage::GetNumber();

	//NumberStorage numStor3(10);
	//NumberStorage::GetNumber();


}
