# Getting Started

This tutorial explains how to develop Networked.Community on your local machine.

## Setup your development environment

First things first! Let's setup our development environment before contributing to the project.

### Prerequisites

The following tools should be installed on your development machine:

- [An OS that supports .NET Core 3.1](https://github.com/dotnet/core/blob/master/release-notes/3.1/3.1-supported-os.md)
- **Code Editor**
  - [Visual Studio 2019 (v16.4+) for Windows](https://visualstudio.microsoft.com/vs/)
  - [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
  - [VSCode](https://code.visualstudio.com/) 
- [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [Node v12+](https://nodejs.org)
- [Yarn v1.19+](https://classic.yarnpkg.com/)

> You can use another editor as long as it supports .NET Core and ASP.NET Core.

### Install the ABP CLI

> Networked.Community uses [ABP](https://abp.io), which is a complete architecture and strong infrastructure to create modern web applications! It follows the best practices and conventions to provide you a [SOLID](https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425) development experience.

First, you need to install the [ABP CLI](https://docs.abp.io/en/abp/latest/CLI), which is a free & open source tool that is used to authenticate and automate some tasks for ABP based applications.  

Open your CLI, and enter the following command:

~~~~
dotnet tool install -g Volo.Abp.Cli
~~~~

If you already have it installed, you can update it using the following command:

~~~~
dotnet tool update -g Volo.Abp.Cli
~~~~

To learn more about the ABP Framework, [read the documentation here](https://docs.abp.io/en/abp/latest).

### Install Docker

> [Docker](https://www.docker.com/) is a set of platform as a service products that uses OS-level virtualization to deliver software  in packages called containers. Containers are isolated from one another and bundle their own software, libraries and configuration files; they can communicate with each other through well-defined channels. [Wikipedia](https://en.wikipedia.org/wiki/Docker_(software))

[Get Docker here](https://www.docker.com/products/docker-desktop). The Desktop version is available on Windows or Mac, and the Engine for Linux. When installing, do not use Windows containers over Linux.

There are [many benefits](https://medium.com/uptime-99/the-benefits-of-using-docker-for-development-and-operations-2c5256ad89bc) to using Docker for Development and Operations.

### Setup Redis Container on Docker

> [Redis](https://redis.io/) is an in-memory data structure project implementing a distributed, in-memory key-value database with  optional durability. Redis supports different kinds of abstract data structures, such as strings, lists, maps, sets, sorted sets,  HyperLogLogs, bitmaps, streams, and spatial indexes. [Wikipedia](https://en.wikipedia.org/wiki/Redis)

First, pull the Redis container via the CLI:

~~~~
docker pull redis
~~~~

Then, setup and run Redis in Docker via the CLI:

~~~~
docker run -p 6379:6379 –-name nc-redis -d redis
~~~~

> Note that the name should be **nc-redis**

### Install Git

> [Git](https://git-scm.com/) is a distributed version-control  system for tracking changes in source code during software development.  It is designed for coordinating work among programmers, but it can be used to track changes in any set of files. Its goals include speed, data integrity, and support for distributed, non-linear workflows. [Wikipedia](https://en.wikipedia.org/wiki/Git)

There are a number of [git clients](https://git-scm.com/downloads/guis/) available for for browsing and committing to repositories.   If you're using Windows or Mac, we recommend [GitHub Desktop](https://desktop.github.com/), as [our repositories](https://github.com/Networked-Community) are located there.   

If you're new to GitHub, please read this "[Hello World](https://guides.github.com/activities/hello-world/)" tutorial.   

To learn how to use GitHub Desktop, [follow the documentation here](https://help.github.com/en/desktop).

### Clone or Download Networked.Community Repository

The source code for Networked.Community is located in a [repository](https://github.com/Networked-Community/networked-community) can be cloned or downloaded via GitHub.   If you have GitHub Desktop installed, you can [open it directly in it](x-github-client://openRepo/https://github.com/Networked-Community/networked-community).

### Prepare the solution (Visual Studio)

1. Open the Nc.sln file in Visual Studio.  
2. Rebuild the solution. 
3. Right-Click on the Nc.DbMigrator project > Debug > New Instance
   This will prepare the local database and seed it with data.  
   When complete, press enter to close the window.
4. Right-Click the Nc.IdentityServer project >  Set as startup project
   1. Press CTRL-F5 to run it
5. Right Click on the Nc.HttpApi.Host project > Set as startup project
   1. Press CTRL-F5 to run it

You should now have two projects running - the Identity Server as well as the API Host with Swagger integration. 

> [Swagger](https://swagger.io/) is an open-source software framework backed by a large ecosystem of tools that helps developers design, build, document, and consume RESTful web services. While most users identify Swagger by the Swagger UI tool, the Swagger toolset includes support for automated documentation, code generation, and test-case generation. Sponsored by SmartBear Software, Swagger has been a strong supporter of open-source software, and has widespread adoption. [Wikipedia](https://en.wikipedia.org/wiki/Swagger_(software))


To log in to the Identity Server, go to https://localhost:44392/Account/Login

> u: admin
> p: 1q2w3E*

If all is successful, you should be presented with a profile screen.

To further test things, check out and run the Nc.HttpApi.Client.ConsoleTestApp

### More to come soon!