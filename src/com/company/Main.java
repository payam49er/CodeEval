package com.company;

//Solution to https://www.codeeval.com/open_challenges/4/
//Write a program to determine the sum of the first 1000 prime numbers.


public class Main {

    private static boolean IsItPrime(int number)
    {
        for(int i=2;i<number;i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    public static long GetTheSumOfPrimes()
    {
        int counter = 0;
        long sum = 0;
        int number = 2;
        while (counter < 1000)
        {
            if (IsItPrime(number))
            {
                counter++;
                sum = sum + number;
            }
            number++;
        }

        return sum;

    }

    public static void main(String[] args) {

        long result = GetTheSumOfPrimes();
        System.out.print(result);
    }
}
