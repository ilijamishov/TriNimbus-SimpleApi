#!/bin/bash

export NUGET_PACKAGES=/home/ubuntu/.nuget/packages

dotnet restore /home/ubuntu/deployment/app
dotnet build /home/ubuntu/deployment/app