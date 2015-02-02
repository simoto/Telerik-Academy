//* Read in MSDN about the keyword event in C# and how to publish events.
//Re-implement the above using .NET events and following the best practices.

namespace Events
{
    using System;

    public class SomeEvents : EventArgs
    {
        private string message;

        public SomeEvents(string text)
        {
            this.message = text;
        }

        public string Text
        {
            get { return message; }
            set { message = value; }
        }
    }

    class MainMenu
    {
        public event EventHandler<SomeEvents> CustomEvent;

        public void DoSomething()
        {
            // Write some code that does something useful here 
            // then raise the event. You can also raise an event 
            // before you execute a block of code.
            Console.WriteLine("Do something is called!");
            RaiseCustomEvent(new SomeEvents("Did something"));
        }

        // Wrap event invocations inside a protected virtual method 
        // to allow derived classes to override the event invocation behavior 
        protected virtual void RaiseCustomEvent(SomeEvents e)
        {
            // Make a temporary copy of the event to avoid possibility of 
            // a race condition if the last subscriber unsubscribes 
            // immediately after the null check and before the event is raised.
            Console.WriteLine("Raise my event");
            EventHandler<SomeEvents> handler = CustomEvent;

            // Event will be null if there are no subscribers 
            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter
                e.Text += String.Format(" at {0}", DateTime.Now.ToString());

                // Use the () operator to raise the event.
                handler(this, e);
            }
        }

        static void Main()
        {
            MainMenu pub = new MainMenu();
            //Subscriber sub1 = new Subscriber("sub1", pub);
            //Subscriber sub2 = new Subscriber("sub2", pub);
            
            // Call the method that raises the event.
            pub.DoSomething();

            // Keep the console window open
            Console.WriteLine("Press Enter to close this window.");
            Console.ReadLine();
        }
    }
}