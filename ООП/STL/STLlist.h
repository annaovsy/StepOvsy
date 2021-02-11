#pragma once
#include <iostream>
#include <vector>
#include <list>
#include <algorithm>
using namespace std;

void TestList()
{
	list<int> lstTest;
	for (int i = 0; i < 10; i++)
	{
		lstTest.push_back(i);  //добавление в начало 
		lstTest.push_front(100 + i);	//в конец
	}
	list<int>::iterator ptrLst = lstTest.begin();
	while (ptrLst != lstTest.end())
	{
		cout << *ptrLst << " ";
		++ptrLst;
	}

	list<int> lstTest2;
	for (int i = 0; i < 5; i++)
	{
		lstTest.push_back(rand()%10);  //добавление в начало 
	}
	lstTest2.sort();
	lstTest.merge(lstTest2); //слияние 
	ptrLst = lstTest.begin();
	while (ptrLst != lstTest.end())
	{
		cout << *ptrLst << " ";
		++ptrLst;
	}
}

