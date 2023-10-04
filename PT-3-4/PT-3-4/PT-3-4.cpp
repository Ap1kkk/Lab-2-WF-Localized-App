#include <iostream>
#include <fstream>
#include <string>

using namespace std;

bool is_number(string str)
{
	for(auto symbol : str)
	{
		if (!isdigit(symbol))
			return false;
	}
	return true;
}

void alert_if_not_number(string str)
{
	if (!is_number(str))
	{
		cout << "Incorrect input given!\n";
		exit(0);
	}
}

int main()
{
	ifstream fin("input.txt");

	string inputString;
	int elementsAmount;
	
	fin >> inputString;
	alert_if_not_number(inputString);
	elementsAmount = atoi(inputString.c_str());
	cout << elementsAmount;

	for (size_t i = 0; i < elementsAmount; i++)
	{
		int treeElement;
		fin >> inputString;
		alert_if_not_number(inputString);
		treeElement = atoi(inputString.c_str());
		// TODO добавление в дерево
	}
}