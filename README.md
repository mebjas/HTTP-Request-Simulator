HTTP request simulator
==========================

Simple Windows Form Application to simulate the HTTP GET or POST request to a server page (or localhost). Shows the raw result of the request

Features
============
- [x] Send a `GET` or `POST` request
- [x] Send QUERY PARAMETERS with request
- [x] View raw output of the request
- [x] Run Regular Expression test on ouput and view matches in seperate form
- [x] View Request header
- [x] View Response header
- [ ] Set cookies
- 
Headers looks like
````c#
==========REQUEST HEADER==========
Content-Type: application/x-www-form-urlencoded
Host: cistoner.org
Content-Length: 7
Expect: 100-continue
==========RESPONSE HEADER==========
Pragma: no-cache
Vary: Accept-Encoding
Access-Control-Allow-Origin: *
Transfer-Encoding: chunked
Cache-Control: no-store, no-cache, must-revalidate, post-check=0, pre-check=0
Content-Type: text/html
Date: Thu, 29 May 2014 15:35:22 GMT
Expires: Thu, 19 Nov 1981 08:52:00 GMT
Set-Cookie: PHPSESSID=*************************; path=/
Server: Apache
````

How to use
============
You can download the executable from [sourceforge](https://sourceforge.net/projects/getpostrequestsimulator/)

How to build
==============
1. Clone the repository
2. Open in Visual Studio, by selecting `formSimulator.sln`
3. Now you have the code, hack it and send a pull!
