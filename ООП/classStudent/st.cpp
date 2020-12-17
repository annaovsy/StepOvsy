#include "st.h"
#include <iostream>
using namespace std;

//Student::Student()
//{
//	//name = (char*)"NoName";
//	name = new char[maxCount];
//	marks = new int[maxCount];
//}

Student::Student(const char* _name) //конструктор по умолчанию
{
	marks = new int[maxCount];
	name = new char[maxCount] {"\0"};

	if (_name == NULL)
		return;
	strcpy_s(name, maxCount, _name);
}

Student::Student(const char* _name, const int* _marks)
{
	marks = new int[maxCount];
	name = new char[maxCount];

	if (_name == NULL)
		return;
	strcpy_s(name, maxCount, _name);

	if (_marks == NULL)
		return;
	int size = _msize((int*)_marks) / sizeof(int);
	currentMarks = size;
	for (int i = 0; i < size; i++)
	{
		marks[i] = _marks[i];
	}
}

void Student::SetNameStudent(const char* _name)
{
	if (_name == NULL)
		return;

	strcpy_s(name, maxCount, _name);
}

const char* Student::GetNameStudent()
{
	return name;
}

void Student::SetMarksStudent(const int* _marks)
{
	if (_marks == NULL)
		return;

	int size = _msize((int*)_marks) / sizeof(int);
	currentMarks = size;
	for (int i = 0; i < size; i++)
	{
		marks[i] = _marks[i];
	}
}

const int* Student::GetMarksStudent()
{
	return marks;
}

int Student::GetCurrentSize()
{
	return currentMarks;
}

void Student::initStudent(char* _name, int* _marks)
{
	for (int i = 0; i < strlen(_name) + 1; i++)
	{
		name[i] = _name[i];
	}

	int size = _msize(_marks) / sizeof(int);
	currentMarks = size;
	for (int i = 0; i < size; i++)
	{
		marks[i] = _marks[i];
	}
}

void Student::PrintStudent()
{
	cout << "Name: " << name << endl;
	cout << "Marks list: ";
	for (int i = 0; i < currentMarks; i++)
	{
		cout << marks[i] << " ";
	}
	cout << endl;
}

double Student::AveregeMarks()
{
	double sum = 0;
	for (int i = 0; i < currentMarks; i++)
	{
		sum += marks[i];
	}
	sum /= currentMarks;
	return sum;
}

Student::~Student() //деструктор срабатывает автоматически, вызывать не надо
{
	if (name)
		delete[]name;

	if (marks)
		delete[]marks;

	cout << "destructor was used" << endl;
}
