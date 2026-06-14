# Quotes Management System (Distributed Architecture PoC)

A lightweight, distributed application designed to simulate a company resource management system. This project serves as a Proof of Concept (PoC) demonstrating decoupled service communication via HTTP. It consists of a backend Minimal Web API powered by an In-Memory database and a text-based Console Client.

## System Architecture & Flow
1. **Quotes.Client (Frontend)**: Initiates HTTP requests based on user input.
2. **HTTP Communication**: RESTful calls bridge the client and the server.
3. **Quotes.Api (Backend)**: Receives requests, processes business logic, and interacts with the volatile data layer.
4. **EF Core In-Memory DB**: Temporary storage that resets upon API shutdown.

## Tech Stack
* **Language**: C# 12
* **Framework**: .NET 8.0
* **Database**: Entity Framework Core (In-Memory Database Provider)
* **API Style**: ASP.NET Core Minimal APIs

---

## API Endpoints Specification

| Method | Endpoint | Request Body | Response (Success) | Description |
| :--- | :--- | :--- | :--- | :--- |
| `POST` | `/quotes` | `{"text": "...", "author": "..."}` | `201 Created` | Adds a new quote to the memory database. |
| `GET` | `/quotes/random` | *None* | `200 OK` (JSON Object) | Fetches a randomly selected quote. |

---

## Prerequisites
* [.NET 8 SDK](https://dotnet.microsoft.com/download) installed on your machine.

---

## How to Run

To test the complete distributed system, you need to launch both applications concurrently in separate terminal windows.

### Step 1: Start the Backend API
Navigate to the API directory and run the server. It is pre-configured to bind strictly to port `5000`.
```bash
cd Quotes.Api
dotnet run