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

### Asks user for grades to enter into a gradebook
Type `dotnet run --project .\src\GradeBook\GradeBook.csproj`
> Enter a grade or q to exit 

Type a grade value EG: `95`

### Returns gradebook statisitics to one decimal place
After you've entered some grades, type `q` to see the stats of your gradebook. EG: 
> Average = 33.3
Highest grade = 50.0
Lowest grade = 20.0
Average Letter grade = D



## Testing (xUnit)
- Navigate to the testing project `cd ../../GradeBook/test/GradeBook.Tests`  
- Type `dotnet test`

## Credits
[C# Fundamentals by Scott Allen](https://app.pluralsight.com/library/courses/csharp-fundamentals-dev/table-of-contents)
