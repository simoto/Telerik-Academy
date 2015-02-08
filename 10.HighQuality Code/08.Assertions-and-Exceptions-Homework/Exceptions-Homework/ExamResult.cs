using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grades can't be negative number!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("minGrade must be positive or equals to 0!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("maxGrade must be bigger than minGrade!");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentException("Comments can't be empty!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
