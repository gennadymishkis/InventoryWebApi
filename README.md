Inventory WebApi

-------------------
Software versions used in the tutorial

1.	Microsoft Framework 3.5 and up 
2.	Microsoft Visual Studio 2015 
3.	Web API 2
4.	Git repository

-------------------
Project Scope
This application uses a very simple web API to manage a list of items and shows how to support CRUD operations in an HTTP service.


The items API will expose following methods.
Action	HTTP method	Relative URI
1. Get a list of all items   	  GET	    api/InventoryItem
2. Get an item by ID	          GET	    api/InventoryItem/{id}
3. Get an item by name	        GET	    api/InventoryItem?name={name}
4. Create a new item	          POST	  api/InventoryItem
5. Create a shopping cart items	POST	  api/InventoryItem/GetTotal
6. Update an item	              PUT	    api/InventoryItem/{id}
7. Delete an item	              DELETE	api/InventoryItem/{id}

-----------------

To authorize and identify users application uses Account API below

GET api/Account/UserInfo
POST api/Account/Logout
GET api/Account/ManageInfo?returnUrl={returnUrl}&generateState={generateState}
POST api/Account/ChangePassword
POST api/Account/SetPassword
POST api/Account/AddExternalLogin
POST api/Account/RemoveLogin
GET api/Account/ExternalLogin?provider={provider}&error={error}
GET api/Account/ExternalLogins?returnUrl={returnUrl}&generateState={generateState}
POST api/Account/Register
POST api/Account/RegisterExternal

-------------------

All Web API information available on ASP.NET Web API Help Page under API tab

To build API I used ASP.NET MVC 5 Web Application with API2 library

Step to create an Application:
1.	Create Inventory Item Model (an object collection)
2.	Add a Repository/Interface  (to separate the collection from our service implementation)
3.	Add another class to the Model Folder, named ItemRepository. This class will implement the interface created in step 2
4.	Add Web API Controller. The class which would handles HTTP requests from the client.
    Web API controller contains collection of all CRUB operations.

As a final step for API calls data retrieving I used frond end JSON calls to Web API Controller. To build shopping card basket and calculate total JavaScript functions have been used.

------------------

 To Test Inventory Web API Application Unit Test project has been added to solution.  
 
 
