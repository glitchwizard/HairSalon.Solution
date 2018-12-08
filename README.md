# _HairSalon Client Manager_

#### _This web app will help salons manage their stylists and clients, 2018-12-07_

#### By _**{List of contributors}**_

## Description
_This app will allow the input of stylists working at a salon, and allow those stylists to build a list of their clients for reference_

## Specifications

## Setup/Installation Requirements

Required Software:
1. Windows or Mac operating system (for terminal access), or Visual Studio to run the dotnet environment
2. MAMP software (https://www.mamp.inf)


1. Install MAMP (https://www.mamp.info/en/downloads/, instructions: https://www.learnhowtoprogram.com/c/database-basics-ee7c9fd3-fcd9-4fff-8b1d-5ff7bfcbf8f0/introducing-and-installing-mamp)
	* Configure it to have ports Apache port 8888, and MySQL port 8889 (https://documentation.mamp.info/en/MAMP-Mac/Preferences/Ports/)
	* Start up the servers for both Apache and MySQL (both should boot up together)

2. Select the "Open Webstart Page" after MAMP is running successfully (https://documentation.mamp.info/en/MAMP-Mac/First-Steps/MAMP.png)

3. Create initial Database
	* Open your terminal and get into the mysql> prompt:
	* Input the following commands in order
		* "CREATE DATABASE charley_mcgowan;"
		* "USE charley_mcgowan;"
		* CREATE TABLE stylists (id serial PRIMARY KEY, stylistname VARCHAR(255));
		* CREATE TABLE clients (id serial PRIMARY KEY, clientName VARCHAR(255), stylist_id INT);

		It should look like this when it's finished:

4. Copy the database just created, as a duplicate test database
	* Open phpMyAdmin, in the WebStart page it can be found in the top header bar under Tools > phpMyAdmin
	* select from the menu on the left hand side 'charley_mcgowan'
	* Once selected, find the "Operations Tab" and select it.
	* use the window labeld "Copy database to"
		*type in: "charley_mcgowan_test" into the open field
		*select the 'structure only' radio button
		*leave the rest of the defaults the same
		*select the "Go" button
	* This should create a duplicate database by the name of "charley_mcgowan_test"
	*if phpMyAdmin makes the DB's look like they are in two subfolders of 'charley' and 'mcgowan', don't worry about it, it's just a strange thing that happens, the databases should still work just fine.

The databse structure should look like this when finished (ignore the . marks, they're there to make the formatting work):

	charley

	└── mcgowan

		.	├── charley_mcgowan
		.
		.	│	.	├── *new
		.
		.	│	.	├── clients
		.
		.	│	.	└── stylists
		.
		.	└── charley_mcgowan_tests
		.
		.		.	├── *new
		.
		.		.	├── clients
		.
		.		.	└── stylists



5. Run the program from the terminal in your cloned repository under that HairSalon folder
	* Once in the HairSalon folder (not HairSalon.Solutions, but one further) type 'dotnet run' to get the terminal to run the web app.
	* Once the webapp is running, navigate to the localhost website to get it. This could be localhost:5000 or some other port number other than 5000.

The site layout was created using RESTful routing, as follows: 

| Route Name | URL Path                                       | HTTP Method                    | Purpose																   |
|------------|------------------------------------------------|--------------------------------|---------------------------------------------------------------------------|
| Index      | /stylists                                      | GET                            | Display list of all stylistss											   |
| New        | /stylists/new                                  | GET                            | Offers form to create new stylists										   |
| Create     | /stylists                                      | POST                           | Creates new stylists on server											   |
| Show       | /stylists/:id                                  | GET                            | Displays one specific stylistsIs details								   |
| Edit       | /stylists/:id/edit                             | GET                            | Offers form to edit specific stylists	**(not complete)**									   |
| Update     | /stylists/:id                                  | PATCH  (via POST with MVC)	   | Updates specific stylists on server									   |
| Destroy    | /stylists/:id                                  | DELETE (via POST with MVC)     | Deletes specific stylists on server **(not complete)**						   |
| Index      | /clients                                       | GET                            | Displays all clients regardless of associations with   stylistss		   |
| New        | /stylists/:stylists_id/client/new              | GET                            | Offers form to create new client within specific stylists			       |
| Create     | /stylists/:stylists_id/client                  | POST                           | Creates new client within specific stylists on server				       |
| Show       | /stylists/:stylists_id/client/:client_id       | GET                            | Displays details for a specific client associated with a   stylists	   |
| Edit       | /stylists/:stylists_id/client/:client_id/edit  | GET                            | Offers form to edit specific client associated with stylists **(not complete)**			       |
| Update     | /stylists/:stylists_id/client/:client_id       | PATCH  (via POST with MVC)     | Updates specific client associated with stylists on server				   |
| Destroy    | /stylists/:stylists_id/client/:client_id       | DELETE  (via POST with MVC)    | Deletes specific client associated with stylists on server **(not complete)** |


## Known Bugs
_No known bugs at this time, but tables can't be deleted at the moment_

## Support and contact details
_Charley McGowan_

## Technologies Used
* Visual Studio 2017
* MAMP
* MySQL
* Apache
* Atom (for some of the dev)

### License
*MIT*
Copyright (c) 2018 **_Charley McGowan_**
