#load "nuget:?package=Rocket.Surgery.Cake.Library&version=0.10.0";

Task("Default")
    .IsDependentOn("dotnetcore");

RunTarget(Target);
