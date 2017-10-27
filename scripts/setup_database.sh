#!/bin/bash

while getopts ":h:" opt; do
  case $opt in
    h) home_key="$OPTARG"
    ;;
    \?) echo "Invalid option -$OPTARG" >&2
    ;;
  esac
done

dotnet ef migrations add InitialCreate ~/$home_key
dotnet ef database update ~/$home_key