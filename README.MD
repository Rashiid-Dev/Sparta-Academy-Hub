# Academy Hub Project

> Created By Abdirashiid Jama

## About

this app is a hub where potential and current Spartans can learn more about the academy and connect

## To Run

### You will need:
- [Visual Studio](https://visualstudio.microsoft.com/downloads/)



Entity Framework Core
- - [Entity Framework Core](https://www.nuget.org/packages/EntityFramework/)
- - [Entity Framework Core Sql Server](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/)
- - [Entity Framework Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/)


- [Linq](https://www.nuget.org/packages/System.Linq/)





#### and dependencies:

Material Design
- - [Material Design](https://www.nuget.org/packages/MaterialDesignThemes.MahApps/0.1.1-ci981)
- - [Material Design IconPacks](https://www.nuget.org/packages/MaterialDesign.Icons/)
- - [Material Design Themes](https://www.nuget.org/packages/MaterialDesignThemes/3.1.0-ci981)

### Getting Ready
1. Install Visual Studio 2019
2. Clone this repository
3. Open the solution and Install packages and dependencies in NuGet Package Manager

### Database
#### ERD
![ERD](https://i.imgur.com/LMeW4Sv.png)
AcademyHubContext.cs is a scaffold of this AcademyHub database for use in the app


### Running the program

5. Run the program via the debugger
6. or alternatively navigate to bin\release to run the program

## Classes and Windows

#### Class Diagram
![ERD](https://i.imgur.com/u3NE4PW.png)

#### MainWindow:
Is the main entry point of the program, presents the welcome screen and dashboard upon successfull authentication
 - WelcomeButton_Click() : Hides the welcome button, academy logo and calls Login Window
 - LoginButtonClicked() : Hides the welcome and presents the dashboard when login is succesfull
 - tickevent() : assigns the current time to a textbox
 - StartClock() : counts every second and starts the clock
 - BackButton_OnClick() : Button that takes you back to the dashboard
 - Button_Click() : Quits the application#
 - Courses_Click() : Takes you to the Courses window
 - UserInfoButton_Click : Takes you to the User Info Window
 - Academies_Click() : Takes you to the Academies screen
 - Calendar_Click() : takes you to the Calendar Window
 - People_Click() : Takes you to the Connections Window
 - 
 #### LoginWindow:
This is the login screen where users can enter their credentials to login
- LoginButton() : Read the values entered and compares them against the database. Upon succesfull login it will close the window and go to the dashboard
- RegisterButton() : Opens the register window
- CloseRegister() : Close the register window if all values are correct
- 
#### RegisterWindow:
This is the register screen where user can create an account
- RegisterButton() : Reads all the values and goes through multiple if statements to check whether they are correct, if they are the created account will be pushed to the database

#### PeopleWindow (Not fully implemented):
This is where your connections are shown
- BackToDashBoardButton() : Takes you back to the dashboard
- ShowConnections_Click() : Goes through the database and shows your connections in a list

#### AcademiesWindow (Not fully implemented)
This is where you can navigate to the academies and see courses available
- BirminghamButtonClick() : Shows the courses available at Birmingham
- LondonButtonClick_Click() : Empty

#### CalendarWindow (Not fully implemented)
this is where you can see when courses and events wil be happening

#### UserInfoWindow (Not fully implemented):
This is where you can see and edit your user information
- BackToDashBoardButton() : Takes you back to the dashboard
- EditUserInfoButton() : Presents you with an list of your information which you can edit and save

