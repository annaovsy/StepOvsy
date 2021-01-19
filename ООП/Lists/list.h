#pragma once
#include <iostream>
using namespace std;

template<typename T> //� ������� ������� ������� ���������
struct Node
{
	T data;	//����������
	Node* Next;	//��������� �� ����. ������� ������
};
template<class T>
class List
{
private:
	Node<T>* head;	//��������� �� ������ ����
	Node<T>* tail; // �� ��������� ����
	int count;	//���������� ��������� � ������

	Node<T>* CreateNode(int);

public:
	List(); //����������� ������� ������ ������ 
	void AddToHead(int);
	void AddToTail(int);
	void RemoveFromHead();
	void RemoveFromTail();

	void AddToIndex(int, int); //���������� �� �������
	void RemoveByIndex(int); //������� �� �������

	void PrintList();

	//~List();

};
