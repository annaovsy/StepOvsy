#pragma once
#include <iostream>
using namespace std;

const int maxCount = 100;

class Employer
{
public:
	virtual void Print() = 0;
	virtual ~Employer() {};
};

class President : public Employer
{
	char* name;
public:
	President(const char* _name)
	{
		name = new char[maxCount]; 
		if (_name == NULL)
			return;
		strcpy_s(name, maxCount, _name);
	}
	void Print()
	{
		cout << "President " << name << endl;
	}
	virtual ~President()
	{
		if (name)
			delete[]name;
	}
};

class Manager : public Employer
{
	char* name;
public:
	Manager(const char* _name)
	{
		name = new char[maxCount];
		if (_name == NULL)
			return;
		strcpy_s(name, maxCount, _name);
	}
	void Print()
	{
		cout << "Manager " << name << endl;
	}
	virtual ~Manager()
	{
		if (name)
			delete[]name;
	}
};

class Worker : public Employer
{
	char* name;
public:
	Worker(const char* _name)
	{
		name = new char[maxCount];
		if (_name == NULL)
			return;
		strcpy_s(name, maxCount, _name);
	}
	void Print()
	{
		cout << "Worker " << name << endl;
	}
	virtual ~Worker()
	{
		if (name)
			delete[]name;
	}
};

