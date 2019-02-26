namespace SpeechControl
{
    using System.Speech.Recognition;
    using System.Speech.Synthesis;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SpeechSynthesizer _synthesizer;
        private SpeechRecognitionEngine _recognizer;

        public MainWindow()
        {
            InitializeComponent();
            _synthesizer = new SpeechSynthesizer();
            _recognizer = new SpeechRecognitionEngine();
            var recognizablePhrases = new Choices(new[] {"Yes", "No", "How are you?", "rikitiki" });
            var grammar = new Grammar(new GrammarBuilder(recognizablePhrases));
            _recognizer.LoadGrammar(grammar);
            _recognizer.SetInputToDefaultAudioDevice();
        }
         
        private void Speak_OnClick(object sender, RoutedEventArgs e)
        {
            _synthesizer.Speak(_inputText.Text);
        }

        private void Listen_OnClick(object sender, RoutedEventArgs e)   
        {
            var result = _recognizer.Recognize();
            if (result == null) return;
            _inputText.Text = result.Text;
        }
    }
}
