# CHRobinsonInterviewProject
It's a Web API that receives a three-letter code for a North American Country and returns a list of all countries a driver must travel through to go from the United State of America to the destination. It is C# .NET 5.0 application. API is deployed on Azure and you can access it on https://kacperadamiakchrobinson.azurewebsites.net

![image](https://github.com/Kacpersii/CHRobinsonInterviewProject/assets/57803178/06dc593e-c0a2-45f6-8eab-dcdb53b4499e)

- CAN – Canada borders the United States
- USA – The United States borders Canada and Mexico
- MEX – Mexico borders the United States, Guatemala, and Belize
- BLZ – Belize borders Mexico and Guatemala
- GTM – Guatemala borders Mexico, Belize, El Salvador, and Honduras
- SLV – El Salvador borders Guatemala and Honduras
- HND – Honduras borders Guatemala, El Salvador, and Nicaragua
- NIC – Nicaragua borders Honduras and Costa Rica
- CRI – Costa Rica borders Nicaragua and Panama
- PAN – Panama borders Costa Rica


## Usage

Visiting URL and entering country code, you will get response containing the object with destination country code and list of countries to travel. For example:

https://kacperadamiakchrobinson.azurewebsites.net/PAN
should return:
{"destination":"PAN", "list":["USA","MEX","GTM","HND","NIC","CRI","PAN"]}

and

https://kacperadamiakchrobinson.azurewebsites.net/BLZ
should return:
{"destination":"BLZ","list":["USA","MEX","BLZ"]}

If you enter wrong code, you will get error 404 - not found.
