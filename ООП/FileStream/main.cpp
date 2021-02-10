#include <iostream>
#include "Student.h"
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	Student st("Иванов", 25, 11.5);
	st.SaveToFile("Student", true);
	Student st2;
	st2.ReadToFile("Student", true);
	st2.Print();

}