#include "queue.h"
#include <iostream>
using namespace std;

int main()
{
	Queue queue;
	
	while (!queue.IsFull())
	{
		queue.Push(rand() % 10 + 1, rand() % 3 + 1, rand() % 9 + 8, rand() % 60);
	}

	cout << queue;
	cout << "--------------------" << endl;

	int c = 0;
	int p = 0;
	while (queue.Pop(c, p))
	{
		cout << c << " [ " << p << " ] " << endl;
	}



}