# COVID-19 Response Network

[![GitHub license](https://img.shields.io/github/license/Vertical-OSS/covid-response-network)](https://github.com/Vertical-OSS/covid-response-network/blob/master/LICENSE) [![PRs welcome!](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](./CONTRIBUTING.md) [![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg)](./CODE_OF_CONDUCT.md)


## OVERVIEW

In a nutshell, the COVID-19 Response Network is a system to help fulfill the needs of communities during the pandemic.   

The project was originally inspired by Jae Slaby, a local community organizer in Battle Creek, Michigan that put together a local website that linked to a resource guide and timebank on Google Sheets to help people to seek and offer help, with the goal of connecting people together. Putting this together on to a simple to use website looked to be the solution to this, to keep things user friendly and highly accessible.

## WHAT IT DOES (so far)

The current pilot city, [Battle Creek, Michigan](https://battlecreek.covidresponse.net), includes the first features of the project, which includes ways to offer and receive help through various local organizations.  The site also includes a community resource guide so folks can look up essential services and resources in their area.   Although the site is not meant as a source for news, links to COVID-19 updates are included, including to the WHO, CDC, State, County, and City sites. 

## HOW IT’S BUILT (the prototype)

Simple, we didn’t reinvent the wheel.  We used [Umbraco](https://umbraco.com/), which is a highly extendable CMS on the .NET Stack that will work well as the needs change during the pandemic. It is mature, as it has been around since 2005, very developer friendly, and is localizable.

Since each community will have their own set of needs and resources, we wanted something simple enough to train community organizers on how to update the content themselves.

## WHAT'S NEXT

The current prototype needs to be rebuilt as a solution in a version-controlled environment.   

Some experienced eyes will be needed, so experienced Umbraco MVPs will be required to help us with the finer details of working with Umbraco in an Agile team environment. 

User interfaces will need to be created and a mature application framework will need to be used to handle global data, such as memberships, organizations, resources, and the ever expanding needs of the communities.   All of this will need to be available by a consumable API, not only for the UIs, but for other external services.

With [Umbraco](https://umbraco.com/), we will be using [ASP.NET Boilerplate](https://github.com/aspnetboilerplate/aspnetboilerplate), a general purpose application framework especially designed for modern web applications.  It uses already familiar tools and implements the best practices around them to provide a SOLID development experience.  The solution built using it will use the [.Net Core](https://github.com/dotnet/core) Framework.  [React](https://reactjs.org/) will be used for building additional user interfaces.  

### HIGH-LEVEL MILESTONES

1. Properly source-control this project and add Azure Pipelines
2. Create a new HTML5 template for the Umbraco CMS community sites
3. Redesign the React back-office project
4. Offer Help Section
5. Request Help Section
6. Community Resource Guide
7. Local Business Directory
8. Membership Portal / Timebank
9. Consumable API
10. Umbraco "CRN Starter Kit" / Packages



## TEAM

| Contributor      | Role                                 |
| ---------------- | ------------------------------------ |
| Berin Iwlew      | Project Lead                         |
| Adam Brooks      | Project Manager                      |
| Johannes Dumitru | DevOps, Architect                    |
| Alex Vanino      | InfoSec, Public Safety, CheckUpOn.Me |
| Chris Randle     | Umbraco MVP                          |
| Shadi Shawki     | .NET Developer                       |
| John Wang        | .NET Developer                       |
| Paul Ayre        | Resident Australian                  |



### Special thanks to

- [Stephen Scapelliti](https://www.linkedin.com/in/stephen-scapelliti/) of the [Progressive Coders Network](https://progcode.org/) for helping advise on different legal and organizational processes.