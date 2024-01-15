namespace Chess.View.Window
{
    using System.Windows;
    using Chess.Model.Rule;

    /// <summary>
    /// Interaction logic for GameSelectionWindow.xaml
    /// </summary>
    public partial class GameSelectionWindow : Window
    {
        StandardRulebook rules = new StandardRulebook();

        public GameSelectionWindow()
        {
            InitializeComponent();
        }

        private void Standard_Click(object sender, RoutedEventArgs e)
        {
            rules.Chess960False();
            MainWindow main = new MainWindow();
            main.Show();

            this.Hide();
        }

        private void Chess960_Click(object sender, RoutedEventArgs e)
        {
            rules.Chess960True();
            MainWindow main = new MainWindow();
            main.Show();

            this.Hide();
        }
    }
}
