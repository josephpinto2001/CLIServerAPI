# CLIServerAPI

## Introduction

A Rest API to interact with a SQL Database that stores CLI command snippets

## Installation

### Prerequisites
 -Local SQL Database

 
### Setup

Once your SQL Database is setup, add your User ID and Password to appsettings.json. Alternatively, this can be configured using environmnet variables
or Azure Key Vault. 


## Usage

run the app with
```
dotnet run
```
Once the app is running, either head to the [local Swagger domain](https://localhost:5001/swagger) to interact with the API or 
test it with an application such as [Postman](https://www.postman.com) to test endpoints on either http://localhost:5000 or https://localhost:5001
