namespace projet_architecture.Core
{
    public class Status:IStatus
    {
        private string status_name;

        public Status(){
            this.status_name = "To Do";
        }

        public string getState()
        {
            return this.status_name;
        }


        public int isDone(){
            this.status_name = "Done";
            return 1;
        }
    }
}