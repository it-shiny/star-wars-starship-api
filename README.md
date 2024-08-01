# Star Wars Starship API

## Overview

This project is an ASP.NET Core MVC application that provides information about Star Wars starships. It includes functionalities for listing, creating, editing, deleting, and viewing details of starships.

## Features

- **List Starships**: View a table of all starships with options to edit, view details, or delete.
- **Create Starship**: Add a new starship with details such as name, model, manufacturer, etc.
- **Edit Starship**: Modify the details of an existing starship.
- **Delete Starship**: Remove a starship from the list.
- **View Details**: See detailed information about a specific starship.

## Getting Started

### Prerequisites

- [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0) SDK
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
- [Visual Studio Code](https://code.visualstudio.com/) (Optional: Use any IDE of your choice)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/it-shiny/star-wars-starship-api.git
   ```
2. Navigate to the project directory:
   ```bash
   cd star-wars-starship-api
   ```
3. Restore the dependencies:
   ```bash
   dotnet restore
   ```
4. Apply migrations and update the database:
   ```bash
   dotnet ef database update
   ```
5. Run the application:
   ```bash
   dotnet run
   ```
6. Open your browser and navigate to `http://localhost:5263` to access the application.

## Usage

- **View Random Starship**: Navigate to `/starships` to see random starship.
- **View Starships List**: Navigate to `/starships/list` to see the list of starships.
- **Create Starship**: Click on "Create New" to add a new starship.
- **Edit Starship**: Click on "Edit" next to a starship to modify its details.
- **Delete Starship**: Click on "Delete" to remove a starship.
- **View Details**: Click on "Details" to view more information about a starship.

## Contact

For any questions or suggestions, please contact [steven.steele.dev@gmail.com](mailto:steven.steele.dev@gmail.com).
