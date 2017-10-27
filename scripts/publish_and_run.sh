#!/bin/bash

export NUGET_PACKAGES=/home/ubuntu/.nuget

cd /home/ubuntu/deployment/app
dotnet publish --output publish

cd /home/ubuntu/deployment/app/publish
sudo dotnet TriNimbus-SimpleAPI