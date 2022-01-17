using System.Runtime.InteropServices;
using System.Speech.Synthesis;

namespace MyAssistant
{
    public partial class MyAssistantForm : Form
    {

        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        // Hotkey IDs
        const int PLAY_HOTKEY_ID = 111;
        const int STOP_HOTKEY_ID = 112;


        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        bool Playing = false;
        bool Puased = false;

        public MyAssistantForm()
        {
            InitializeComponent();
        }

        private void MyAssistantForm_Load(object sender, EventArgs e)
        {
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, PLAY_HOTKEY_ID, 0, (int)Keys.F24);
            RegisterHotKey(this.Handle, STOP_HOTKEY_ID, 0, (int)Keys.F23);

            speechSynthesizer.SetOutputToDefaultAudioDevice();
            speechSynthesizer.SpeakCompleted += completed_SpeakCompleted;
            speechSynthesizer.SpeakStarted += Start_SpeakStarted;
        }

        // Form Button Functions 

        private void PlayAndPuaseButton_Click(object sender, EventArgs e)
        {
            SpeechPlayAndPuase();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            SpeechStop();
        }

        // Speech Synthesizer

        private void SpeechPlayAndPuase()
        {
            if (!Playing)
            {
                string toSpeak = Clipboard.GetText();
                speechSynthesizer.SpeakAsync(toSpeak);
            } else
            {
                if (!Puased)
                {
                    Puased = true;
                    speechSynthesizer.Pause();
                } else
                {
                    Puased = false;
                    speechSynthesizer.Resume();
                }
            }
        }

        private void SpeechStop()
        {
            Playing = false;
            speechSynthesizer.SpeakAsyncCancelAll();
        }

        private void Start_SpeakStarted(object? sender, SpeakStartedEventArgs e)
        {
            Playing = true;
        }

        private void completed_SpeakCompleted(object? sender, SpeakCompletedEventArgs e)
        {
            Playing = false;
        }
        // Hotkey Actions
        protected override void WndProc(ref Message m)
        {

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == PLAY_HOTKEY_ID)
            {
                SpeechPlayAndPuase();
            }

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == STOP_HOTKEY_ID)
            {
                SpeechStop();
            }

            base.WndProc(ref m);
        }
    }
}