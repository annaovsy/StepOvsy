#include "ListTemplate.h"
#include <iostream>
using namespace std;

//template<class T>
void ListTemplate::Push(int val)
{
	Node* temp = new Node;
	temp->value = val;
	temp->prev = nullptr;
	if (!head)
	{
		temp->next = nullptr;
		head = tail = temp;
	}
	else
	{

	}


}



