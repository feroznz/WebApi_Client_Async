# WebApi_Client_Async
Consumes web services 

# Asynchronous programming

.Net framework makes it so much easier to work with multi-threaded web application.
The application uses the async and await keywords to enable asynchronous programming and the compiler automatically applies the transformations neccessary to use callbacks in order to avoid blocking threads.
It improves performances by running non-blocking threads in the background.


# Usage

In order to make an asynchronous method( or action in ASP.net MVC world ),we need to mark the method with the async keyword
and create a Task<ActionResult> that is returned.We also need to use the await keyword to make the web service call.

public async Task<ActionResult> IndexAsAsync()
{
   var assets = await _client.GetAsync();
   return View(assets)
}

Visit http://www.asp.net/mvc/overview/performance/using-asynchronous-methods-in-aspnet-mvc-4 
for more information on Asynchronous programming in ASP.net MVC/Web API.
