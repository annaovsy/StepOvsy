#include "stack.h"
#include <iostream>
using namespace std;

int main()
{
	Stack stack("[]56][]", 9);

	char a;
	while (!stack.IsFull())
	{
		stack.Push(a);
	}
	while (a = stack.Pop())
	{
		cout << a << " ";
	}
	cout << endl;







}