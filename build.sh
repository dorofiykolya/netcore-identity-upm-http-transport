#!/usr/bin/env bash

SolutionPath=./RpcGenerator.sln

dotnet clean "$SolutionPath"
dotnet build "$SolutionPath"