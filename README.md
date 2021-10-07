# .Net-Core-Technical
A basic .Net 5 app to create/edit/store a list of TODO's. 

Angular and Typescript were used develop the front end for api requests. Bootstrap/Font-Awesome were used for basic styling.

For the backend, I did use the EntityFrameworkCore package for a basic ORM and migrations. I was actually fairly hesitant on whether or not using this was allowed in the technical. Although I did initially start developing the app using ADO.Net, but decided against it due to the limited time.

## Setup
I've included basically everything in this repo, so there shouldn't be any setup required. Once downloaded, restore packages and build solution should be all that's needed.

## Usage
To add a new TODO, enter a value into the Description and click 'Submit'. This will create a new TODO where IsComplete = false;

To edit an existing TODO, click the row you want to edit and the inputs will be populated with that data. Once the form is populated, clicking the 'Submit' button will save any updates made. 
