## 2. Endpoints

The API supports the following *endpoints* to interact with the products:

- GET /api/Products: Lists all the products available in the catalog.
- GET /api/Products/{id}: Gets a product by its ID.
- POST /api/Products: Creates a new product in the system.
- PUT /api/Products/{id}: Updates an existing product by its ID.
- DELETE /api/Products/{id}: Deletes a product from the catalog.

These endpoints allow managing the complete lifecycle of the products in the system.

## 3. Technologies

The project uses the following technologies:

- ASP.NET Core Web API: Framework for creating and managing the REST API.
  
- Swagger: Integrated tool that allows testing and documenting the API endpoints in an easy way.

- In-memory list: To simplify development and implementation, the API uses an in-memory list to temporarily store the products.

## 4. Repository Usage Guide

Here’s how to clone and run the project on your local machine:

### Clone the Repository

To get started, clone this repository to your local machine using the following command:

```bash
git clone https://github.com/yourusername/repository-name.git
```

### Restore Dependencies

Inside the project directory, run the following command to restore the project dependencies:

```bash
dotnet restore
```

### Run the Application

Once the dependencies are restored, run the application locally with the following command:

```bash
dotnet run
```

The API will be available at [http://localhost:5000](http://localhost:7143).
