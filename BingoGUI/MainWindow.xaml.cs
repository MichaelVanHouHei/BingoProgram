using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BingoModel;

namespace BingoGUI
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<BingoNumber> bingoNumbersList ;
        public int min
        {
            get { return (int)GetValue(minProperty); }
            set { SetValue(minProperty, value); }
        }

        // Using a DependencyProperty as the backing store for min.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty minProperty =
            DependencyProperty.Register("min", typeof(int), typeof(MainWindow), new PropertyMetadata(1));



        public int max
        {
            get { return (int)GetValue(maxProperty); }
            set { SetValue(maxProperty, value); }
        }

        // Using a DependencyProperty as the backing store for max.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty maxProperty =
            DependencyProperty.Register("max", typeof(int), typeof(MainWindow), new PropertyMetadata(75));


       
         BingoGenerator generator;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            generator = new BingoGenerator(min, max);
            bingoNumbersList = new ObservableCollection<BingoNumber>(generator.bingoNumbers.ToList());
            panel.ItemsSource = bingoNumbersList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            generator = new BingoGenerator(min, max);
            bingoNumbersList = new ObservableCollection<BingoNumber>(generator.bingoNumbers.ToList());
            panel.ItemsSource = bingoNumbersList;
        }

        private void GenClick(object sender, RoutedEventArgs e)
        {
            if (generator == null)
            {
                MessageBox.Show("請先按生成");
                return;
            }

            if (generator.Generate())
            {
                bingoNumbersList = new ObservableCollection<BingoNumber>(generator.bingoNumbers.ToList());
                panel.ItemsSource = bingoNumbersList;
            }
            else
            {
                MessageBox.Show("抽完");
            }
           
        }
    }
}
