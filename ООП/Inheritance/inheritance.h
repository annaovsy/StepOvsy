//#pragma once
//#include <iostream>
//using namespace std;
//
//class Base
//{
//	int x;
//protected:  // имеет доступ только наследник
//	double value;
//public:
////	Base() { cout << "Constructor Base!" << endl; }	//сначала вызывается конструктор базового класса, затем наследника
//	Base(int _x) :x{ _x }
//	{
//		cout << "Base(int _x)" << endl;
//	}
//	
//	~Base() { cout << "Destructor Base!" << endl; };//сначала вызывается деструктор наследника, затем базового класска
//	
//	void SetX(int _x) { x = _x; }
//	void ShowX() { cout << "x = " << x << endl; }
//};
//
//class Base2
//{
//	int z;
//
//public:
////	Base2()	{	cout << "Base2()" << endl;	}
//	Base2(int _z)
//	{
//		z = _z;
//		cout << "Base2(int _z)" << endl;
//	}
//	~Base2() { cout << "~Base2()" << endl; }
//	void SetZ(int _z) { z = z; }
//	void ShowZ()
//	{
//		cout << "z = " << z << endl;
//	}
//};
//
//class DerivedTest : public Base, public Base2
//{
//	double val;
//
//public:
//	//DerivedTest() { cout << "DerivedTest()" << endl; }
//	DerivedTest(int _x, int _z, double _val) :Base(_x), Base2(_z), val( _val )
//	{
//		cout << "DerivedTest(int _x, int _z, double _val)" << endl;
//	}
//	void SetVal(double _val) { val = _val; }
//	void ShowVal()
//	{
//		cout << "value = " << val << endl;
//	}
//	~DerivedTest() { cout << "~DerivedTest() " << endl; }
//
//};
//
//class Derived : public Base
//{
//	int y;
//public:
//	//Derived() { cout << "Constructor Derived!" << endl; }
//	Derived(int _x, int _y) :Base(_x), y( _y )
//	{
//		cout << "Derived(int _x, int _y)" << endl;
//	}
//	
//	~Derived() { cout << "Destructor Derived!" << endl; };
//
//	void SetXY(int _x, int _y, double val)
//	{
//		y = _y;
//		value = val;
//		SetX(_x);
//	}
//
//	void Show()
//	{
//		ShowX();
//		cout << "y = " << y << endl;
//	}
//};
//
//
//
//
