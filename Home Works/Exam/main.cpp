#include "FinancialManagementSystem.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");

	DebitCard card;
	card.Show();

	card.SetExpenses();
	card.SetRefill();
	card.SetExpenses();

	card.Show();




	return 0;
}