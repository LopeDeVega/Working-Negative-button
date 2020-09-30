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

namespace _1.WPF.Intefaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        public MainWindow()
        {
            InitializeComponent();

            txtBox.IsReadOnly = true;

        }

        //---------------------------------------------- B_1 ---------------------------------------------------//
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //If symbol is empty take number 1
            if (symbol == "")
            {
                txtBox.Text = txtBox.Text + 1;
            }

            //If Symbol is not empty take number 2
            else
            {
               txtBox.Text = txtBox.Text + 1;

            }
           


        }


        //---------------------------------------------- B_2 ---------------------------------------------------//

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 2;

            }
            else
            {
                txtBox.Text = txtBox.Text + 2;

            }

        }

        //----------------Button_Clean_1----------------------- B_Clean (C) ------------------------------------//
        private void Button_Clean_1(object sender, RoutedEventArgs e)
        {
           // Console.WriteLine("Has presionado C " );
            
            //Clean textbox
            txtBox.Clear();

            //Clean List
            numf_1.Clear();
            numf_2.Clear();
            
            //Set the values at Cero (0)
            ResultF = 0;
            symbol = "";
            contador = 0;


        }


        //------------------------------------------------ Add (+)--------------------------------//
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {

            //Add number one to de List(numf_1) 
            numf_1.Add(float.Parse(txtBox.Text));

            //TextBox get the value +
            txtBox.Text = "+";
           
            //symbol is = +
            symbol = txtBox.Text;
            //Clean Textbox
            txtBox.Clear();


            //used to make correct calculation when you subtract and then press subtract 
            if (contador > 1)
            {
                numf_2.Clear();
            }



        }
        //------------------------------------------------ Subtract (-) --------------------------------//

        private void Button_Click_Subtract(object sender, RoutedEventArgs e)
        {

            //Add number one to de List(numf_1) 
            numf_1.Add(float.Parse(txtBox.Text));
           
            txtBox.Text = "-";

            symbol = txtBox.Text;

            txtBox.Clear();

            //used to make correct calculation when you add and then press subtract 
            if (contador > 1)
            {
                numf_2.Clear();
            }
        }
        //------------------------------------------------ Multiple (*) --------------------------------//

        private void Button_Click_Multiple(object sender, RoutedEventArgs e)
        {

            //Add number one to de List(numf_1) 
            numf_1.Add(float.Parse(txtBox.Text));

            txtBox.Text = "*";

            symbol = txtBox.Text;

            txtBox.Clear();

            if (contador > 1)
            {
                numf_2.Clear();
            }

        }

        private void Button_Click_Average(object sender, RoutedEventArgs e)
        {
            //Add number one to de List(numf_1) 
            numf_1.Add(float.Parse(txtBox.Text));

            txtBox.Text = "%";

            symbol = txtBox.Text;

            txtBox.Clear();
        }


        //------------------------------------------------ B_Equal (=) --------------------------------//


        private void Button_Igual_1(object sender, RoutedEventArgs e)
        {

            numf_2.Add(float.Parse(txtBox.Text));
         
  
            while (symbol.Length > 0)
            {
               
                contador++;
               
                switch (symbol)
                {
                    case "+":
                        
                        //Console.WriteLine("Soy Contador : " + contador);
                        //When the result was displayed and + is pressed again to add another number;
                        if (contador > 1)
                        {

                            txtBox.Text = (ResultF + numf_2.Sum()).ToString();

                            symbol = "";

                            //Storing the last result
                            ResultF = float.Parse(txtBox.Text);
                        }
                        else
                        {
                           
                            ResultF = (numf_1.Sum() + numf_2.Sum());
                            txtBox.Text = ResultF.ToString();
                            symbol = "";
                            numf_2.Clear();
                        }
                        
                        break;
                        
                    case "-":

                        if (contador > 1)
                        {
                            

                            txtBox.Text = (ResultF - numf_2.Sum()).ToString();
                            
                            //Storing the next result 
                            ResultF =float.Parse(txtBox.Text);

                            symbol = "";
                        }
                        else
                        {
                            

                            ResultF = (numf_1.Sum() - numf_2.Sum());
                            txtBox.Text = ResultF.ToString();
                            symbol = "";
                            numf_2.Clear();
                            Console.WriteLine("Soy el resultado Primera operacon  Restando: " + ResultF);


                        }
                        break;

                    case "*":

                        if (contador > 1)
                        {


                            txtBox.Text = (ResultF * numf_2.Sum()).ToString();

                            //Storing the next result 
                            ResultF = float.Parse(txtBox.Text);

                            symbol = "";
                        }
                        else
                        {


                            ResultF = (numf_1.Sum() * numf_2.Sum());
                            txtBox.Text = ResultF.ToString();
                            symbol = "";
                            numf_2.Clear();
                            

                        }
                        break;
                }


            }

        }

        

   

        //List for number 1
        List<float> numf_1 = new List<float>();
        //List for number 2
        List<float> numf_2 = new List<float>();

        //Store the first calculation when buttton (=) is pressed
        float ResultF;

        //Used to run if  or else into the swich 
        int contador = 0;

        //float number;
  
        //string igual = "=";

        //used to store the symbol entered
        string symbol = "";

      
    }
}
