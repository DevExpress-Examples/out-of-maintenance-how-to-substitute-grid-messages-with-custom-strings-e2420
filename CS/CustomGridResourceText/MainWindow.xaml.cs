using System;
using System.Windows;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Grid;

namespace CustomGridResourceText {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            GridControlResXLocalizer.Active = new CustomGridLocalizer();
            
            InitializeComponent();

            ObservableCollection<Task> data = new ObservableCollection<Task>();
            gridControl1.ItemsSource = data;
        }
    }

    public class Task {
        private DateTime _DueDate = DateTime.Now;
        public DateTime DueDate {
            get {
                return _DueDate;
            }
            set {
                _DueDate = value;
            }
        }
        public string Subject { get; set; }
    }
}