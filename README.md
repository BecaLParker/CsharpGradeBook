# CsharpGradeBook

Console application I built whilst learning the fundamentals of C#  


## Requirements
>*"We need an electronic grade book to read the scores of an individual student and then compute some simple statistics from the scores.*  
>*The grades are entered as floating point numbers from 0 to 100, and the statistics should show us the highest grade, the lowest grade, and the average grade."*  
~
The Project Manager

## Setup
1. Clone this repository `git clone https://github.com/BecaLParker/CsharpGradeBook.git`
2. Navigate to the GradeBook directory `cd src/GradeBook/`

## What does this code do? (user instructions and example outputs)

### Returns the average grade to one decimal place
- Type `dotnet run`  
> `Average = 17.9`

### Returns average letter grade
- Type `dotnet run`
> `Average Letter grade = B`

### Returns the highest grade to one decimal place
- Type `dotnet run`  
> `Highest grade = 56.1`

### Returns the lowest grade to one decimal place
- Type `dotnet run`  
> `Lowest grade = 4.1`

## Testing (xUnit)
- Navigate to the testing project `cd ../../GradeBook/test/GradeBook.Tests`  
- Type `dotnet test`

## Credits
[C# Fundamentals by Scott Allen](https://app.pluralsight.com/library/courses/csharp-fundamentals-dev/table-of-contents)
