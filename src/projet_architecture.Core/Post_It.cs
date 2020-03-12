using System;

namespace projet_architecture.Core
{
    public class Post_It
    {
        private string task_name;
        private IClock clock;
        private IStatus status;

        public Post_It(string task_name, IClock clock, IStatus status){
            this.task_name = task_name;
            this.clock = clock;
            this.status = status;
        }

        public string getPost_It(){
            return "TASK: " + this.task_name + ", CREATION DATE: " + this.clock.createdAT.ToString() + ", Status: " + this.status.getState();
        }

        public int isDone(){
            return status.isDone();
        }
    }
}