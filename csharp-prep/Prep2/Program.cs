using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string GradeInput = Console.ReadLine();
        int GradePercent = int.Parse(GradeInput);
        String LetterGrade = "";

        // This if tree will change you percentage grade into a letter grade
        // A >= 90 - B >= 80 - C >= 70 -  >= 60 - F < 60
        if (GradePercent >= 90) {
            if (GradePercent % 10 < 3) {
                LetterGrade = "A-";
        
            } else {
                LetterGrade = "A";
        
            }

        } else if (GradePercent >= 80){
            if (GradePercent % 10 >= 7) {
                LetterGrade = "B+";

            } else if (GradePercent % 10 < 3) {
                LetterGrade = "B-";
            
            } else {
                LetterGrade = "B";

            }

        } else if (GradePercent >= 70) {
            if (GradePercent % 10 >= 7) {
                LetterGrade = "C+";

            } else if (GradePercent % 10 < 3) {
                LetterGrade = "C-";
            
            } else {
                LetterGrade = "C";

            }

        } else if (GradePercent >= 60) {
            if (GradePercent % 10 >= 7) {
                LetterGrade = "D+";

            } else if (GradePercent % 10 < 3) {
                LetterGrade = "D-";
            
            } else {
                LetterGrade = "D";

            }

        } else if (GradePercent < 60) {
            if (GradePercent % 10 >= 7) {
                LetterGrade = "E+";

            } else if (GradePercent % 10 < 3) {
                LetterGrade = "E-";
            
            } else {
                LetterGrade = "E";

            }
        }    

        // Determains if you failed or passed the class based on if grade is > 70
        if (GradePercent >= 70) {
            Console.WriteLine($"You passed the class with a {LetterGrade}!");
        } else {
            Console.WriteLine($"You did not pass the class, your grade was {LetterGrade}");

        }
    }
}