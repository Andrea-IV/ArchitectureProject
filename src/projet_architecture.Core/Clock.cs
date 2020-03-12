using System;

namespace projet_architecture.Core
{
    public class Clock:IClock
    {
        private DateTime createdAT;

        public Clock(){
            this.createdAT = DateTime.Now;
        }

        DateTime IClock.createdAT { get => this.createdAT;}
    }
}