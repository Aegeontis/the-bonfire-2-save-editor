#!/bin/bash

# compile linux x64
dotnet publish -c Release -r linux-x64 --self-contained true
