#include "Class.h"

int Class::getOddRankAndReverse(int a)
{
	int b = 0;
	for (; a != 0; a /= 100)
		b = b * 10 + (a % 10);
	return b;
}

int Class::getEvenRankWithMaxEvenValue(int a)
{
	int maxR = 0;
	int maxValue = 0;
	a = a / 10;
	for (int r = a;
		a != 0;
		a /= 100,
		r += 2) {
		int value = a % 10;
		if (value % 2 == 0 && maxValue < value) {
			maxR = r;
			maxValue = value;
		}
	}
	return maxR;
}

int Class::getCycleRightShiftNumber(int a, int shift) {
	int highDigit = 1;
	// Подсчет кол-ва разрядов
	while (a / (highDigit * 10))
		highDigit *= 10;

	// Сдвиг числа
	for (int i = 0;
		i < shift;
		i++) {
		int temp = a % 10;
		a = a / 10 + highDigit * temp;
	}

	return a;
}

double Class::sumEvenNumbers(double** A, int size)
{
	double sumA = 0;
	for (int i = 0;
		i < size;
		i++)
		for (int j = 0;
			j < size - i - 1;
			j++)
			if ((int)A[i][j] % 2 == 0)
				sumA += A[i][j];
	return sumA;
}