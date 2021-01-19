#include "list.h"
#include "list.cpp"
#include <iostream>
using namespace std;

int main()
{
	List<int> list;
	for (int i = 0; i < 5; i++)
	{
		list.AddToHead(i);
	}
	list.PrintList();

	list.AddToIndex(9, 2);
	list.PrintList();
	list.RemoveByIndex(3);
	list.PrintList();

	//for (int i = 0; i < 6; i++)
	//{
	//	list.RemoveFromTail();
	//}
	//list.PrintList();
}