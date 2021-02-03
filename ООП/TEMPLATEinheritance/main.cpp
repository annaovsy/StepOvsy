#include "ListTemplate.h"
#include <iostream>
using namespace std;

int main()
{
	ListTemplate* list = new Stack();
	for (int i = 0; i < 10; i++)
	{
		list->Push(i + 1);
	}

	int val;
	bool ret = list->Pop(val);
	cout << "val = " << val << endl;
	delete list;

	list = new Queue();
	for (int i = 0; i < 10; i++)
	{
		list->Push(i + 1);
	}

	int val;
	ret = list->Pop(val);
	cout << "val = " << val << endl;

}
