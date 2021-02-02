#pragma once
#include <iostream>
using namespace std;

class Base
{
public:
	int i;

	void SetI(int _i) { i = _i; }
	void ShowI() { cout << "i = " << i << endl; }
};

class Derived1 :virtual public Base
{
public:
	int d1;

	void SetD1(int _d1) { d1 = _d1; }
	void ShowD1() { cout << "d1 = " << d1 << endl; }
};

class Derived2 :virtual public Base
{
public:
	int d2;

	void SetD2(int _d2) { d2 = _d2; }
	void ShowD2() { cout << "d2 = " << d2 << endl; }
};

class Derived3 :public Derived1, public Derived2
{
public:
	int d3;
	void SetD3(int _d3) { d3 = _d3; }
	void ShowD3() { cout << "d3 = " << d3 << endl; }
};

