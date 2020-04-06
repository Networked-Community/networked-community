# COVID-19 Response Network

[![GitHub license](https://img.shields.io/github/license/Vertical-OSS/covid-response-network)](https://github.com/Vertical-OSS/covid-response-network/blob/master/LICENSE)[![GitHub issues](https://img.shields.io/github/issues/Vertical-OSS/covid-response-network)](https://github.com/Vertical-OSS/covid-response-network/issues)

## OVERVIEW

In a nutshell, the COVID-19 Response Network is a system to help fulfill the needs of communities during the pandemic.   

The project was originally inspired by Jae Slaby, a local community organizer in Battle Creek, Michigan that put together a local website that linked to a resource guide and timebank on Google Sheets to help people to seek and offer help, with the goal of connecting people together. Putting this together on to a simple to use website looked to be the solution to this, to keep things user friendly and highly accessible.

## WHAT IT DOES (so far)

The current pilot city, [Battle Creek, Michigan](https://battlecreek.covidresponse.net), includes the first features of the project, which includes ways to offer and receive help through various local organizations.  The site also includes a community resource guide so folks can look up essential services and resources in their area.   Although the site is not meant as a source for news, links to COVID-19 updates are included, including to the WHO, CDC, State, County, and City sites. 

## HOW IT’S BUILT

Simple, we didn’t reinvent the wheel.  We used [Umbraco](https://umbraco.com/), which is a highly extendable CMS on the .NET Stack that will work well as the needs change during the pandemic. It is mature, as it has been around since 2005, very developer friendly, and is localizable.

Since each community will have their own set of needs and resources, we wanted something simple enough to train community organizers on how to update the content themselves.

## WHAT'S NEXT

The current prototype needs to be rebuilt as a solution in a version-controlled environment.   

Some experienced eyes will be needed, so experienced Umbraco MVPs will be required to help us with the finer details of working with Umbraco in an Agile team environment. 

The project needs to be able to quickly be cloned and set up by local developers, with a focus on making sure our coding doesn’t conflict with one another's.  With it, we need to set up a proper Continuous Integration/Continuous Deployment pipeline in Azure to deploy these sites, and to update them as changes to the overall software happen. 

### HIGH-LEVEL MILESTONES

1. Properly source-control this project and add Azure Pipelines
2. Create a new [Bootstrap](https://getbootstrap.com/) based template (our current one cannot be redistributed)
3. "Coming Soon" Page  
4. Master Layout 
5. Home Page
6. Contact Page
7. Offer Help Section
8. Request Help Section
9. Community Resource Guide
10. Local Business Directory
11. Membership Portal / Timebank
12. Consumable API
13. Umbraco "CRN Starter Kit" / Packages



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

- [Stephen Scapelliti](https://www.linkedin.com/in/stephen-scapelliti/) of the Progressive Coders Network for helping advise on different legal and organizational processes.