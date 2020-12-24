#pragma once
#include <iostream>
using namespace std;

class Temp
{
	int TEMP;
public:
	Temp() { TEMP = 25; }

	void TempFunction()
	{
		cout << "TEMP = " << TEMP << endl;
	}
	void TempSet(int T)
	{
		TEMP = T;
	}
};

class MyPtr
{
	Temp* ptr;
public:
	MyPtr(Temp* p = NULL)
	{
		ptr = p;
	}
	operator Temp* ()
	{
		return ptr;
	};
	Temp* operator->()
	{
		return ptr;
	}
	MyPtr operator++()
	{
		ptr++;
		return *this;
	}


};

class Singleton
{
private:
	static Singleton* s;
	int k;

	Singleton(int i) { k = i; }

public:
	static Singleton* GetReference() { return s; }
	int GetValue() { return k; }
	void SetValue(int i) { k = i; }

};