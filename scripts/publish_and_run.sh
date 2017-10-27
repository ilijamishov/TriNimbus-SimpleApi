#!/bin/bash

cd /home/ubuntu/deployment/app
dotnet publish --output publish

cd /home/ubuntu/deployment/app/publish
sudo dotnet TriNimbus-SimpleAPI