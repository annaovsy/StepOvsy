#pragma once
#include <iostream>
#include <ctime>
using namespace std;

class NumberStorage
{
private:
	int* storage;
	uint32_t elementCount;
	static uint32_t usedMemory;
	static int countStorages;

public:
	static void SetNumber(uint32_t value = 0) 
		{ usedMemory = 0; }
	static uint32_t GetNumber() 
		{ return usedMemory; }

	NumberStorage(uint32_t _elementCount);
	NumberStorage(const NumberStorage& copy);

	void Print();
	
	~NumberStorage();
};

//uint32_t NumberStorage::usedMemory = 0;	//для статики