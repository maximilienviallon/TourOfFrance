﻿using System;
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
using System.Xml;
using TourDeFranceCyclist;

namespace TourOfFrance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            /*
            string name = "";
            string gender = "";
            string country = "";
            string result = "";
            string endPos = "";

            Cyclist c;
            XmlDocument doc = new XmlDocument();
            doc.Load("Cycling-Tour-De-France.xml");
            foreach (XmlNode Node in doc.DocumentElement)
            {
                if (Node.Name == "participant")
                {
                    name = Node.Attributes[0].InnerText;
                    gender = Node.Attributes[1].InnerText;
                    country = Node.Attributes[3].InnerText;

                }
                else if (Node.Name != "results")
                {
                    result = null;
                    endPos = null;
                }
                else if (Node.Name == "result" && Node.Attributes[2].InnerText == "duration")
                {
                    result = Node.Attributes[3].InnerText;

                }
                else if (Node.Name == "result" && Node.Attributes[2].InnerText == "rank")
                {
                    endPos = Node.Attributes[3].InnerText;
                }


                c = new Cyclist(name, gender, country, result, endPos);
                Console.WriteLine(name + " " + gender + " " + country + " " + result + " " + endPos);
                */
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
        

    

