namespace projet_architecture.Core
{
    public interface IStatus
    {
        string getState();

        int isDone();
    }
}