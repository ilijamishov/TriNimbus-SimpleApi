#!/bin/bash

export HOME=/home/ubuntu


cd /home/ubuntu/deployment/app
dotnet restore
dotnet build