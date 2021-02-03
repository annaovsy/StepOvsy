#pragma once

class BaseData
{
	double* data;
	int size;

public:
	BaseData(int _size) :size(_size), data(new double[size]) { cout << "Base()" << endl; }

	virtual ~BaseData()
	{
		if (data)
			delete[]data;
		cout << "~Base()" << endl;
	}
};
class DerivedData : public BaseData
{
	int* mass;
	int sizeMass;

public:
	DerivedData(int _size, int _sizeMass):BaseData(_size), sizeMass(_sizeMass), mass(new int[sizeMass])
	{
		cout << "Derived()" << endl;
	}
	
	~DerivedData()
	{
		if (mass)
			delete[]mass;
		cout << "~Derived()" << endl;
	}
};
