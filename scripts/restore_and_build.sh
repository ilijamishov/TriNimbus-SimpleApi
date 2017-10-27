#!/bin/bash
while getopts ":h:" opt; do
  case $opt in
    h) home_key="$OPTARG"
    ;;
    \?) echo "Invalid option -$OPTARG" >&2
    ;;
  esac
done

dotnet restore ~/"$home_key"
dotnet build ~/"$home_key"