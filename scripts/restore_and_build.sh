#!/bin/bash

cd /home/ubuntu/deployment/app

dotnet restore /home/ubuntu/deployment/app
dotnet build /home/ubuntu/deployment/app