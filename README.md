# _Pierre's Bakery: 

#### By _**Greg Stillwell**_

#### 

## Technologies Used

* VSCode 
* C#
* ASP.NET Core
* ASP.NET Identity
* Razor 
* Entity Framework Core


## Setup / Installation Requirements / Configuration (1)
* Open Terminal/Command line
* type **git clone  into the terminal and press Enter on the keyboard
* Navigate to the desktop and click on the "Pierres.Solution" folder.
* Open the folder in VS Code


## (2)

* In the terminal, navigate to "Pierres" folder by using the following command: $ cd Pierres
* The .csproj file should have all necessary packages included. 
* In the terminal enter the following command: $ dotnet restore
* All packages should be restored and ready to go.

## (3)
* In the terminal navigate to the project directory "Pierres".
* Next, will add the file. In the terminal, enter the following:
  - $ touch appsettings.json
* Open the file in the code editor, and enter the following:
  ```json
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE NAME];uid=[YOUR USER ID];pwd=[YOUR PASSWORD];"
    }
  } 

## 

* Install the following in the terminal:

```
  $ dotnet tool install --global dotnet-ef --version 6.0.0
```
```
  $ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```
``` 
  $ dotnet ef migrations add Initial
```
```
$ dotnet ef database update
```
* The database has been migarated and the program is now functional. 


## (4)
* In the terminal, navigate to the Pierres folder
* Next, type this in the terminal:
  - $ dotnet run
* The program is ready to run on localhost. 


## Known Bugs

* None

##  License
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) Greg Stillwell 2023 