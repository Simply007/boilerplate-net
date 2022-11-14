#!/usr/bin/env bash
dotnet tool restore
output_folder="$( cd "$(dirname "${BASH_SOURCE[0]}")" ; pwd -P )/../Models/ContentTypes"
dotnet tool run KontentModelGenerator -p "48899a4e-233b-000b-9aa8-b9f859436232" -o "$output_folder" -n "Kontent.Ai.Boilerplate.Models.ContentTypes" -g True -s True