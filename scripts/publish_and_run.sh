#!/bin/bash

while getopts ":h:" opt; do
  case $opt in
    h) home_key="$OPTARG"
    ;;
    \?) echo "Invalid option -$OPTARG" >&2
    ;;
  esac
done

dotnet restore ~/"$home_key"/

dotnet publish ~/"$home_key"/ --output ~/"$home_key"/PUBLISH
dotnet ~/"$home_key"/PUBLISH/TriNimbus-SimpleAPI