# _Music Organizer_

#### _ASP.NET Core MVC practice for Epicodus_, _Mar. 12, 2020_

#### By _**Dana Luukko, Michelle Morin**_

## Description

_This application is a music organizer that allows a user to enter genres of music and assign records (song name, artist name) to each genre._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application creates genre instance  | Genre: genre | New Genre object formed |
| Application creates an instance of a record  | Record: Song name, artist | New Record Object |
| Application returns type of a Genre object | NewCategory.Type | "Rock" |
| Application returns artist name and song name of record object | newRecord.Title, newRecord.Artist | "sprawl II (mountains beyond mountains", "arcade fire" |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* $ cd desktop
* $ git clone https://github.com/dcluukko/8-ind-proj-Word-Counter.git
* $ cd WordCounter.Solution

_Confirm that you have navigated to the correct directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Dana Luukko_**