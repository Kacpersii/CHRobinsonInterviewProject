# CHRobinsonInterviewProject
It's a Web API that receives a three-letter code for a North American Country and returns a list of all countries a driver must travel through to go from the United State of America to the destination. It is C# .NET 5.0 application . API is deployed on Azure and works on https://kacperadamiakchrobinson.azurewebsites.net


#Usage
Visiting URL and entering country code, you will get response containing the object with destination country code and list of countries to travel. For example:

https://kacperadamiakchrobinson.azurewebsites.net/PAN
should return:
{"destination":"PAN", "list":["USA","MEX","GTM","HND","NIC","CRI","PAN"]}

and

https://kacperadamiakchrobinson.azurewebsites.net/BLZ
should return:
{"destination":"BLZ","list":["USA","MEX","BLZ"]}

If you enter wrong code, you will get error 404 - not found.
