# Phone Catalog Web Application

This is a simple web application built with ASP.NET Core to showcase backend and database capabilities for an e-commerce context. The primary focus is on demonstrating how to structure and manage data using a .NET backend and a SQL Server database.

## Overview

This project is designed to display a catalog of phones, including their model, price, and company information. It provides a basic interface to list available phones and add new entries to the catalog.

Instead of relying on pre-built components, this project is built using low-level utility classes and customized styles. This approach offers complete control over the look and feel of the site, and simplifies adopting designs from other libraries or sites.

## Features

*   **List View:** Displays a list of available phones with details such as their model, price, and company email.
*   **Add Functionality:** Allows adding new phone entries to the database, including fields such as phone name, description, price, quantity, email and category.
*  **Edit Functionality:** Allows editing existing phone entries.
*  **Delete Functionality:** Allows deleting phone entries from the database.
*   **Data Management:** Demonstrates how to connect the application to a SQL Server database using Entity Framework Core.
*   **Responsive Design:** Built with responsive utilities, ensuring proper rendering on different screen sizes.

## Technologies Used

*   **ASP.NET Core:** The backend framework used to build the web application.
*   **Entity Framework Core (EF Core):** Used to interact with the SQL Server database.
*   **SQL Server:** The database used to store the phone information.
*   **Bootstrap:**  The CSS framework used for basic layout and styling.
*   **JavaScript:** Used to handle user interaction and basic form validations.
*  **GitHub Actions (Optional):** If you are using a deployment workflow, you may mention that.

## Setup Instructions

1.  **Clone the repository:**

    ```bash
    git clone https://github.com/your_username/your_repository.git
    ```
    *(Replace `https://github.com/your_username/your_repository.git` with the link of your repository)*
2.  **Navigate to the project directory:**

    ```bash
    cd ecommerce-app
    ```

    *(Replace `ecommerce-app` with the name of your project directory)*

3.  **Restore NuGet packages:**

    ```bash
    dotnet restore
    ```

4.  **Update Database**
     ```bash
       dotnet ef database update
     ```

5.  **Run the application:**

    ```bash
    dotnet run
    ```

6. **Open your Browser:**
   * Open your browser and go to the link `https://localhost:7083`

## Project Structure

*   **`Controllers/`**: Contains ASP.NET Core Controllers for managing requests.
*   **`Data/`**: Includes the `DbContext` class for interacting with the database.
*   **`Migrations/`**: Contains the Entity Framework Core migrations.
*   **`Models/`**: Contains the data models for Products and other database objects.
*   **`wwwroot/`**: Contains static assets such as CSS files and JavaScript files.
*  **`Views/`**: Contains the razor files that represents the views.

## Notes

* This is a basic project and does not implement all the features of a production-ready e-commerce site.
*  This project is designed to show the backend and database interaction, the styling of this website may be enhanced to fit your needs.

## Contributing

If you want to contribute, feel free to fork this repository and submit pull requests.

## License

This project is licensed under the [your_license] License.
