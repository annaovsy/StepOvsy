#include "template.h"
#include "template.cpp"
#include <iostream>
#include <string>
using namespace std;

class Student
{
	string name;
	int age;
	double averMark;
public:
	Student() {};
	Student(char* pName, int pAge, double mark): age(pAge), averMark(mark)
	{
		if (pName)
		{
			name = pName;
		}
	}
};

int main()
{
	Array <int> massI;
	massI.SetSize(10, 5);
	for (int i = 0; i < 10; i++)
	{
		massI.Add(i + 1);
	}
	for (int i = 0; i < 10; i++)
	{
		cout << massI.GetAt(i) << " ";
	}

	Array<Student> students;
	students.SetSize(5);
	Student st("Ivanov",25,10);
	Student st2("Petrov", 25, 9.3);

	students.SetAt(st, 0);	
	students.Add(st2);

	string str1("1234a");
	string str2;
	str2 = str1;
	cout << str2;
	str1[0] = '!';
	cout << str2 << "\t" << str1;
	string str3 = str1 + str2;
	cout << str3 << endl;



}