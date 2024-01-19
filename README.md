# Records Management
This project helps push data into a database/file by validating and filtering it based on its model objects.
### Overview
* This is an ASP.NET MVC project with **[donet framework](https://github.com/Harshachennoor/RecordManagement/blob/master/RecordsManagement.csproj#L4)**. 
* Packages used in this project are listed in [RecordsManagement.csproj](https://github.com/Harshachennoor/RecordManagement/blob/master/RecordsManagement.csproj#L10) with version numbers.
* Controllers: <br>
  The CRUD operations actions are implemented in [Record Controller](https://github.com/Harshachennoor/RecordManagement/blob/master/Controllers/RecordController.cs)<br>
  Filtering the records(data) actions where mentioned in [Home Controller](https://github.com/Harshachennoor/RecordManagement/blob/master/Controllers/HomeController.cs)<br>
* Code property only takes unique value; [Validation](https://github.com/Harshachennoor/RecordManagement/blob/master/Controllers/RecordController.cs#L47) is peformed using [Session](https://github.com/Harshachennoor/RecordManagement/blob/master/Controllers/RecordController.cs#L33).
* [Views](https://github.com/Harshachennoor/RecordManagement/tree/master/Views)>[Record](https://github.com/Harshachennoor/RecordManagement/tree/master/Views/Record) > [Alter](https://github.com/Harshachennoor/RecordManagement/blob/master/Views/Record/Alter.cshtml) contains the HTML code which is helpful to add or edit the data.

### Getting Started:

  Download the project and use the following CLI commands in the terminal to view the Output.<br>
  
  ```dotnet restore```<br>
  ```dotnet build```<br>
  ```dotnet run```<br>
  
  See the info: which contains the localhost link with port number

### Sample Outputs 
* Home Page:
  ![Home page View](https://github.com/Harshachennoor/RecordManagement/blob/master/SampleScreenShots/HomePage.png)<br>
* Alter(add) Validation:
  ![Add validation](https://github.com/Harshachennoor/RecordManagement/blob/master/SampleScreenShots/AddValidation.png)<br>
* Alter(update) Validation:
  ![Update Validation](https://github.com/Harshachennoor/RecordManagement/blob/master/SampleScreenShots/Updatevalidation.png)<br>
* Records based on Filters:
  ![Data based on the filter values](https://github.com/Harshachennoor/RecordManagement/blob/master/SampleScreenShots/FilteredRecords.png)
