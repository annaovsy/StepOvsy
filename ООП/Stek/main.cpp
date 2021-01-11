#include "stack.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	Steck stack;

	int a;
	while(!stack.IsFull())
	{
		a = rand() % 4 + 2;
		stack.Push(a);
	}
	
	while(a = stack.Pop())
	{
		cout << a << "  ";
	}
	cout << endl;
	



}
