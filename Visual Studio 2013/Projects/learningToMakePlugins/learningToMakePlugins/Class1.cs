using System;
using System.Collections.Generic;
using System.Text;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using UnityEngine;
using Rocket.Unturned.Commands;
using Rocket.Core.Logging;
using Rocket.Unturned.Plugins;
using System.Threading.Tasks;
using System.Collections;

namespace learningToMakePlugins
{
    
    #region first command
    public class test : RocketPlugin
    {
        protected override void Load()
        {
            Logger.Log("It has loaded succesfully!");
        }
        protected override void Unload()
        {
            base.Unload();
        }
    }
    public class Class1 : IRocketCommand
    {
        public bool RunFromConsole
        {
            get { return true; }
        }

        public List<string> Aliases
        {
            get { return new List<string>(); ; }
        }

        public string Help
        {
            get { return "a simple test plugin command to say hello!"; }
        }

        public string Name
        {
            get { return "test"; }
        }

        public string Syntax
        {
            get { return "<player>"; }
        }
        public void Execute(RocketPlayer caller, string[] command)
        {
            string awnser = "test";
            System.Random number = new System.Random();
            int result = number.Next(3);
            switch (result)
            {
                case 0:
                    awnser = "herrrro user";
                    break;
                case 1:
                    awnser = "hello world!";
                    break;
                case 2:
                    awnser = "this is result 3...!!!!";
                    break;

            }
            RocketChat.Say(awnser);
        }

    }
    #endregion 
    #region effectcmd
    public class Effectcmd : IRocketCommand
    {
        
        public List<string> Aliases
        {
            get
            {
                return new List<string>(){
                "e" };
            }
        }

        public void Execute(RocketPlayer caller, string[] command)
        {
            if (command.Length == 0 || command.Length > 3)
            {
                RocketChat.Say(caller, "invalid parameters, correct usage is /play <id> <amount of items to play effect> <delay between effects>");
            }
            else
            {
                ushort? id = RocketCommandExtensions.GetUInt16Parameter(command, 0);
                int? loop = RocketCommandExtensions.GetUInt16Parameter(command, 1);
                int? time = RocketCommandExtensions.GetInt32Parameter(command, 2);

                for (int ii = 0; ii < loop.Value; ii++)
                {
                   //caller.TriggerEffect(id.Value);
                   Logger.Log("i am working!");
                }
            }
        }

        public string Help
        {
            get { return "plays the choosen affect"; }
        }

        public string Name
        {
            get { return "play"; }
        }

        public bool RunFromConsole
        {
            get { return true; }
        }

        public string Syntax
        {
            get { return "<id> <amount of times> <delay between effects>"; }
        }
    }
#endregion
    

    
}
