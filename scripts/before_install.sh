#!/bin/bash

#kill the current process so the install can be executed
sudo kill $(sudo lsof -t -i:80)