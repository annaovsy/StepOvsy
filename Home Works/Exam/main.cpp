#include "FinancialManagementSystem.h"
#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus"); 
	//cout<<"\n\t����������, �������� �����\n"
	DebitCard card;
	while (true)
	{
		Menu();
		int choice;
		cin >> choice;
		if (choice == 1)
		{
			cout << "����� ����� �� ����� : " << card.sumTotal << endl;
		}
		else if (choice == 2)
		{
			card.SetRefill();
		}
		else if (choice == 3)
		{
			card.SetExpenses();
		}
		else if (choice == 4)
		{
			card.ExpenseReportFile("Top.txt");
		}
		else if (choice == 5)
		{
			cout << "**********************************************************" << endl;
			cout << "\t���������� �� ����������� ��������!\n\t�� ��������!" << endl;
			return false;
		}
	}



	return 0;
}