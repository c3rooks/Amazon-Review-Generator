# Amazon Product Review Generator

This ASP.NET Core application automatically generates Amazon product reviews based on training data.

## Project Structure

- `CoreysAssessmentAPI`: Contains the main ASP.NET Core application.
- `CoreysAssessmentTests`: Holds the test suite for your application.
- `CoreysAssessmentWeb`: Includes the web application part of your project.
- `CoreysAssessmentSolution.sln`: The solution file that ties everything together.

## Requirements

- .NET Core SDK [Download](https://dotnet.microsoft.com/download)
- Training data from [UCSD's Amazon product data](http://jmcauley.ucsd.edu/data/amazon/)

## Getting Started

1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/CoreysAssessment.git
Navigate to the solution directory
cd CoreysAssessment

## Running the API
Go to the CoreysAssessmentAPI directory:
```bash
cd CoreysAssessmentAPI

Build and run the application:
```bash
dotnet build
```bash
dotnet run
The API will be accessible at http://localhost:5000. 
You can use tools like curl or Postman to interact with the "generate" endpoint.

## Running Tests
Go to the CoreysAssessmentTests directory:
```bash
cd CoreysAssessmentTests
Run the tests:
```bash
dotnet test

## Running the Web Application
Go to the CoreysAssessmentWeb directory:
```bash
cd CoreysAssessmentWeb
Build and run the web application:
```bash
dotnet build
```bash
dotnet run
The web application will be available at http://localhost:5001


