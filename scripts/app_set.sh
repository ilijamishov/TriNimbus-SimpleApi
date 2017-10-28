#!/bin/bash

#navigate to source code
cd /home/ubuntu/deployment/app

#restore and build the application
dotnet restore
dotnet build

#create the database
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update

#publish the source code
dotnet publish --output publish