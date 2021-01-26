#include "list.h"
#include <iostream>
using namespace std;

int main()
{
	StackList list;

	for (int i = 0; i < 5; i++)
	{
		list.PushS(i);
	}
	list.PrintList();



	
}