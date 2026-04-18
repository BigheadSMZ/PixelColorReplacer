# Pixel Color Replacer

This is just a simple application that can replace a list of colors within a set threshold.

<img width="331" height="461" alt="image" src="https://github.com/user-attachments/assets/31dd8ae9-533d-4dfa-bd4c-8829324f26dc" />

# How To Use

- Select a folder full of images you want to replace colors for.
- Output path is automatic but can be changed.
- Select a "Source" color to replace.
- Select a "Target" color to replace "Source" color.
- Optionally set a "Tolerance" which seeks above and below RGB values.
- RGB "128/145/10" with tolerance "3" matches "125-131/142-148/7-13".
- Click "Add" to create a replacement rule.
- Repeat this for any other colors you wish to replace.
- Click "Start". When it's finished, results are in Output Path.
- Clicking on a replacement rule allows editing and changing the rule.
- "Add" and "Clear" buttons become "Replace" and "Remove" during selection.

# Building

This program is built with .NET 8.0.

- Install [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
- Run 'publish.bat'.
