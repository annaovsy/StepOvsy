#pragma once
#include <iostream>
using namespace std;

class QueueRing
{
private:
	int* Wait;  //�������
	int MaxQueueLength;  // ������������ ������ �������
	int QueueLength;  //������� ������ �������
	int MaxQueueLength;  // ������������ ������ �������

public:
	QueueRing(int m);
	~QueueRing();

	void Push(int c); //����������
	bool Pop();	//����������
	void Clear();
	bool IsEmpty();
	bool IsFull();
	int GetCount(); //���������� ���������
	void Show();



};
