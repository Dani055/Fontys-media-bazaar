# Media Bazaar Group Project
This is a group project named Media Bazaar done in semester 2 by a group of 4 people.
The pretend client was one of the teachers with whom we got weekly meetings to update our progress.
- The project itself took 18 weeks to make, with the first 6 being a waterfall-style development, after which we switched to Agile with 4 sprints (3 weeks each).

## The idea
The idea was to build an application for a new hardware store called Media Bazaar. The application(s) would have various functionalities such as
### A desktop app
- employee management and presence tracking
- shift scheduling
- automatic shift scheduler
- stock management
- sales management
### Website
- employees can see their shifts
- ability to view stock and prices
### For more info, refer to the documentation folder

## Code info
The desktop application was done in **.NET** and the website was done with **ASP.NET Razor pages**, which both share the same back-end class library.

## My work
My contribution to the project was the website and desktop application interfaces, as well as the functionality behind managing employees and automatic work shift scheduling.

## How to run project
(in case you want to check it out for yourself)
- You would need to have **Visual Studio** installed with **ASP.NET** extention
- Apps requires a **MySQL database** to function. You can find the **connection string** in MBazaarClassLibrary/Utils.cs and replace it with your own database.
- Required **database structure** and departments are in the **Documentation and misc/Database design** folder
- Employee rolse include **(case sentitive)** -  {Department Employee}, {Department Manager}, {Warehause Worker}, {Cashier}, {CEO}. - **You need to add a CEO account in order to be able to log in and start adding more employees. Make sure the CEO account has the hashed password '$MYHASH$V1$10000$mbMGAcI/sN1yYkkt4JiJSCkv6Em7f1MYvu+fdaNJKEhSgUr1' so actual login password is 123**
