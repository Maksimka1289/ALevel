namespace ALevel_HW16
{
    public class MessageBox
    {
        public event EventHandler<WindowClosedEventArgs> WindowClosed;
        public async void Open()
        {
            Console.WriteLine("Window is open");
            
            await Task.Delay(3000);

            Random random = new Random();
            State randomState = random.Next(2) == 0 ? State.Ok : State.Cancel;

            OnWindowClosed(randomState);

            Console.WriteLine($"Window was closed by the user with state: {randomState}");
        }
        protected virtual void OnWindowClosed(State state)
        {
            WindowClosed?.Invoke(this, new WindowClosedEventArgs(state));
        }
    }
}
