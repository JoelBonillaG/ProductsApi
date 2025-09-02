# Exercise Requirements

## 1. Data Model

The `Product` data model contains the following properties:

- **Id**: Unique identifier of the product.  
- **Name**: Name of the product.  
- **Price**: Price of the product.  
- **Available**: Availability indicator of the product.  

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Available { get; set; }
}
```

## 2. Endpoints

The API supports the following *endpoints* to interact with products:

- **GET** `/api/Products`: Lists all products available in the catalog.  
- **GET** `/api/Products/{id}`: Retrieves a product by its ID.  
- **POST** `/api/Products`: Creates a new product in the system.  
- **PUT** `/api/Products/{id}`: Updates an existing product by its ID.  
- **DELETE** `/api/Products/{id}`: Deletes a product from the catalog.  

These endpoints allow managing the complete lifecycle of products in the system.  
For more details and interactive testing, please visit the **Swagger UI** included in the project.

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

The API will be available at both:

- HTTPS: [https://localhost:7143](https://localhost:7143)  
- HTTP: [http://localhost:5069](http://localhost:5069)
