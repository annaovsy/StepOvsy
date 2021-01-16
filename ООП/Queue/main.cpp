#include "queue.h"
#include "QueuePr.h"
#include "deque.h"
#include <iostream>
using namespace std;

int main()
{
	Deque deque;
	cout << deque;
	/*while (!deque.IsFull())
	{
		deque.PushBack(rand() % 10);
	}*/
	while (!deque.IsFull())
	{
		deque.PushFront(rand() % 10);
	}
	cout << deque;
	deque.PopBack();
	cout << deque;
	cout << "Back : " << deque.Back() << endl;
	cout << "Size : "<<deque.Size() << endl;


	//QueuePriority queue;
	//
	//while (!queue.IsFull())
	//{
	//	queue.Push(rand() % 10, rand() % 3);
	//}

	//cout << queue;
	//cout << "------------" << endl;

	//int c = 0;
	//int p = 0;
	//while (queue.Pop(c, p))
	//{
	//	cout << c << " [ " << p << " ] " << endl;
	//}

	//Game game(3);
	//cout << game << endl;

	//game.StartGame();

	//QueueRing queueRing(10);
	//cout << queueRing;

	//while (!queueRing.IsFull())
	//	queueRing.Push(rand() % 10);

	//cout << queueRing;
	//
	//queueRing.Pop();
	//queueRing.Pop();

	//cout << queueRing;


}