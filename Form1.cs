using System.Runtime.InteropServices;
using System.Speech.Synthesis;

namespace MyAssistant
{
    public partial class MyAssistantForm : Form
    {

        // DLL libraries used to manage hotkeys
        [DllImport("User32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("User32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        // Hotkey IDs
        const int PLAY_HOTKEY_ID = 111;
        const int STOP_HOTKEY_ID = 112;

        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        // Bools for the Speech Synthesizer 
        bool Playing = false;
        bool Puased = false;
        bool Hovering = false;


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


            notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.Add("Close", null, OnCloseClick);
            notifyIcon.ContextMenuStrip.Items.Add("Open", null, OnOpenClick);
        }


        // NotifyIcon and Tray controls
        private void OnCloseClick(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnOpenClick(object? sender, EventArgs e)
        {
            OpenFromTray();
        }

        private void MyAssistantForm_SizeChanged(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFromTray();
        }

        private void OpenFromTray()
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
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
                if (Puased)
                {
                    Puased = false;
                    speechSynthesizer.Resume();
                }
                speechSynthesizer.SpeakAsync(toSpeak);
                PlayAndPuaseImage();
            }
            else
            {
                if (!Puased)
                {
                    Puased = true;
                    speechSynthesizer.Pause();
                    PlayAndPuaseImage();
                } else
                {
                    Puased = false;
                    speechSynthesizer.Resume();
                    PlayAndPuaseImage();
                }
            }
        }

        private void SpeechStop()
        {
            Playing = false;
            speechSynthesizer.SpeakAsyncCancelAll();
            PlayAndPuaseButton.Image = Properties.Resources.ResourceManager.GetObject("PlayButton") as Image;
        }

        private void Start_SpeakStarted(object? sender, SpeakStartedEventArgs e)
        {
            Playing = true;
            PlayAndPuaseImage();
        }

        private void completed_SpeakCompleted(object? sender, SpeakCompletedEventArgs e)
        {
            Playing = false;
            PlayAndPuaseButton.Image = Properties.Resources.ResourceManager.GetObject("PlayButton") as Image;
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

        private void MyAssistantForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Hover event for PlayAndPuaseButton
        private void PlayAndPuaseButton_MouseEnter(object sender, EventArgs e)
        {
            Hovering = true;
            PlayAndPuaseImage();
        }
        private void PlayAndPuaseButton_MouseLeave(object sender, EventArgs e)
        {
            Hovering = false;
            PlayAndPuaseImage();
        }

        // Hover event for StopButton
        private void StopButton_MouseEnter(object sender, EventArgs e)
        {
            StopButton.Image = Properties.Resources.ResourceManager.GetObject("StopButtonHover") as Image;
        }
        private void StopButton_MouseLeave(object sender, EventArgs e)
        {
            StopButton.Image = Properties.Resources.ResourceManager.GetObject("StopButton") as Image;
        }

        // Hover event for closeButton
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.ResourceManager.GetObject("CloseButtonHover") as Image;
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.ResourceManager.GetObject("CloseButton") as Image;
        }

        // Hover event for minButton
        private void minButton_MouseEnter(object sender, EventArgs e)
        {
            minButton.Image = Properties.Resources.ResourceManager.GetObject("MinButtonHover") as Image;
        }
        private void minButton_MouseLeave(object sender, EventArgs e)
        {
            minButton.Image = Properties.Resources.ResourceManager.GetObject("MinButton") as Image;
        }

        // PlayAndPuaseButton Hover change depending on the bools for Speech Synthesizer
        private void PlayAndPuaseImage()
        {

            if (Hovering)
            {
                if (!Playing) PlayAndPuaseButton.Image = Properties.Resources.ResourceManager.GetObject("PlayButtonHover") as Image;
                else
                {
                    if (!Puased) PlayAndPuaseButton.Image = Properties.Resources.ResourceManager.GetObject("PuaseButtonHover") as Image;
                    else PlayAndPuaseButton.Image = Properties.Resources.ResourceManager.GetObject("ResumeButtonHover") as Image;
                }

            }
            else
            {
                if (!Playing) PlayAndPuaseButton.Image = Properties.Resources.ResourceManager.GetObject("PlayButton") as Image;
                else
                {
                    if (!Puased) PlayAndPuaseButton.Image = Properties.Resources.ResourceManager.GetObject("PuaseButton") as Image;
                    else PlayAndPuaseButton.Image = Properties.Resources.ResourceManager.GetObject("ResumeButton") as Image;

                }

            }
        }
    }
}