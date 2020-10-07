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

        //----------------------------------------------------- B_0 ---------------------------------------------------//


        private void Button_Click_Cero(object sender, RoutedEventArgs e)
        {
            //if symbol is empty add the number to List num_1
            if (symbol == "")
            {
                txtBox.Text = txtBox.Text + 0;
                num_1.Add(double.Parse(txtBox.Text));

            }

            //else clear the textbox and add the number to List num_2
            else
            {
               // txtBox.Clear();
                txtBox.Text = txtBox.Text + 0;
                num_2.Add(double.Parse(txtBox.Text));



            }
        }

        //----------------------------------------------------- B_1 ---------------------------------------------------//
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if symbol is empty add the number to List num_1
            if (symbol == "")
            {
                txtBox.Text = txtBox.Text + 1;
                num_1.Add(double.Parse(txtBox.Text));

            }

            //else clear the textbox and add the number to List num_2

            else

            {
              
                    txtBox.Text = txtBox.Text + 1;
                    num_2.Add(double.Parse(txtBox.Text));
                
            }
           


        }


        //------------------------------------------------------- B_2 ---------------------------------------------------//

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            
            //if symbol is empty add the number to List num_1
            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 2;
                num_1.Add(double.Parse(txtBox.Text));


            }
                        
            //else clear the textbox and add the number to List num_2
            else
            {
                txtBox.Clear();
                txtBox.Text = txtBox.Text + 2;
                num_2.Add(double.Parse(txtBox.Text));


            }

        }
        //------------------------------------------------------- B_3 ---------------------------------------------------//

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 3;
                num_1.Add(double.Parse(txtBox.Text));
            }
            else
            {
                
                txtBox.Text = txtBox.Text + 3;
                num_2.Add(double.Parse(txtBox.Text));


            }
        }

        //------------------------------------------------------- B_4 ---------------------------------------------------//

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 4;
                num_1.Add(double.Parse(txtBox.Text));



            }
            else
            {
                txtBox.Text = txtBox.Text + 4;
                num_2.Add(double.Parse(txtBox.Text));


            }

        }

        //------------------------------------------------------- B_5 ---------------------------------------------------//

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {


            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 5;
                num_1.Add(double.Parse(txtBox.Text));

            }
            else
            {
                txtBox.Text = txtBox.Text + 5;
                num_2.Add(double.Parse(txtBox.Text));


            }
        }

        //------------------------------------------------------- B_6 ---------------------------------------------------//

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 6;
                num_1.Add(double.Parse(txtBox.Text));

            }
            else
            {
               
                
                txtBox.Text = txtBox.Text + 6;
                num_2.Add(double.Parse(txtBox.Text));

            }

        }

        //------------------------------------------------------- B_7 ---------------------------------------------------//

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 7;
                num_1.Add(double.Parse(txtBox.Text));


            }
            else
            {
                txtBox.Text = txtBox.Text + 7;
                num_2.Add(double.Parse(txtBox.Text));


            }

        }

        //------------------------------------------------------- B_8 ---------------------------------------------------//


        private void Btn8_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 8;
                num_1.Add(double.Parse(txtBox.Text));


            }
            else
            {
                txtBox.Text = txtBox.Text + 8;
                num_2.Add(double.Parse(txtBox.Text));


            }
        }

        //------------------------------------------------------- B_9 ---------------------------------------------------//


        private void Btn9_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 9;
                num_1.Add(double.Parse(txtBox.Text));


            }
            else
            {
                txtBox.Text = txtBox.Text + 9;
                num_2.Add(double.Parse(txtBox.Text));

            }
        }

      

        //-------------------------------------------------------------- B_Clean (C) ------------------------------------//
        private void Button_Clean_1(object sender, RoutedEventArgs e)
        {
           // Console.WriteLine("Has presionado C " );
            
            //Clean textbox
            txtBox.Clear();

            //Clean List
            num_1.Clear();
            num_2.Clear();
            
            //Set the values at Cero (0)
            ResultF = 0;
            symbol = "";
            contador = 0;

        }
        //------------------------------------------------------------- B_Clean (CE) ------------------------------------//

        private void Button_Click_CE(object sender, RoutedEventArgs e)
        {

            //Remove the last number inserted into the List num_2
            num_2.RemoveAt(num_2.Count - 1);

            txtBox.Clear();

        }

        //---------------------------------------------------------------- B_Point (.) ------------------------------------//
        private void Button_Click_Point(object sender, RoutedEventArgs e)
        {

            txtBox.Text = txtBox.Text + ".";
        }

        //---------------------------------------------------------------- B_Negative (+) ------------------------------------//

        private void Button_Click_Negative(object sender, RoutedEventArgs e)
        {

            //When not number / turn the number in a negative value
            if (txtBox.Text == "")
            {

                txtBox.Text = "-";
               

            }
            //When a number value is already inserted



            if (txtBox.Text != "-" && symbol == "")
            {
                //Last number of list num_1 is multiplied for (-1) converting the value in a negative number
                num_1[num_1.Count - 1] = num_1[num_1.Count - 1] * (-1);
                txtBox.Text = num_1[num_1.Count - 1].ToString();

            }
            if (txtBox.Text != "" && symbol != "")
            {



                //Last number of list num_2 is multiplied for (-1) converting the value in a negative number
                num_2[num_2.Count - 1] = num_2[num_2.Count - 1] * (-1);
                txtBox.Text = num_2[num_2.Count - 1].ToString();

            }

            if (ResultF != 0)
            {

                txtBox.Text = (ResultF * -1).ToString();
                ResultF = double.Parse(txtBox.Text);
                Console.WriteLine("Reultado conseguido");
                Console.WriteLine(ResultF);
            }

        }


        //----------------------------------------------------- Add (+)--------------------------------//
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            //if which prevent to break the app if + symbol is pressed before any number inserted
            if (symbol == "+" )
            {
                //it shows the last number inserted into the List num_2
                txtBox.Text = num_2[num_2.Count - 1].ToString();
               

            }
            //when symbol is empty add the symbol 
            else
            {
                //Add number one to de List(num_1) 
                //num_1.Add(double.Parse(txtBox.Text));

                //TextBox get the value +
                //txtBox.Text = "+";

                //symbol is = +
                symbol = "+";
              


                //used to make correct calculation when you subtract and then press subtract 
                if (contador > 1)
                {
                    num_2.Clear();
                }

            }
            txtBox.Clear();

        }
        //------------------------------------------------ ---Subtract (-) --------------------------------//

        private void Button_Click_Subtract(object sender, RoutedEventArgs e)
        {
            if (symbol == "-")
            {

                //it shows the last number inserted into the List num_2
                txtBox.Text = num_2[num_2.Count - 1].ToString();

            }
            else
            {
                symbol = "-";


                //used to make correct calculation when you add and then press subtract 
                if (contador > 1)
                {
                    num_2.Clear();
                }
            
            }
            txtBox.Clear();

        }
        //------------------------------------------------------ Multiple (*) --------------------------------//

        private void Button_Click_Multiple(object sender, RoutedEventArgs e)
        {

            if (symbol == "*")
            {
                //it shows the last number inserted into the List num_2
                txtBox.Text = num_2[num_2.Count - 1].ToString();

            }
            else
            {

                symbol = "*";


                if (contador > 1)
                {
                    num_2.Clear();
                }
            }
            txtBox.Clear();

        }
        //-------------------------------------------------------- Divide (/) --------------------------------//

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {

            if (symbol == "/")
            {

                //it shows the last number inserted into the List num_2
                txtBox.Text = num_2[num_2.Count - 1].ToString();

            }
            else
            {


                symbol = "/";


                if (contador > 1)
                {
                    num_2.Clear();
                }
            }
            txtBox.Clear();

        }

        //------------------------------------------------------------B_Average (%) --------------------------------//

        private void Button_Click_Average(object sender, RoutedEventArgs e)
        {

            if (symbol == "%")
            {

                //it shows the last number inserted into the List num_2
                txtBox.Text = num_2[num_2.Count - 1].ToString();

            }
            else
            {


                symbol = "%";



                if (contador > 1)
                {
                    num_2.Clear();
                }
            }
            txtBox.Clear();

        }


        //------------------------------------------------------------- B_Equal (=) --------------------------------//


        private void Button_Igual_1(object sender, RoutedEventArgs e)
        {

           
         
  
            while (symbol.Length > 0)
            {
               
                contador++;
               
                switch (symbol)
                {
                    case "+":
                        
                       
                        //When the result was displayed and + is pressed again to add another number;
                        if (contador > 1)
                        {

                            txtBox.Text = (ResultF + num_2.Sum()).ToString();

                            symbol = "";

                            //Storing the last result
                            ResultF = double.Parse(txtBox.Text);
                        }
                        else
                        {
                           
                            ResultF = (num_1.Sum() + num_2.Sum());
                            txtBox.Text = ResultF.ToString();
                            symbol = "";
                            num_2.Clear();
                        }
                        
                        break;
                        
                    case "-":

                        if (contador > 1)
                        {
                            

                            txtBox.Text = (ResultF - num_2.Sum()).ToString();
                            
                            //Storing the next result 
                            ResultF =double.Parse(txtBox.Text);

                            symbol = "";
                        }
                        else
                        {
                            

                            ResultF = (num_1.Sum() - num_2.Sum());
                            txtBox.Text = ResultF.ToString();
                            symbol = "";
                            num_2.Clear();
                            Console.WriteLine("Soy el resultado Primera operacon  Restando: " + ResultF);


                        }
                        break;

                    case "*":

                        if (contador > 1)
                        {


                            txtBox.Text = (ResultF * num_2.Sum()).ToString();

                            //Storing the next result 
                            ResultF = double.Parse(txtBox.Text);

                            symbol = "";
                        }
                        else
                        {


                            ResultF = (num_1.Sum() * num_2.Sum());
                            txtBox.Text = ResultF.ToString();
                            symbol = "";
                            num_2.Clear();
                            

                        }
                        break;

                    case "/":

                        if (contador > 1)
                        {


                            txtBox.Text = (ResultF / num_2.Sum()).ToString();

                            //Storing the next result 
                            ResultF = double.Parse(txtBox.Text);

                            symbol = "";
                        }
                        else
                        {


                            ResultF = (num_1.Sum() / num_2.Sum());
                            txtBox.Text = ResultF.ToString();
                            symbol = "";
                            num_2.Clear();


                        }
                        break;

                    case "%":

                        if (contador > 1)
                        {


                            txtBox.Text = ((ResultF * num_2.Sum())/100).ToString();

                            //Storing the next result 
                            ResultF = double.Parse(txtBox.Text);

                            symbol = "";
                        }
                        else
                        {


                            ResultF = ((num_1.Sum() / 100 ) * num_2.Sum());
                            txtBox.Text = ResultF.ToString();
                            symbol = "";
                            num_2.Clear();


                        }
                        break;
                }


            }

        }

        

   

        //List to store number 1
        List<double> num_1 = new List<double>();
        //List to store number 2
        List<double> num_2 = new List<double>();

        //Store the first calculation when buttton (=) is pressed
        double ResultF;

        //Used to run if  or else into the swich 
        int contador = 0;

        //used to store the symbol entered
        string symbol = "";

      
    }
}
