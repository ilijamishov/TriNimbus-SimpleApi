#!/bin/bash

export NUGET_PACKAGES=/home/ubuntu/.nuget/packages

cd /home/ubuntu/deployment/app
dotnet restore
dotnet build