#include <iostream>
#include "Student.h"
#include "FileStudents.h"
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	Student st("������", 25, 11.5);
	Student st2("������", 25, 11.5);
	Student st3("������d", 25, 11.5);
	Student studs[3] = { st,st2,st3 };
	Student studsTest[10];
	int count;
	//FileStudents::Save("Students", studs, 3);
	FileStudents::Read("Students", studsTest, count);
	for (int i = 0; i < count; i++)
	{
		studsTest[i].Print();
		cout << endl;
	}

}