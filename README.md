# Name Scorer
A simple C# console application that scores the similarity between two names using Levenshtein and Jaro-Winkler algorithms

## Features
- Calculates similarity scores between two input names.
- Provides a Levenshtein distance metric or uses the FuzzySharp library for more advanced string matching.

## How to Run
1. Clone the repository to your machine
2. Navigate to the project directory
3. Run the application:

```bash
dotnet run
```

## Example
```bash
Enter the first name:
John
Enter the second name:
Jon
The similarity score between "John" and "Jon" using Jaro-Winkler is: 67%
The number of transformations between "John" and "Jon" using Levenshtein is: 1
```

