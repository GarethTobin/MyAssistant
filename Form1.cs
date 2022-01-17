using System.Speech.Synthesis;

namespace MyAssistant
{
    public partial class MyAssistantForm : Form
    {

        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        String ReaderSTATE = "Waiting";

        public MyAssistantForm()
        {
            InitializeComponent();
        }

        private void MyAssistantForm_Load(object sender, EventArgs e)
        {
            speechSynthesizer.SpeakCompleted += completed_SpeakCompleted;

            speechSynthesizer.SpeakStarted += Start_SpeakStarted;
        }

        private void Start_SpeakStarted(object? sender, SpeakStartedEventArgs e)
        {
            
        }

        private void completed_SpeakCompleted(object? sender, SpeakCompletedEventArgs e)
        {
            ReaderSTATE = "Waiting";
        }

        private void PlayAndPuaseButton_Click(object sender, EventArgs e)
        {
            switch (ReaderSTATE)
            {
                case "Waiting":
                    string toSpeak = Clipboard.GetText();
                    speechSynthesizer.SpeakAsync(toSpeak);
                    ReaderSTATE = "Playing";
                    break;
                case "Playing":
                    speechSynthesizer.Pause();
                    ReaderSTATE = "Puase";
                    break;
                case "Puase":
                    speechSynthesizer.Resume();
                    ReaderSTATE = "Playing";
                    break;
                case "Resume":
                    break;


                default:
                    break;
            }
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            speechSynthesizer.Pause();
            speechSynthesizer.SpeakAsyncCancelAll();
            ReaderSTATE = "Waiting";
        }
    }
}