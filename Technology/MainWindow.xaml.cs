using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Technology
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<GameView> Shop { get; set; }
        public ObservableCollection<GameView> Library { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Shop = new ObservableCollection<GameView>()
            {
                new GameView() { id = 1, name = "The Sims", image = "/Resources/The_Sims_Coverart-250x300.png"},
                new GameView() { id = 2, name = "Resident Evil 5", image = "/Resources/resident_evil.jpg"},
                new GameView() { id = 3, name = "Resident Evi: Operation Raccoon City", image = "/Resources/Resident_Evil_ORC_Cover.png"}
            };
            Library = new ObservableCollection<GameView>()
            {
                new GameView() { id = 4, name = "Warcraft III: Reign of Chaos", image = "/Resources/Front-Cover-WC3-Reign-of-Chaos-Night-Elf.jpg"},
                new GameView() { id = 5, name = "Magical Chase", image = "/Resources/magical_chase.jpg"},
                new GameView() { id = 6, name = "Battle Realms", image = "/Resources/BRCover.jpg"}
            };
            gamesList.ItemsSource = Shop;
        }

        private void enterShop(object sender, ExecutedRoutedEventArgs e)
        {
            gamesList.ItemsSource = Shop;
        }

        private void enterLibrary(object sender, ExecutedRoutedEventArgs e)
        {
            gamesList.ItemsSource = Library;
        }
    }
}
