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

namespace dotNet5780_03_2088
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Host currentHost;
        List<Host> hostsList;

        public MainWindow()
        {
            InitializeComponent();

            hostsList = new List<Host>()
            {
                new Host()
                {
                    HostName = "Abraham",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "Abraham 1",
                            Rooms = 2,
                            IsSwimmimgPool = false,
                            Uris = new List<string>()
                            {
                                "https://cdn.pixabay.com/photo/2016/06/24/10/47/architecture-1477041__340.jpg",
                                "https://cdn.pixabay.com/photo/2017/03/22/17/39/kitchen-2165756__340.jpg"
                            }
                        },
                         new HostingUnit()
                        {
                            UnitName = "Abraham 2",
                            Rooms = 3,
                            IsSwimmimgPool = false,
                            Uris = new List<string>()
                            {
                                "https://cdn.pixabay.com/photo/2016/11/18/17/46/architecture-1836070__340.jpg",
                                "https://cdn.pixabay.com/photo/2017/09/09/18/25/living-room-2732939__340.jpg"
                            }
                        },
                         new HostingUnit()
                        {
                            UnitName = "Abraham 3",
                            Rooms = 3,
                            IsSwimmimgPool = false,
                            Uris = new List<string>()
                            {
                                "https://cdn.pixabay.com/photo/2017/11/16/19/29/spring-2955582__340.jpg",
                                "https://cdn.pixabay.com/photo/2017/01/07/17/48/interior-1961070__340.jpg"
                            }
                        }
                    }
                },
                new Host()
                {
                    HostName = "Itzhak",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "Itzhak 1",
                            Rooms = 3,
                            IsSwimmimgPool = false,
                            Uris = new List<string>()
                            {
                                "https://cdn.pixabay.com/photo/2013/08/30/12/56/holiday-house-177401__340.jpg",
                                "https://cdn.pixabay.com/photo/2016/12/30/07/59/kitchen-1940174__340.jpg"
                            }
                        },
                         new HostingUnit()
                        {
                            UnitName = "Itzhak 2",
                            Rooms = 4,
                            IsSwimmimgPool = true,
                            Uris = new List<string>()
                            {
                                "https://cdn.pixabay.com/photo/2014/07/10/17/18/large-home-389271__340.jpg",
                                "https://cdn.pixabay.com/photo/2017/06/13/22/42/kitchen-2400367__340.jpg"
                            }
                        }
                    }
                },
                new Host()
                {
                    HostName = "Jacob",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "Jacob 1",
                            Rooms = 2,
                            IsSwimmimgPool = true,
                            Uris = new List<string>()
                            {
                                "https://cdn.pixabay.com/photo/2017/05/31/10/23/manor-house-2359884__340.jpg",
                                "https://cdn.pixabay.com/photo/2017/07/09/03/19/kitchen-2486092__340.jpg"
                            }
                        },
                         new HostingUnit()
                        {
                            UnitName = "Jacob 2",
                            Rooms = 3,
                            IsSwimmimgPool = true,
                            Uris = new List<string>()
                            {
                                "https://cdn.pixabay.com/photo/2018/03/06/04/16/swimming-pool-3202525__340.jpg",
                                "https://cdn.pixabay.com/photo/2017/12/31/09/21/room-3051846__340.jpg"
                            }
                        }
                    }
                }
            };

            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;
        }

        private void cbHostList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeHost(cbHostList.SelectedIndex);
        }
        private void InitializeHost(int index)
        {
            MainGrid.Children.RemoveRange(1, 3);
            currentHost = hostsList[index];
            UpGrid.DataContext = currentHost;
            for (int i = 0; i < currentHost.Units.Count; i++)
            {
                HostingUnitUserControl a = new HostingUnitUserControl(currentHost.Units[i]);
                MainGrid.Children.Add(a);
                Grid.SetRow(a, i + 1);
            }
        }
    }
}
