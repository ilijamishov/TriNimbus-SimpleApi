#!/bin/bash

cd /home/ubuntu/deployment/app

dotnet restore .
dotnet build .