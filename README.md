# Automatic-RSS-Reader
School assignment, autumn 2019

An application coded in that the user can insert RSS urls in, give them a category and choose interval, and add them to a feed. The feed is updating its podcasts and getting new episodes with a timer, depending on each podcast's chosen interval. The application do not have the function to play the podcast episodes. Podcasts and categories the user has created is saved on the local computer for the next time the application is opened.

The application is coded in C# using the .NET framwork. WinForm is used for the user interface. The project specification required a 3-Tier Architecture and XML and/or JSON for saving the files and getting the urls.

The project was to be finished in 10 days, and there are areas where improvement can be made. Some of these areas are:
- Making the category list a object list instead of a string list, and having a key for every category so when the category name is changed the podcasts using the category also changes.
- Remove the popup-messages for wrong inputs and do a better user interface where the messages can be shown as text over the different input places.
