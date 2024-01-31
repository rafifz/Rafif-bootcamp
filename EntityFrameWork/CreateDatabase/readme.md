how to install dotnet-ef (to create database)
- dotnet tool install --global dotnet-ef
- then check installed tool
- dotnet tool list --global

create migration file
- dotnet ef migrations add "InitialCreation"
- then apply migration 
- dotnet ef database update
- dotnet ef database update "eg. choose version to revert or update"  