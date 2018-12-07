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

The databse structure should look like this when finished:

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


## Known Bugs
_No known bugs at this time_

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
