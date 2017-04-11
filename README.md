# blank-xamarin

[![AppVeyor](https://img.shields.io/appveyor/ci/feedhenry/blank-xamarin/master.svg)](https://ci.appveyor.com/project/feedhenry/blank-xamarin/) 

Author: Summers Pittman (supittma@redhat.com)   
Level: Beginner   
Technologies: Xamarin, Android, RHMAP   
Summary: A template application which Initializes FeedHenry in a multiple Xamarin targets  
Community Project : [Feed Henry](http://feedhenry.org)   
Target Product: RHMAP   
Product Versions: RHMAP 3.8.0+   
Source: https://github.com/feedhenry-templates/blank-xamarin  
Prerequisites: fh-android-sdk : 3.0.+, Xamarin Studio, Android SDK : 22+ or newer, Visual Studio 2015

## What is it?

This application provides a starting point for developing RHMAP applications.  The FeedHenry SDK is initialized for Android in `blank-xamarin-android/MainActivity.cs`. The app uses [fh-dotnet-sdk](https://github.com/feedhenry/fh-dotnet-sdk).

If you do not have access to a RHMAP instance, you can sign up for a free instance at [https://openshift.feedhenry.com/](https://openshift.feedhenry.com/).

## How do I run it?

### RHMAP Studio

This application and its cloud services are available as a project template in RHMAP as part of the "Xamarin Blank Project" template.

### Local Clone (ideal for Open Source Development)
If you wish to contribute to this template, the following information may be helpful; otherwise, RHMAP and its build facilities are the preferred solution.

###  Prerequisites
 * fh-android-sdk : 3.0.+
 * Xamarin Studio
 * Android SDK : 16+

## Build instructions
### Android
 * Open the project in Xamarin Studio
 * Edit `blank-xamarin-android/Assets/fhconfig.properties` to include the relevant information from RHMAP.
 * Attach running Android Device with API 16+ running
 * Right click on "blank-xamarin-android" and select "Run Item"

#### Initialization

The FeedHenry SDK is initialized in `blank-xamarin-android/MainActivity.cs`.
