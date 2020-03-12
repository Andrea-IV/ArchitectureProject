using System;
using System.Collections.Generic;

namespace projet_architecture.Core
{
    public class TerminalInterface
    {
        private List<Post_It> task_list;

        TerminalInterface(){
            Interfaceloop();
        }

        private int Interfaceloop(){
            do{
                Console.WriteLine("MENU");
            }while(true);
        }
    }
}