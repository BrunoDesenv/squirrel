# Squirrel

## Projects & Dependencies

![directory](https://user-images.githubusercontent.com/10651746/32789309-a59d18b4-c942-11e7-978b-3407276b58a3.png) Web: Contains screen logic depends on Web Infra

![directory](https://user-images.githubusercontent.com/10651746/32789309-a59d18b4-c942-11e7-978b-3407276b58a3.png) Domain: containing all the domain logic of the solution (for both read and write models). (has no dependency)

![directory](https://user-images.githubusercontent.com/10651746/32789309-a59d18b4-c942-11e7-978b-3407276b58a3.png) Infra: containing the reusable infrastructure code (i.e. non-domain one like adapters, command handler, repositories) for both read and write models. (depends on both Domain and IntegrationModel projects)

![directory](https://user-images.githubusercontent.com/10651746/32789309-a59d18b4-c942-11e7-978b-3407276b58a3.png) Infra.Web: ASP.NET core project hosting the web infrastructure code (like ViewModels, Views and Controllers) which relies on the BookARoom.Infra code. (depends on both Domain, Infra and IntegrationModel projects)

## Project Architecture

![cqrsdiagram](https://user-images.githubusercontent.com/10651746/32789453-059eca50-c943-11e7-9665-e63655a022c2.png)


## Technologies Used

Asp.Net Core 2.0 in the layer Infra <br />
Angular 4 in the layer Web  <br />
MongoDB through azure in the layer Infra.Web <br />
