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
		lstTest.push_back(i);  //���������� � ������ 
		lstTest.push_front(100 + i);	//� �����
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
		lstTest.push_back(rand()%10);  //���������� � ������ 
	}
	lstTest2.sort();
	lstTest.merge(lstTest2); //������� 
	ptrLst = lstTest.begin();
	while (ptrLst != lstTest.end())
	{
		cout << *ptrLst << " ";
		++ptrLst;
	}
}

