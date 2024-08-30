
# Monitorstat client app

## Overview

Monitorstat.Client.App is a .NET Framework 4.8 application written in C# that communicates with a Monitorstat WCF service provided by NSI. This service requires authentication via a username and password, which must be provided by the NSI administration.

## Prerequisites

- **.NET Framework 4.8**: Make sure that .NET Framework 4.8 is installed on your machine.
- **Monitorstat Credentials**: Contact the NSI administration to obtain the necessary username and password for accessing the WCF service.

## Getting Started

### 1. Clone the Repository

First, clone the repository to your local machine:

```bash
git clone https://github.com/mstamenov/MonitorstatClient.git
cd monitorstatClient
```

### 2. Configure the Project

1. Open the solution in Visual Studio.
2. Modify `Program.cs` file in your project to set up the username and password:

```csharp
using MonitorstatTest.MonitorstatService;
using System;
using System.Linq;

namespace Monitorstat.Client.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Monitorstat client

            client.ClientCredentials.UserName.UserName = "";  // Insert provided username
            client.ClientCredentials.UserName.Password = "";  // Insert provided password

            // Rest of the code...
        }
    }
}
```

### 3. Build and Run

1. Build the solution using Visual Studio.
2. Run the project.

## Usage

Once you have successfully built and run the project, it will connect to the NSI Monitorstat service and perform the necessary operations.
