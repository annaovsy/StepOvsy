#include "stack.h"

Steck::Steck()
{
	top = Empty;
}

void Steck::Push(char c)
{
	if (!IsFull())
		st[++top] = c;
}

char Steck::Pop()
{
	if (!-IsEmpty())
		return st[top--];

	else 
		return 0;
}

void Steck::Clear()
{
	top = Empty;
}

bool Steck::IsEmpty()
{
	// стек пуст?
	return top == Empty;
}

bool Steck::IsFull()
{
	return top == Full;
}

int Steck::GetCount()
{
	return top + 1;
}
