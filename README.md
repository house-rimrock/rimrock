# rimrock
Collab project for climbing enthusiasts

### API

As a user, I want to be able to create new rock-climbing gear retailers & locations.
	Task: Create endpoint for creating retailers.
	Task: Create endpoint for creating locations.
	Test: Can create retailer using endpoint.
	Test: Can create location using endpoint.
As a user, I want to be able to update existing rock-climbing gear retailers & locations.
	Task: Create endpoint for updating retailers.
	Task: Create endpoint for updating locations.
	Test: Can update retailer using endpoint.
	Test: Can update location using endpoint.
As a user, I want to be able to delete existing rock-climbing gear retailers & locations.
	Task: Create endpoint for deleting retailers.
	Task: Create endpoint for deleting locations.
	Test: Can delete retailer using endpoint.
	Test: Can delete location using endpoint.
As a user, I want to be able to read existing rock-climbing gear retailers & locations.
	Task: Create endpoint for reading a single retailer.
	Task: Create endpoint for reading a single location.
	Task: Create endpoint for reading all retailers.
	Task: Create endpoint for reading all locations.
	Test: Can read single retailer using endpoint.
	Test: Can read single location using endpoint.
	Test: Can read all retailers using endpoint.
	Test: Can read all locations using endpoint.
	
### MVC
As a user, I want to be able to create an account with a unique username & log in with it.
	Task: Create login endpoint
	Test: Endpoint creates new user if username is new.
	Test: Endpoint does not create new user if username exists.
As a user, I want to be able to search for rock-climbing gear retailers & locations by region.
	Task: Create retailer search endpoint
	Task: Create location search endpoint
	Test: Retailer search endpoint gets all retailers in a given region
	Test: Location search endpoint gets all locations in a given region
As a user, I want to be able to view retailer & location details.
	Task: Create retailer details endpoint
	Task: Create location details endpoint
	Test: Retailer details endpoint gets the specified retailer.
	Test: Location details endpoint gets the specified location.
As a user, I want to be able to view my list of favorites.
	Task: Create favorites endpoint
	Test: Favorites endpoint only gets favorites for current user
	Test: Favorites endpoint gets all favorite retailers
	Test: Favorites endpoint gets all favorite locations.
As a user, I want to be able to add & remove rock-climbing gear retailers & locations from my list of favorites.
	Task: Create endpoint for adding favorite retailers
	Task: Create endpoint for adding favorite locations
	Task: Create endpoint for removing favorite retailers
	Task: Create endpoint for removing favorite locations
	Test: Can add favorite retailer using endpoint
	Test: Can add favorite location using endpoint
	Test: Can remove favorite retailer using endpoint
	Test: Can remove favorite location using endpoint

### BOTH
As a developer, I want to use dependency injection.
	Task: Create interface for handling API database calls
	Task: Create interface for handling App database calls
	Task: Create API service that implements API interface
	Task: Create App service that implements App interface
	Test: API service can get API dbcontext
	Test: App service can get App dbcontext
	Test: API service implements all interface methods
	Test: App service implements all interface methods

------------------------------

## WIREFRAMES

![Color](https://github.com/house-rimrock/rimrock/blob/master/wireframes/color.png)

![Login](https://github.com/house-rimrock/rimrock/blob/master/wireframes/login.png)

![Search](https://github.com/house-rimrock/rimrock/blob/master/wireframes/search.png)

![SearchResults](https://github.com/house-rimrock/rimrock/blob/master/wireframes/searchResults.png)

------------------------------

## Change Log

1.0: 12APR2019 *Initial publish*