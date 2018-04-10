using System;
class calc_result
{
    static void calculate()
    {
        int maths, sc, eng, total;
        string grade;
        float avg;
        Console.Write("Enter marks in Maths:");
        maths = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks in Science:");
        sc = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks in English:");
        eng = Convert.ToInt32(Console.ReadLine());

        total = sc + eng + maths;
        avg = total / 3;
        if (avg >= 80)
            grade = "A";
        else
            if (avg >= 60)
                grade = "B";
            else
                if (avg >= 40)
                    grade = "C";
                else
                    grade = "FAIL";

        Console.WriteLine("**********RESULTSHEET**************");
        Console.WriteLine("MATHS\t ENGLISH\t SCIENCE");
        Console.Write("{0}\t{1}\t{2}\n", maths, eng, sc);
        Console.WriteLine("Total:{0}", total);
        Console.WriteLine("Average:{0}", avg);
        Console.WriteLine("Grade:{0}", grade);
    }

    static void Main()
    {
        calculate();
    }

}