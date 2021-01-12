#include "queue.h"
#include <iostream>
using namespace std;

int main()
{
	Game game(3);
	cout << game << endl;

	game.StartGame();

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