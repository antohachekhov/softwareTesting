#include "pch.h"
#include "CppUnitTest.h"
#include "../ConsoleApplication1/Class.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(getOddRankAndReverseAIsZero_Test_C2)
		{
			//arrange
			int a = 0;
			int expected = 0;

			// act
			int result = Class::getOddRankAndReverse(a);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getOddRankAndReverseAIsNotZero_Test_C2)
		{
			//arrange
			int a = 1;
			int expected = 1;

			// act
			int result = Class::getOddRankAndReverse(a);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getEvenRankWithMaxEvenValueAIsZero_Test_C2)
		{
			//arrange
			int a = 0;
			int expected = 0;

			// act
			int result = Class::getEvenRankWithMaxEvenValue(a);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getEvenRankWithMaxEvenValueAIsNotZeroWithoutEvenValues_Test_C2)
		{
			//arrange
			int a = 10;
			int expected = 0;

			// act
			int result = Class::getEvenRankWithMaxEvenValue(a);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getEvenRankWithMaxEvenValueAIsNotZeroWithEvenValue_Test_C2)
		{
			//arrange
			int a = 20;
			int expected = 2;

			// act
			int result = Class::getEvenRankWithMaxEvenValue(a);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getCycleRightShiftTwoDigitNumberWithZeroShirt_Test_C2) {
			//arrange
			int a = 12;
			int shift = 0;
			int expected = 12;

			// act
			int result = Class::getCycleRightShiftNumber(a, shift);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getCycleRightShiftTwoDigitNumberWithOneShirt_Test_C2) {
			//arrange
			int a = 12;
			int shift = 1;
			int expected = 21;

			// act
			int result = Class::getCycleRightShiftNumber(a, shift);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getCycleRightShiftOneDigitNumberWithZeroShirt_Test_C2) {
			//arrange
			int a = 9;
			int shift = 0;
			int expected = 9;

			// act
			int result = Class::getCycleRightShiftNumber(a, shift);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getCycleRightShiftOneDigitNumberWithOneShirt_Test_C2) {
			//arrange
			int a = 9;
			int shift = 1;
			int expected = 9;

			// act
			int result = Class::getCycleRightShiftNumber(a, shift);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(sumEvenNumbers_Test_C2_0) {
			//arrange
			double expected = 0;
			double** M = new double*[0];

			// act
			double result = Class::sumEvenNumbers(M, 0);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(sumEvenNumbers_Test_C2_1) {
			//arrange
			double expected = 0;

			int size = 1;
			double** M = new double* [size];
			for (int i = 0; i < size; i++) {
				M[i] = new double[size];
				for (int j = 0; j < size; j++)
					M[i][j] = 1;
			}

			// act
			double result = Class::sumEvenNumbers(M, size);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(sumEvenNumbers_Test_C2_21) {
			//arrange
			double expected = 0;
			int size = 2;
			double** M = new double* [size];
			for (int i = 0; i < size; i++) {
				M[i] = new double[size];
				for (int j = 0; j < size; j++)
					M[i][j] = 1;
			}

			// act
			double result = Class::sumEvenNumbers(M, size);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(sumEvenNumbers_Test_C2_22) {
			//arrange
			double expected = 2;

			int size = 2;
			double** M = new double* [size];
			for (int i = 0; i < size; i++) {
				M[i] = new double[size];
				for (int j = 0; j < size; j++)
					M[i][j] = 2;
			}

			// act
			double result = Class::sumEvenNumbers(M, size);

			// assert
			Assert::AreEqual(expected, result);
		}
	};
}
