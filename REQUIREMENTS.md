# RimRock - Software Requirements

## Vision
A web application that streamlines the process of finding rock-climbing
locations and retailers.

## Scope
- **In**
  - Users can create accounts using a unique username.
  - Users can search for stores & locations.
  - Users can add/remove stores & locations to a list of favorites.
  - Web app will query API for store & location information.
- **Out**
  - Users will not have passwords.
  - No e-commerce functionality.
  - No weather data.

### Minimum Viable Product
Functional website that allows users to query API for stores & locations,
and add/remove stores & locations from a list of favorites.

### Stretch Goals
- Filter search results by different types of climbing.
- Add other sports.
- Consume outside API for store / location data.

## Functional Requirements
1. Users can create accounts (require unique username).
2. Users can add/remove stores & locations to favorites (use join table).
3. API will be seeded with store & location data.
4. Web App will store user data and favorites lists.
5. Web App will query API to obtain store & location data.
6. API must have operational CRUD endpoints.

## Non-Functional Requirements
1. All API endpoints should be unit tested.
2. Web app should use bootstrap to create a clean, modern user interface.
3. API must use Swagger to generate documentation.

### Data Flow
1. When the user accesses the website, the app will query the API to **GET** store
& location info to populate the home screen.
2. When the user logs in, the app will query its database to see if the username 
given has already been taken, and if not the app will **POST** the new user to the
database. If the user already exists, the app will **GET** the user information from
the database. The user will then be logged in.
3. When the user searches for stores or locations, the app will query the API to
**GET** matching results from the respective table, and then display the results
to the app.
4. When the user adds a store or location to their favorites, the app will query its
database to **POST** a new favorite to the respective table of favorites.
5. When the user removes a store or location to their favorites, the app will query
its database to **DELETE** an existing row from the respective table.