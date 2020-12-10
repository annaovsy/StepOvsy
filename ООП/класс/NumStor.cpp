#include "NumStor.h"
#include <iostream>
#include <ctime>
using namespace std;

uint32_t NumberStorage::usedMemory = 0;
int NumberStorage::countStorages = 0;

NumberStorage::NumberStorage(uint32_t _elementCount) :
	storage{ _elementCount == 0 ? NULL : new int[_elementCount] },
	elementCount{ _elementCount }
{
	uint32_t used = elementCount * sizeof(int);
	usedMemory += used;

	cout << "Number Storege:aditional " << used << " bytes used." << endl;
cout<<"Total: " << usedMemory << endl;
	for (uint32_t i = 0; i < elementCount; i++)
	{
		storage[i] = rand() % 10;
	}
}

NumberStorage::NumberStorage(const NumberStorage& copy):
	NumberStorage(copy.elementCount)
{
	for (uint32_t i = 0; i < elementCount; i++)
	{
		storage[i] = copy.storage[i];
	}
}

void NumberStorage::Print()
{
	for (int i = 0; i < elementCount; i++)
	{
		cout << storage[i] << " ";
	}
	cout << endl;
}

NumberStorage::~NumberStorage()
{
	delete[]storage;
	usedMemory -= elementCount * sizeof(int);
	cout << "объект удален. количество памяти = " << usedMemory << endl;
};

 