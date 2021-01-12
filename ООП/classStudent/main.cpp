#include "st.h"
#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	// Студент
	Student student("Piter", new int[6]{ 3, 4, 5, 4, 5, 5 });	//функция конструктора, вызывается один раз
	student.SetNameStudent("Nick");
	cout << "Get name: " << student.GetNameStudent() << endl;
	student.PrintStudent();
	student.SetMarksStudent(new int[6] {3, 4, 5, 4, 5, 5});
	const int* marks = student.GetMarksStudent();
	for (int i = 0; i < student.GetCurrentSize(); i++)
	{
		cout << marks[i] << " ";
	}
	cout << endl;
	int* marks2 = new int[6] { 3, 4, 5, 4, 5, 5 };
	student.initStudent((char*)"Jo", marks2);
	student.PrintStudent();
	cout << "Averege mark: " << student.AveregeMarks() << endl;
	int size = 5;
	Student* students = new Student[size]
	{
		{"Студент 1", new int[3]{7,10,9}},
		{"Студент 2", new int[3]{8,11,9}},
		{"Студент 3", new int[3]{12,10,8}},
		{"Студент 4", new int[3]{6,10,10}},
		{"Студент 5", new int[3]{11,8,10}}
	};
	for (int i = 0; i < size; i++)
	{
		students[i].PrintStudent();
		cout << endl;
	}
}