# ChatServerClientProject

## Table of contents
* [Description](#description)
* [Technologies](#technologies)
* [Features](#features)
	* [To Do](#to-do)
* [Setup](#setup)
	* [Server](#server)
 		* [Server Requirements](#server-requirements)
 	* [client](#client)
  		* [Client Requirements](#client-requirements)
* [License](#license)

## Description
A Client-Server project, what implements a chat.
	
## Technologies
Project is created with:
* EntityFrameworkCore version: 6.0.6
* ApacheThrift version: 0.16.0
* RabbitMQ.Client version: 6.4.0
* log4net version: 2.0.14
* NLog version: 5.0.1

	
## Features
* Login and Logout
* Add new User
* Add new Message
* Set a Friend Request
* Accept or Deny a Friend Request
* Muted and Unmuted a Chat
* Notify:
 	* Other User add a Message in a Chat
 	* Other User send to you a Friend Request
 	* Other User Accept your Friend Request

### To Do
* Configuration file
* Find a Chat by name
* Create groups
* Add Friend to Group
* Accept and Deny an invitation to join in to a Group
* leave a Grup
* See if yours Requests was accepted or deny
* Delete and Block Friends
* List of Blocked Users
* Notify:
 	* Other User send to you a invitation to join in to a Group
 	* Other User left a Group
	* Other User Accept and Deny your Friend Request
 
## Setup

### Server

* Download ServerPublish.zip
* Extract File
* Open the extracted folder
* Execute server.exe

#### Server Requirements

* RabbitMQ Server running at 'localhost' with default settings
 	* [Tutorial](https://www.rabbitmq.com/download.html)

### Client

* Download ClientPublisher.zip
* Extract File
* Open the extracted folder
* Execute client.exe

#### Client Requirements

* Server Project running at 'localhost'

## License
[MIT](https://choosealicense.com/licenses/mit/)