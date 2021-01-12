#pragma once
#include <iostream>
using namespace std;

class QueueRing
{
private:
	int* Wait;  //очередь
	int MaxQueueLength;  // максимальный размер очереди
	int QueueLength;  //текущий размер очереди
	int MaxQueueLength;  // максимальный размер очереди

public:
	QueueRing(int m);
	~QueueRing();

	void Push(int c); //добавление
	bool Pop();	//извлечение
	void Clear();
	bool IsEmpty();
	bool IsFull();
	int GetCount(); //количество элементов
	void Show();



};
