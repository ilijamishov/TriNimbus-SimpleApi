#!/bin/bash
cd /home/ubuntu/deployment/app

dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet restore

dotnet ef migrations add InitialCreate
dotnet ef database update