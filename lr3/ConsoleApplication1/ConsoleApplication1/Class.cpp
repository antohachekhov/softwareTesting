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