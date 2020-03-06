# Academy Hub Project

> Created By Abdirashiid Jama

## About

this app is a hub where potential and current Spartans can learn more about the academy and connect

## Project Goal
To build a function app that supports user authentication, has the ability for new or potential spartans to learn more about Sparta,find out about ongoing courses and connect with other students.

## Sprints

### Sprint-1
Sprint Goal: Setup a basic database, entityframework app and wpf gui
#### Planning:
- Create a simple ERD (Done)
- Create a Jira kanban board and fill the backlog(Done)(Shared with Cathy and Nish on spartaglobal emails)
- Do some more research on Linq and Entity Framework(Done)

#### What went well and didn't
The planning went well, however as I realised later on the project scope was too large for such a limited time frame.

### Sprint-2
Sprint Goal: Setup a basic database, entityframework app,wpf gui and setup github repo and commit when ready, create a basic dashboard for a minimal viable product for standup and add a welcome screen, Login Functionality
####Database:
- Create a simple ERD (Done)
- Use that ERD to create a database via SSM (Done)
- populate the database (Done)

#### Entity Framework:
- integrate the database with entityframework (Done)

#### WPF GUI:
- Create a WPF project (Done)
- Scaffold the Database code (Done)
- Create some GUI to interact with it (Done)

#### Welcome Screen
- Add a background video
- Add sparta logo
- Add a button to take you to the dashboard

##### Dashboard:
- Very basic dashboard with little to none functionality(Done)

##### Login Functionality:
- Create Login screen(Done)
- Read data from the login screen(Not done)
- Interact with the database to check the account(Not done)

#### Github
- Create github Repo
- Push Initial Commit

#### What went well and didn't
Creating the database went well,
Creating the WPF app went well,
Creating the Welcome Screen worked
Creating the dashboard went well.
Scaffolding the databases had issues, due to me not knowing that error's prevent the database from scaffolding because they were not showing up in the error log. I had to clean the solution and rebuild for them to show.

### Sprint-3
Sprint Goal: Create a better dashboard, A login functionality, Registration, Tabs/Windows for User Info,Courses,Academies,Connections.
#### Login Functionality:
- Read data from the values entered (Done)
- Use that data to interact with the database(Done)
- Allow access upon succesfull authentication(Done)

#### Windows
- Create User Info(Not Done)
- Create Courses(Very basic)
- Create Academies(Very Basic)
- Create Connections(Not Done)

#### Create a better dashboard
- Add clock(Done)
- Better buttons (Done)

#### Registration
- Create a registration window (Not Done)
- Read the values and save them to variables(Not done)
- Write those values to the database(Not done)

#### What went well and didn't
Creating Windows went well
Creating Dashboard went well
Creating login functionality caused many issues as I had to do a lot of research on how to implement it and succesfully integrate it with my application.

### Sprint-4
Sprint Goal: Create Registration, Tabs/Windows for User Info,Courses,Academies,Connections.

#### Create Registration:
-Create a registration window(Done)
- Read the values and save them to variables(Not done)
- Write those values to the database(Not done)

#### Windows
- Create User Info(Not Done)
- Create Courses(Nothing added)
- Create Academies(Slightly improved)
- Create Connections(Somewhat done, it queries the accounts from the database)

#### What went well and didn't
Tried to add tables to the database and rescaffold it by using the force command but that removed all my other tables and only left the ones I had specified in the command. I had to delete all data regarding the database and rescaffold it.
I was not able to fully implement the registration as I had problems using Linq to capture that data and write it to the database.
Connections was implemented but it does not check the current user.

### Sprint-5
Sprint Goal: Create Registration,Add, User Info, Add courses, expand peopleWindow and write UnitTests.

#### Create Registration:
- Read the values and save them to variables(Done)
- Write those values to the database(Done)
- Grant access to the dashboard

#### Windows
- Create User Info(Not Done)
- Create Courses(Added simple listbox queried from the database)
- Create Academies(Slightly improved buttons but nothing further)
- Create Connections(Nothing further added)

#### UnitTests
- Write UnitTests for CoursesPrint()
- Write UnitTests for AcademiesMake()

#### What went well and didn't
When creating the registration, I ran into many issues when writing to the database and data binding in Xaml.
Creating the windows went well.
Creating UnitTests went well.

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

