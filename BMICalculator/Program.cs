using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculate your body mass index and get recommendations");

        Console.Write("Enter your weight in kilograms: ");
        float weight = Convert.ToSingle(Console.ReadLine());
        if (weight < 0)
            Console.WriteLine("Weight must not be negative!");
        
        Console.Write("Enter your height in meters: ");
        float height = Convert.ToSingle(Console.ReadLine());

        if (height < 0)
            Console.WriteLine("Height must not be negative!");

        else
        {

            float BMI = weight / (height * height);
            if (BMI >= 25)
            {

                float minimumweightreccomentadion = 18.5F * height * height;
                float maximumweightreccomendation = 24.9F * height * height;
                float reccomendationanswer = weight - minimumweightreccomentadion;
                float reccomendationanswer1 = weight - maximumweightreccomendation;
                Console.WriteLine($"Your BMI = {BMI}, which means that you belong to the category of obesity.\nYou need to lose {reccomendationanswer1}-{reccomendationanswer} kg.\nWish you good luck!");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine($"Your BMI = {BMI}, which means you have a normal weight. congratulations!");
            }
            else if (BMI < 18.5)
            {

                float minimumweightreccomentadion = 18.5f * height * height;
                float maximumweightreccomendation = 24.9F * height * height;
                float reccomendationanswer = minimumweightreccomentadion - weight;
                float reccomendationanswer1 = maximumweightreccomendation - weight;
                Console.WriteLine($"Your BMI = {BMI}, which means that you belong to the category of  acute weight loss.\n You need to gain {reccomendationanswer}-{reccomendationanswer1}. good luck!");

            }
        }
        
    }

}