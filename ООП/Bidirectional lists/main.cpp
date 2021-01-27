#include "BidirectionalLists.h"
#include <iostream>
using namespace std;

int main()
{
	BidirectionalList list;
	for (int i = 0; i < 5; i++)
	{
		list.AddToHead(i);
	}
	cout << list << endl;

	cout << list[4]->value << endl;

	//BidirectionalList list2(list);
	//cout << list2 << endl;
}
