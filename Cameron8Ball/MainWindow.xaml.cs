using System;
using System.Collections.Generic;
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
using System.ComponentModel;

namespace Cameron8Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        Random rand;

        private string answer;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            TextAnswer.DataContext = this;
            rand = new Random();
            answer = "";
        }

        public string Answer {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Answer"));                
            }
        }



        private void AskButtonClick(object sender, RoutedEventArgs e)
        {
            if (CamPic.Visibility == Visibility.Visible) CamPic.Visibility = Visibility.Hidden;
            if (TextAnswer.Visibility == Visibility.Hidden) TextAnswer.Visibility = Visibility.Visible;

            int random = rand.Next(1, 17);

            switch (random)
            {
                case 1:
                    Answer = "THAT SUCKS FOR YOU";
                    break;
               case 2:
                    Answer = "I BET YOU COULD DO THAT IN R";
                    break;
                case 3:
                    Answer = "WHY DON'T YOU JUST AUTOMATE IT?";
                    break;
                case 4:
                    Answer = "JUST LOOK AT THE PEPTIDE SEQUENCE";
                    break;
                case 5:
                    Answer = "THAT'S WHAT YOU GET FOR HAVING KIDS";
                    break;
                case 6:
                    Answer = "GET OUT, GET OUT NOW";
                    break;
                case 7:
                    Answer = "SEE? PEOPLE ARE TERRIBLE";
                    break;
                case 8:
                    Answer = "SOUNDS LIKE IT'S TIME FOR A DRINK";
                    break;
                case 9:
                    Answer = "I'M SURE YOU COULD RUN THOSE ON THE GC-QE...";
                    break;
                case 10:
                    Answer = "LC IS OBSOLETE!";
                    break;
                case 11:
                    Answer = "I DUNNO...";
                    break;
                case 12:
                    Answer = "TRY MULTIALIGN";
                    break;
                case 13:
                    Answer = "THAT'S ALREADY ON DMS";
                    break;
                case 14:
                    Answer = "THAT'S STUPID";
                    break;
                case 15:
                    Answer = "JUST WORK WITH ERIN. YOU'LL GET PUBLISHED.";
                    break;
                case 16:
                    TextAnswer.Visibility = Visibility.Hidden;
                    CamPic.Visibility = Visibility.Visible;
                    break;
                case 17:
                    Answer = "THERE'S A SERIAL KILLER WHO DID THAT";
                    break;
                case 18:
                    Answer = "SUUUURE...";
                    break;
                case 19:
                    Answer = "INSERT PUN HERE";
                    break;
                case 20:
                    Answer = "INSERT OBSCURE LITERATURE REFERENCE HERE";
                    break;
                case 21:
                    Answer = "THAT IS SAD";
                    break;

            }
        }

    }
}
