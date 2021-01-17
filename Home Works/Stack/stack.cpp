#include "stack.h"
#include <iostream>
using namespace std;

Stack::Stack(char* _stack, int _top) : stack(new char[top])
{
	strcpy(stack, _stack);
}

void Stack::Push(char ch)
{
	if (!IsFull())
		stack[++top] = ch;
}

char Stack::Pop()
{
	if (!IsEmpty())
		return stack[top--];
	else
		return 0;
}

void Stack::Clear()
{
	top = Empty;
}

bool Stack::IsEmpty()
{
	return top == Empty;
}

bool Stack::IsFull()
{
	return top == Full;
}

int Stack::GetCount()
{
	return top + 1;
}

Stack::~Stack()
{
	if (stack)
		delete[]stack;
}
