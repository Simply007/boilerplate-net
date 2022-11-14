dotnet tool restore
$OUTPUT_PATH = Join-Path $PSScriptRoot "..\Models\ContentTypes"
dotnet tool run KontentModelGenerator -p "48899a4e-233b-000b-9aa8-b9f859436232" -o $OUTPUT_PATH -n "Kontent.Ai.Boilerplate.Models.ContentTypes" -g=true