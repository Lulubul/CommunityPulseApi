# CommunityPulseApi

# General Naming Convention 
* Keep in mind to use PascalCasing
https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines

# Project guideline
* The project use CQRS model to invoke commands using Mediatr
* Queries should have [Name]Query.cs and Commands should be like [Name]Command.cs
* Keep in mind to use TDD

# Branch strategy 
* Use a separate branch for each feature
* Merge feature branch into dev
https://nvie.com/posts/a-successful-git-branching-model/
