# BandsApp 🎸

A simple ASP.NET Core web app to show off our favorite bands.
This app was create using mob programming.

Create a New Project
Start by making an **Empty ASP.NET Core** project:

- **Project name:** `BandsApp.Web`
- **Solution name:** `BandsApp`

Create a Band Model
Add a class called `Band` with these properties:
  
int Id  
string Name  
string Description

Make a BandService Class

Add a service class BandService that does the following

- Has a private list of bands, and add a few of your group’s favorite bands.

- Method: Band GetBandById(int id) – returns a band by its ID.
- Method: Band[] GetAllBands() – returns the full list of bands.

Controllers, Actions, and Views

- When someone visits the site with no specific URL (like just /), show a list of your favorite bands' names.
- Each band in the list should be a link that goes to /details/1, /details/2, etc.
- (Use an id parameter in your Action method to show the right band.)
- When you click on a band, it should show a detail view with the band's name and description.
-  Add a picture of the band to the detail view. Store the images in the project folder.    
