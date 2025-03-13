namespace SynchornizationContextusingUI
{
    public partial class Form1 : Form
    {
        private Button button = new Button { Text = "Start Task" };
        private Label label = new Label { Top = 50, Width = 200 };
        private SynchronizationContext _syncContext;

        public Form1()
        {
            _syncContext = SynchronizationContext.Current; // Capture the UI thread's context
            button.Click += StartTask;
            Controls.Add(button);
            Controls.Add(label);
        }

        private void StartTask(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(2000); // Simulate background work

                // Post the update to the UI thread
                _syncContext.Post(_ => label.Text = "Task Completed!", null);
            });
        }
    }
}
