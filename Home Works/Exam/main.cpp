#include "FinancialManagementSystem.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus"); 

	DebitCard card;
	card.Show();

	
	card.SetRefill();
	card.SetExpenses();
	card.SetExpenses();
	card.SetExpenses();
	//card.Show();
	card.ExpenseReportFile("Top.txt");




	return 0;
}