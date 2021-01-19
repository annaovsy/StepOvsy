#include "list.h"
#include <iostream>
using namespace std;

template<typename T>
Node<T>* List<T>::CreateNode(int value)
{
	//������� ����� ����
	Node<T>* newNode = new Node<T>; //�������� ������ ��� ����� ����
	newNode->data = value;
	newNode->Next = NULL;	//������ �� ��������� ���� ���� NULL
	count++;
	return newNode;
}

template<typename T>
List<T>::List():
	count(0), head(NULL), tail(NULL)
{}

template<typename T>
void List<T>::AddToHead(int value)
{
	// 0. ������� ����� ����
	Node<T>* newNode = CreateNode(value);

	// 1. ���� ������ ����
	if (head == NULL)
	{
		head = tail = newNode;
		return;
	}

	// 2. ����������� ������ �� ����. �������
	newNode->Next = head;

	// 3. �� ������ ������!!!
	head = newNode;
}

template<typename T>
void List<T>::AddToTail(int value)
{
	// 0. ������� ����� ����
	Node<T>* newNode = CreateNode(value);

	// 1. ���� ������ ����
	if (head == NULL)
	{
		head = tail = newNode;
		return;
	}

	// 2. ����������� ������ �� ����. �������
	tail->Next = newNode;

	// 3. �� ������ �����
	tail = newNode;
}

template<typename T>
void List<T>::RemoveFromHead()
{
	count--;

	// ���� ������ �� ������ ��������
	if (head == tail)
	{
		delete head; //�������� ������
		tail = head = NULL;
		cout << "OK" << endl;
		return;
	}

	Node<T>* temp = head; //��������� ������
	head = head->Next;
	delete temp;	//�������� ������
}

template<typename T>
void List<T>::RemoveFromTail()
{
	count--;

	// ���� ������ �� ������ ��������
	if (head == tail)
	{
		delete tail;
		tail = head = NULL;
		cout << "OK" << endl;
		return;
	}

	// ���� ������������� ������� ������
	Node<T>* prev = head;
	while (prev->Next != tail)
	{
		prev = prev->Next; //��� �� ��������� �������
	}
	prev->Next = NULL;
	// ������� ��������� (������ ������)
	delete tail;
	 // �� ������ �����!!!
	tail = prev;
}

template<typename T>
void List<T>::AddToIndex(int value, int index)
{
	if (index <= 0)	//�� ��������� � ������
	{
		AddToHead(value);
		return;
	}

	if (index >= count) //�� ��������� � �����
	{
		AddToTail(value);
		return;
	}

	// ���� ���������� � ��������, �� 
	// 0. ������� ����� ����
	Node<T>* newNode = CreateNode(value);

	// 1. ���� ���������� �������
	Node<T>* prev = head;
	for (int i = 0; i < index - 1; i++)
	{
		prev = prev->Next;
	}
	// 2. ��������� ������ �� ���� �������
	newNode->Next = prev->Next;
	// 3. ��������� ���� � �������
	prev->Next = newNode;
}

template<typename T>
void List<T>::RemoveByIndex(int index)
{
	if (index <= 0)
	{
		RemoveFromHead();
		return;
	}

	if (index >= count)
	{
		RemoveFromTail();
		return;
	}

	//������� ���������� �������
	Node<T>* prev = head;
	for (int i = 0; i < index - 1; i++)
	{
		prev = prev->Next;
	}
	// ��������� ������ �� ����. �������, ������� ����� �������
	Node<T>* deletedNode = prev->Next;
	// ������������ ������ �� �������, ������� ���� ����� ����������
	prev->Next = deletedNode->Next;
	delete deletedNode; //������� �������
}

template<typename T>
void List<T>::PrintList()
{
	Node<T>* temp = head;
	//  1 ������
	//for (int i = 0; i < count; i++)
	//{
	//	cout << temp->data << "\t";
	//	temp = temp->Next;	//������� ��������� ����, � !!��!! ������
	//}

	// 2 ������
	while (temp != NULL)
	{
		cout << temp->data << "\t";
		temp = temp->Next;	//������� ��������� ����, � !!��!! ������
	}
	cout << endl;
}
