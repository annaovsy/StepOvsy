#pragma once
#include <iostream>

using namespace std;

const int maxCount = 100;

class  Student
{
private:
	char* name;
	int* marks;
	int currentMarks = 0;
public:
	//Student();	//конструктор
	Student(const char* _name = NULL);	//конструктор по умолчанию
	Student(const char* _name, const int* _marks);	//конструктор

	void SetNameStudent(const char* _name);
	const char* GetNameStudent();

	void SetMarksStudent(const int* _marks);
	const int* GetMarksStudent();

	int GetCurrentSize();


	void initStudent(char*, int*);

	void PrintStudent();

	double AveregeMarks();

	~Student();	//деструктор



};



