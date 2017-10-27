#!/bin/bash

#kill the current process so the install can be executed
pid=$(sudo lsof -t -i:80)

if [ -n $pid ]
then
    sudo kill $pid
fi