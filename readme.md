# Quotes Management System

A simple, distributed application designed to simulate a company resource management system (Proof of Concept). It consists of two main services communicating via HTTP: a Minimal Web API with an In-Memory database and a Console Client.

## Features
* **Quotes API**: Handles storing quotes in memory and serves a random quote.
* **Console Client**: Simple text-based user interface allowing users to fetch random quotes or submit new ones.

## Prerequisites
* [.NET 8 SDK](https://dotnet.microsoft.com/download)

## How to Run

To run the full system, you need to start both applications. Follow the steps below:

### 1. Start the API Service
Open your terminal, navigate to the API directory, and run the server:
```bash
cd Quotes.Api
dotnet run