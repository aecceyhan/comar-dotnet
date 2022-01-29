using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Comar;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ComarMessageHelper.Authentication = "123456";
            ComarMessageHelper.ServiceURL = "http://comar-dev-elb-928123545.eu-central-1.elb.amazonaws.com";
            //Also, you can set up Slack Bot Token when you initialise the request.
            //ComarMessageHelper.SlackBotToken = "xb......";


            AdditionalTextWithButtonsMesssageExample();

        }

        public static void BasicMesssageExample()
        {
            SendMessageResource sendMessageResource = new SendMessageResource
            {
                Channel = "#general",
                Message = "Hello World"
            };

            var IsSuccessful = ComarMessageHelper.Ping(sendMessageResource);

            if(IsSuccessful)
                Console.WriteLine("Message sent successfully");
        }

        public static void BlockquoteMesssageExample()
        {
            SendMessageResource sendMessageResource = new SendMessageResource
            {
                Channel = "#general",
                Message = "Hello World",
                BlockquoteColor = "#00FF00"
            };

            var IsSuccessful = ComarMessageHelper.Ping(sendMessageResource);

            if (IsSuccessful)
                Console.WriteLine("Message sent successfully");
        }

        public static void AdditionalTextMesssageExample()
        {
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

            var IsSuccessful = ComarMessageHelper.Ping(sendMessageResource);

            if (IsSuccessful)
                Console.WriteLine("Message sent successfully");
        }

        public static void AdditionalTextWithButtonsMesssageExample()
        {
            SendMessageResource sendMessageResource = new SendMessageResource
            {
                Channel = "#general",
                Message = "Hello World",
                BlockquoteColor = "#00FF00",
                AdditionalTexts = new List<string>
                {
                    "This is an additional text",
                    "<https://emreceyhan.com | click me>",
                }
            };

            var IsSuccessful = ComarMessageHelper.Ping(sendMessageResource);

            if (IsSuccessful)
                Console.WriteLine("Message sent successfully");
        }
    }
}
