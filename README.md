# 🅰️ Angular POS Project

## 📝 Overview
This project is a single-page application (SPA) built with Angular. It demonstrates a complete CRUD (Create, Read, Update, Delete) operation using an external API. The project showcases my understanding of Angular modules, components, directives, and business logic related to business, sales, purchases, discounts, and total calculations.

## ✨ Features
- 📁 **Modular Structure**: The project is organized into modules to ensure scalability and maintainability.
- 📦 **Components**: Various components are created to encapsulate different parts of the application, ensuring reusability and separation of concerns.
- 📐 **Directives**: Custom directives are used to extend HTML functionality and enhance user interactions.
- 🌐 **Routing**: The project uses Angular Router to navigate between different views.
- 🔄 **CRUD Operations**: Full CRUD operations are implemented, allowing users to create, read, update, and delete data from an external API.
- 📱 **Responsive Design**: The application is responsive and works well on different screen sizes.
- 🏢 **Business Logic**: Includes understanding and implementing business logic related to business operations, sales, purchases, discounts, and total calculations.

## 🛠️ Technologies Used
- **Angular**: Framework used for building the SPA.
- **TypeScript**: Programming language used for writing Angular code.
- **HTML & CSS**: Markup and styling of the application.
- **Bootstrap**: CSS framework used for responsive design.
- **External API**: Consumed for performing CRUD operations.

## 🚀 Getting Started

### Prerequisites
- Node.js and npm installed
- Angular CLI installed



## 📂 Project Structure

- `src/app`: Contains the main application modules and components.
- `components`: Contains all the components.
- `services`: Contains services for making HTTP requests to the external API.
- `models`: Contains TypeScript interfaces for data models.
- `modules`: Contains feature modules.
- `directives`: Contains custom directives.
- `app-routing.module.ts`: Configures the application's routes.

## 🔄 CRUD Operations

### ➕ Create
- **Description**: Allows users to add new data to the application. 🆕
- **Implementation**: The create component provides a form for entering new data. The form data is sent to the external API using an HTTP POST request. 🌐

### 📄 Read
- **Description**: Fetches and displays data from the external API. 📜
- **Implementation**: The read component retrieves data from the API using an HTTP GET request and displays it in a list or table format. 🗒️

### ✏️ Update
- **Description**: Allows users to update existing data. ✏️
- **Implementation**: The update component provides a form pre-filled with the existing data. The updated data is sent to the API using an HTTP PUT request. 🔄

### ❌ Delete
- **Description**: Allows users to delete data from the application. 🗑️
- **Implementation**: The delete component provides a delete button for each data item. When clicked, it sends an HTTP DELETE request to the API to remove the item. 🗑️

## 🏢 Business Logic
This project demonstrates my understanding of business logic related to:
- **Business Operations**: Efficient handling and management of various business activities.
- **Sales**: Management of sales data, including customer interactions, order processing, and sales reporting.
- **Purchases**: Tracking and managing purchase orders, supplier interactions, and inventory management.
- **Discounts**: Applying discounts to sales transactions and calculating the final price after discount.
- **Total Calculations**: Accurately calculating the total price for transactions, including handling discounts and additional charges.

## 🛍️ Purchases
- **Description**: Manage and track purchase orders and inventory.
- **Implementation**: The purchase component allows users to add, view, update, and delete purchase orders. It interacts with the external API to perform CRUD operations and update the inventory accordingly.

## 💲 Discounts
- **Description**: Apply discounts to sales transactions.
- **Implementation**: The discount functionality is integrated into the sales component, allowing users to enter discount values. The application calculates the final price after applying the discount.

## 🧮 Total Calculations
- **Description**: Calculate the total price for sales transactions.
- **Implementation**: The total calculation logic is implemented in the sales component. It sums up the prices of all items, applies any discounts, and calculates the final total amount to be paid by the customer.

## 📚 Conclusion
This Angular project demonstrates my understanding of key Angular concepts, including modules, components, directives, and routing. It also showcases my ability to implement a full CRUD operation using an external API and apply business logic to handle business, sales, purchases, discounts, and total calculations. 🌟
