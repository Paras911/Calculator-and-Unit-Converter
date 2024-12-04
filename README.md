This is a Windows Forms application built in C# that provides two main functionalities: a basic calculator and a unit converter.

Features:
1. Calculator
Perform basic arithmetic operations:
Addition (+)
Subtraction (-)
Multiplication (*)
Division (/)
User-friendly numeric buttons for input.
A "Clear" button to reset the current operation.
2. Unit Converter
Dollar to INR Conversion
Converts a user-specified amount in US Dollars to Indian Rupees.
Default conversion rate: 1 USD = 84.73 INR (hardcoded for demonstration purposes).
Displays results rounded to two decimal places.
Miles to Kilometers Conversion
Converts a user-specified distance in miles to kilometers.
Conversion formula: 1 mile = 1.60934 kilometers.
Displays results rounded to two decimal places.
How to Use

Calculator:

Click the numeric buttons (0-9) to input numbers.
Choose an arithmetic operation (+, -, *, /).
Enter the second number and press = to see the result.
Press the "Clear" button to reset the calculator.
Unit Converter:

Dollar to INR:

Enter the amount in dollars in the input box.
Press the "Convert" button to see the equivalent amount in Indian Rupees.
Miles to Kilometers:
Enter the distance in miles in the input box.
Press the "Convert" button to see the equivalent distance in kilometers.
Requirements
Operating System: Windows
Development Environment: Visual Studio (any version that supports WinForms)
.NET Framework: 4.7.2 or later

Installation
Clone the repository:
git clone https://github.com/Paras911/Calculator-and-Unit-Converter.git
Open the solution file (.sln) in Visual Studio.
Build and run the application.

Screenshots:

![Screenshot 2024-12-04 204940](https://github.com/user-attachments/assets/aed571d7-ab2e-4689-9141-00058135e4e0)


Known Issues:

Hardcoded Conversion Rate: The currency conversion rate (Dollar to INR) is not dynamic and needs to be updated manually.
Error Handling: Non-numeric inputs may cause issues in certain scenarios.

Future Enhancements:

Add support for more currency and unit conversions.
Allow users to input custom conversion rates.
Improve error handling and user feedback.


