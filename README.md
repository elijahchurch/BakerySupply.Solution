#  BakerySupply.Solution

#### By: Jason Elijah Church

#### An application where a bakery owner can create and store information about vendor's they do business with.  

## Technologies Used
* C#
* Markdown
* Git Bash
* Visual Code Studio
* CSS
* Razor
* .NET

## Description:
This application was created mainly with C#, and its primary purpose is to serve as a sight to store and access information on vendors and orders for a business. Two custom classes were created for this project: Vendor and Order. The vendor class has a constructor that stores the name and description of a vendor (inputted as strings) into two seperate properites, creates a unique Id property that is generated on its relation to a static field IdCounter that goes up by 1 every time a new instance of the class is made, and also adds the Vendor object into a static list of Vendor objects. The class also has methods to add Order objects to a specific Vendor, find a specific vendor, retrieve a list of all the vendors, and delete a vendor. The Order 


## Setup/ Installation Requirements

1. Clone this repo.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "BakerySupply".
3. In the command line, run the command "dotnet run" to compile and execute the application.
4. Optionally, you can run "dotnet build" to compile this console app without running it.
5. To run the tests for this project, navigate to this project's test directory called "BakerySupply.Tests".
6. In the command line, run the command "dotnet restore" then "dotnet test" to run all the tests that are found in the ModelTests directory.

## Known Bugs

No bugs that I have noticed. I do not store the Orders in their own static class list, and am not sure if this affects the data on any one page.

## License

MIT License

Copyright (c) (2023) Jason Elijah Church

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
