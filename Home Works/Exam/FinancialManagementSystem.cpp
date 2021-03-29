#include "FinancialManagementSystem.h"
#include <iostream>
#include <fstream>
using namespace std;

//int ChoiceCards()
//{
//	Card* ptrCard;
//	DebitCard cardD;
//	CreditCard cardC;
//	cout << "\n\tПожалуйста, выберите карту\n\t1 - Дебетовая | 2 - Кредитная\n\t";
//	int choiceCard;
//	cin >> choiceCard;
//	while (true)
//	{
//		if (choiceCard == 1)
//			ptrCard = &cardD;
//		
//		else if(choiceCard == 2)
//			ptrCard = &cardC;
//
//		ptrCard->Menu();
//		int choice;
//		cin >> choice;
//		if (choice == 1)
//		{
//			cout << "Общая сумма на карте : " << ptrCard->sumTotal << endl;
//		}
//		else if (choice == 2)
//		{
//			ptrCard->SetRefill();
//		}
//		else if (choice == 3)
//		{
//			ptrCard->SetExpenses();
//		}
//		else if (choice == 4)
//		{
//			ptrCard->ExpenseReportFile("Top.txt");
//		}
//		else if (choice == 5)
//		{
//			cout << "**********************************************************" << endl;
//			cout << "\tБлагодарим за пользование сервисом!\n\tДо свидания!" << endl;
//			return false;
//		}
//	}
//}

void Menu()
{
	cout << "\n*****************************************" << endl;
	cout << "*\tВыберите действие:\t\t*" << endl;
	cout << "*  Общая сумма на карте		   - 1\t*" << endl;
	cout << "*  Пополнение средств		   - 2\t*" << endl;
	cout << "*  Внесение затрат		   - 3\t*" << endl;
	cout << "*  Просмотр рейтинга/запись в файл - 4\t*" << endl;
	cout << "*  Выход			   - 5\t*" << endl;
	cout << "*****************************************" << endl << endl;
}

int Debit()
{
	DebitCard card;
	Menu();
	while (true)
	{	
		int choice;
		cin >> choice;
		if (choice == 1)
		{
			cout << "Общая сумма на карте : " << card.sumTotal << endl;
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
			cout << "\tБлагодарим за пользование сервисом!\n\tДо свидания!" << endl;
			return false;
		}
		cout << " ------------------------------" << endl;
		cout << " * Выберите другое действие : *" << endl;
	}
}

int Credit()
{
	CreditCard card;
	Menu();
	while (true)
	{
		int choice;
		cin >> choice;
		if (choice == 1)
		{
			cout << "Общая сумма на карте : " << card.sumTotal << endl;
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
			cout << "\tБлагодарим за пользование сервисом!\n\tДо свидания!" << endl;
			return false;
		}
		cout << " ------------------------------" << endl;
		cout << " * Выберите другое действие : *" << endl;
	}
}

void ChoiceCard()
{
	cout << "\n\tПожалуйста, выберите карту\n\t1 - Дебетовая | 2 - Кредитная\n\t";
	int choiceCard;
	cin >> choiceCard;
	switch (choiceCard)
	{
	case 1:
		Debit();
		break;
	case 2:
		Credit();
		break;
	}
}

DebitCard::DebitCard(int _sumTotal):
	sumTotal(_sumTotal),
	productCategory(0),
	entertainmentCategory(0),
	travelCategory(0)
{}

void DebitCard::SetRefill()
{
	int refill;
	cout << "Введите сумму: " << endl;
	cin >> refill;
	sumTotal += refill;
	cout << "Операция выполнена успешно!" << endl;
	cout << "Общая сумма на карте : " << sumTotal << endl;
}

void DebitCard::SetExpenses()
{
	int expenses, category;	
	cout << "Введите сумму: " << endl;
	cin >> expenses;
	if (expenses >= sumTotal)
	{
		cout << "\tОперация не может быть выполнена!!!\n\tСумма снятия превышает остаток на карте!\n";
	}
	else
	{
		int min = 1000;
		int max = 0;
		cout << "Введите категорию: 1 - Продукты | 2 - Развлечения | 3 - Путешествия" << endl;
		cin >> category;
		switch (category)
		{
		case 1:
			productCategory += expenses;
			break;
		case 2:
			entertainmentCategory += expenses;
			break;
		case 3:
			travelCategory += expenses;
			break;
		default:
			break;
		}
		
		sumTotal -= expenses;
		cout << "Операция выполнена успешно!" << endl;
		cout << "Общая сумма на карте : " << sumTotal << endl;
	}	
}

bool DebitCard::ExpenseReportFile(const char* filename)
{
	string first, second, third;
	if (productCategory > entertainmentCategory && productCategory > travelCategory)
	{
		first = "Продукты";
		if (entertainmentCategory > travelCategory)
		{
			second = "Развлечения";
			third = "Путешествия";
		}
		else
		{
			second = "Путешествия";
			third = "Развлечения";
		}			
	}
	else if (entertainmentCategory > productCategory && entertainmentCategory > travelCategory)
	{
		first = "Развлечения";
		if (productCategory > travelCategory)
		{
			second = "Продукты";
			third = "Путешествия";
		}
		else
		{
			second = "Путешествия";
			third = "Продукты";
		}
	}
	else if (travelCategory > productCategory && travelCategory > entertainmentCategory)
	{
		first = "Путешествия";
		if (productCategory > entertainmentCategory)
		{
			second = "Продукты";
			third = "Развлечения";
		}
		else
		{
			second = "Развлечения";
			third = "Продукты";
		}
	}
	
	cout << "Топ 3 затрат по категорям:" << endl;
	cout << "1. " << first << endl;
	cout << "2. " << second << endl;
	cout << "3. " << third << endl;

	ofstream fileOut(filename, ios::out); //вывод в файл
	if (!fileOut.is_open())
		return false;
	fileOut << "Топ 3 затрат по категорям:" << endl;
	fileOut << "1. " << first<< endl;
	fileOut << "2. " << second << endl;
	fileOut << "3. " << third << endl;
	fileOut.close();
	return true;
}

//void DebitCard::Menu()
//{
//	cout << "\n*****************************************" << endl;
//	cout << "*\tВыберите действие:\t\t*" << endl;
//	cout << "*  Общая сумма на карте		   - 1\t*" << endl;
//	cout << "*  Пополнение средств		   - 2\t*" << endl;
//	cout << "*  Внесение затрат		   - 3\t*" << endl;
//	cout << "*  Просмотр рейтинга/запись в файл - 4\t*" << endl;
//	cout << "*  Выход			   - 5\t*" << endl;
//	cout << "*****************************************" << endl << endl;
//}

CreditCard::CreditCard(int _sumTotal, int _interestRate) :
	DebitCard(_sumTotal), 
	interestRate(_interestRate)
{}

//void CreditCard::Menu()
//{
//	cout << "\n\tВаш кредитный лемит составляет " << sumTotal << endl;
//	cout << "\n*****************************************" << endl;
//	cout << "*\tВыберите действие:\t\t*" << endl;
//	cout << "*  Общая сумма на карте		   - 1\t*" << endl;
//	cout << "*  Пополнение средств		   - 2\t*" << endl;
//	cout << "*  Внесение затрат		   - 3\t*" << endl;
//	cout << "*  Просмотр рейтинга/запись в файл - 4\t*" << endl;
//	cout << "*  Выход			   - 5\t*" << endl;
//	cout << "*****************************************" << endl << endl;
//}
