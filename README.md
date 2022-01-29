# Comar .Net Helper Pack

Simple integration helper for sending Slack notifications via Comar.

## IMPORTANT

Currently, Comar does not have public API access yet. Please talk with one of the members of the https://github.com/comarbot organization.

## Installing


```shell
  Install-Package Comar -Version 1.0.0
```

## Usage

```cs
using Comar;
```

Send a basic notification

```cs
SendMessageResource sendMessageResource = new SendMessageResource
{
    Channel = "#general",
    Message = "Hello World"
};

var IsSuccessful = ComarMessageHalper.Ping(sendMessageResource);

if(IsSuccessful)
    Console.WriteLine("Message sent successfully");
  

```

Send a notification with block quote
 

```cs
SendMessageResource sendMessageResource = new SendMessageResource
{
    Channel = "#general",
    Message = "Hello World",
    BlockquoteColor = "#00FF00"
};

var IsSuccessful = ComarMessageHalper.Ping(sendMessageResource);

if (IsSuccessful)
    Console.WriteLine("Message sent successfully");

```

Send a notification with additional text
 
```cs
SendMessageResource sendMessageResource = new SendMessageResource
{
    Channel = "#general",
    Message = "Hello World",
    BlockquoteColor = "#00FF00",
    AdditionalTexts = new List<string>
    {
        "This is an additional text",
    }
};

var IsSuccessful = ComarMessageHalper.Ping(sendMessageResource);

if (IsSuccessful)
    Console.WriteLine("Message sent successfully");

```

Send a notification with buttons as a additional text
 
 
```cs
SendMessageResource sendMessageResource = new SendMessageResource
{
    Channel = "#general",
    Message = "Hello World",
    BlockquoteColor = "#00FF00",
    AdditionalTexts = new List<string>
    {
        "This is an additional text",
        "<https://emreceyhan.com | click me>"
    }
};

var IsSuccessful = ComarMessageHalper.Ping(sendMessageResource);

if (IsSuccessful)
    Console.WriteLine("Message sent successfully");

```




## TODO

* Publish as a nuget pack



## Licensing

This project is licensed under MIT license. 

