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

namespace Assignment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Xdir = 0; 
        private int Ydir = 0;
        private bool penDown = false;
        private const int gridSize = 50;
        private int[][] floor; 

        public MainWindow()
        {
            
            InitializeComponent();
            InitializeFloor();
        }
        private void InitializeFloor()
        {
            floor = new int[gridSize][];
            for(int i = 0; i<gridSize; i++)
            {
                floor[i] = new int[gridSize];
            }
        }
        private void ExecuteCommand(string command)
        {
            string[] parts = command.Split(',');
            int cmd = int.Parse(parts[0]);

            switch (cmd)
            {
                case 1:
                    penDown = true; break; 
                case 2:
                    penDown = false; break;
                case 3:
                    TurnRight(); break;
                case 4:
                    TurnLeft(); break;
                case 5:
                    int steps = int.Parse(parts[1]); break;
                case 6:
                    ClearGrid();
                    break;
            

            }
               
        }

        
    }
}
