#!/bin/bash

cd ~/deployment/app
dotnet publish --output publish

cd ~/deployment/app/publish
sudo dotnet TriNimbus-SimpleAPI