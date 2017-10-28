#!/bin/bash

export HOME=/home/ubuntu

cd /home/ubuntu/deployment/app
dotnet publish --output publish

cd /home/ubuntu/deployment/app/publish
sudo dotnet TriNimbus-SimpleAPI.dll