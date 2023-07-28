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
This application was created mainly with C#, and its primary purpose is to serve as a site to store and access information on vendors and orders for a business. Two custom classes were created for this project: Vendor and Order. The vendor class has a constructor that stores the name and description of a vendor (inputted as strings) into two seperate properites, creates a unique Id property that is generated on its relation to a static field IdCounter that goes up by 1 every time a new instance of the class is made, and also adds the Vendor object into a static list of Vendor objects. The class also has methods to add Order objects to a specific Vendor, find a specific vendor, retrieve a list of all the vendors, and delete a vendor. The Order class has a constructor with properties for the name of the order, a description, the price/cost of the order, the date the order was made, and a unique Id that is created in the same way as the Vendor class does it.

The home page for the site (routed to "/") takes you Index.cshtml in the Home View directory. From there, the page links the user to either the index page for Vendors (which displays a list of all Vendors) or to a form page to create a new Vendor (with the route "/vendors/new"). When the user fills out the form, the information is posted and redirected back to the Vendor page, which repopulates the page with a list of all the vendor's names as anchor tags. A specific Vendor can be clicked to route the user to a page to see more specific information on a vendor, with links to create a new order for that vendor or edit a vendor's information, and a button to delete the Vendor entirely (if submitted). Creating an order routes the user to a form page where information entered can be posted to create a new order object. Created orders are listed under a specific Vendor's page as anchor tags for their names. These can be clicked to get to a page that reveals all details for a specified object. 

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
