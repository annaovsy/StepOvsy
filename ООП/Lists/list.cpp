#include "list.h"
#include <iostream>
using namespace std;

template<typename T>
Node<T>* List<T>::CreateNode(int value)
{
	//создали новый узел
	Node<T>* newNode = new Node<T>; //Выделяем память под новый узел
	newNode->data = value;
	newNode->Next = NULL;	//ссылка на следующий узел пока NULL
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
	// 0. создали новый узел
	Node<T>* newNode = CreateNode(value);

	// 1. Если список пуст
	if (head == NULL)
	{
		head = tail = newNode;
		return;
	}

	// 2. Прописываем ссылку на след. элемент
	newNode->Next = head;

	// 3. не теряем голову!!!
	head = newNode;
}

template<typename T>
void List<T>::AddToTail(int value)
{
	// 0. создали новый узел
	Node<T>* newNode = CreateNode(value);

	// 1. Если список пуст
	if (head == NULL)
	{
		head = tail = newNode;
		return;
	}

	// 2. Прописываем ссылку на след. элемент
	tail->Next = newNode;

	// 3. не теряем хвост
	tail = newNode;
}

template<typename T>
void List<T>::RemoveFromHead()
{
	count--;

	// если список из одного элемента
	if (head == tail)
	{
		delete head; //отчищаем память
		tail = head = NULL;
		cout << "OK" << endl;
		return;
	}

	Node<T>* temp = head; //сохраняем голову
	head = head->Next;
	delete temp;	//отчищаем память
}

template<typename T>
void List<T>::RemoveFromTail()
{
	count--;

	// если список из одного элемента
	if (head == tail)
	{
		delete tail;
		tail = head = NULL;
		cout << "OK" << endl;
		return;
	}

	// ищем предпоследний элемент списка
	Node<T>* prev = head;
	while (prev->Next != tail)
	{
		prev = prev->Next; //шаг на следующий элемент
	}
	prev->Next = NULL;
	// удаляем последний (чистим память)
	delete tail;
	 // не теряем хвост!!!
	tail = prev;
}

template<typename T>
void List<T>::AddToIndex(int value, int index)
{
	if (index <= 0)	//то добавляем в голову
	{
		AddToHead(value);
		return;
	}

	if (index >= count) //то добавляем в хвост
	{
		AddToTail(value);
		return;
	}

	// если добавление в середину, то 
	// 0. создали новый узел
	Node<T>* newNode = CreateNode(value);

	// 1. ищем предыдущий элемент
	Node<T>* prev = head;
	for (int i = 0; i < index - 1; i++)
	{
		prev = prev->Next;
	}
	// 2. Сохраняем ссылку на след элемент
	newNode->Next = prev->Next;
	// 3. Добавляем узел в цепочку
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

	//находим предыдущий элемент
	Node<T>* prev = head;
	for (int i = 0; i < index - 1; i++)
	{
		prev = prev->Next;
	}
	// сохраняем ссылку на след. элемент, который будем удалять
	Node<T>* deletedNode = prev->Next;
	// перекидываем ссылку на элемент, который идет после удаляемого
	prev->Next = deletedNode->Next;
	delete deletedNode; //удаляем элемент
}

template<typename T>
void List<T>::PrintList()
{
	Node<T>* temp = head;
	//  1 способ
	//for (int i = 0; i < count; i++)
	//{
	//	cout << temp->data << "\t";
	//	temp = temp->Next;	//двигаем указатель темп, а !!не!! голову
	//}

	// 2 способ
	while (temp != NULL)
	{
		cout << temp->data << "\t";
		temp = temp->Next;	//двигаем указатель темп, а !!не!! голову
	}
	cout << endl;
}
