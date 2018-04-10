﻿using System.Collections.Generic;
using Master.Commands.Core;
using Shared;

namespace Master.Commands
{
    internal class StopConnection : IMasterCommand
    {
        public string name { get; } = "stopconnection";

        public string description { get; } = "Stop the infected host from trying to connect to you.\nIt will still connect back to the master botnet server to get new commands; if you specified it.";

        public bool isLocal { get; } = false;

        public List<string> validArguments { get; } = null;


        public void Process(List<string> args) => throw new ExitException();
    }
}