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


        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            //if symbol is empty add the number to List num_1
            if (symbol == "")
            {
                txtBox.Text = txtBox.Text + 0;
                number_1 = (double.Parse(txtBox.Text));

            }

            //else clear the textbox and add the number to List num_2
            else
            {
               
                txtBox.Text = txtBox.Text + 0;
                number_2 =(double.Parse(txtBox.Text));



            }
        }

        //----------------------------------------------------- B_1 ---------------------------------------------------//
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            //if symbol is empty add the number to List num_1
            if (symbol == "")
            {
                txtBox.Text = txtBox.Text + 1;
                number_1 = (double.Parse(txtBox.Text));


            }

            //else clear the textbox and add the number to List num_2

            else
            {
                     txtBox.Text = txtBox.Text + 1;
                     number_2 = (double.Parse(txtBox.Text));

            }



        }


        //------------------------------------------------------- B_2 ---------------------------------------------------//

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            
            //if symbol is empty add the number to List num_1
            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 2;
                number_1 = (double.Parse(txtBox.Text));

            }

            else
            {
               
                txtBox.Text = txtBox.Text + 2;
                number_2 = (double.Parse(txtBox.Text));

            }

        }
        //------------------------------------------------------- B_3 ---------------------------------------------------//

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 3;
                number_1 = (double.Parse(txtBox.Text));

            }
            else
            {
                
                txtBox.Text = txtBox.Text + 3;
                number_2 = (double.Parse(txtBox.Text));

            }
        }

        //------------------------------------------------------- B_4 ---------------------------------------------------//

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 4;
                number_1 = (double.Parse(txtBox.Text));
            }
            else
            {
                txtBox.Text = txtBox.Text + 4;
                number_2 = (double.Parse(txtBox.Text));

            }

        }

        //------------------------------------------------------- B_5 ---------------------------------------------------//

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {


            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 5;
                number_1 = (double.Parse(txtBox.Text));

            }
            else
            {
                txtBox.Text = txtBox.Text + 5;
                number_2 = (double.Parse(txtBox.Text));
            }
        }

        //------------------------------------------------------- B_6 ---------------------------------------------------//

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 6;
                number_1 = (double.Parse(txtBox.Text));
            }
            else
            {
                txtBox.Text = txtBox.Text + 6;
                number_2 = (double.Parse(txtBox.Text));

            }

        }

        //------------------------------------------------------- B_7 ---------------------------------------------------//

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 7;
                number_1 = (double.Parse(txtBox.Text));


            }
            else
            {
                txtBox.Text = txtBox.Text + 7;
                number_2 = (double.Parse(txtBox.Text));

            }

        }

        //------------------------------------------------------- B_8 ---------------------------------------------------//


        private void Btn8_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 8;
                number_1 = (double.Parse(txtBox.Text));


            }
            else
            {
                txtBox.Text = txtBox.Text + 8;
                number_2 = (double.Parse(txtBox.Text));

            }
        }

        //------------------------------------------------------- B_9 ---------------------------------------------------//


        private void Btn9_Click(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                txtBox.Text = txtBox.Text + 9;
                number_1 = (double.Parse(txtBox.Text));

            }
            else
            {
                txtBox.Text = txtBox.Text + 9;
                number_2 = (double.Parse(txtBox.Text));

            }
        }

   

        //-------------------------------------------------------------- B_Clean (C) ------------------------------------//
        private void Button_Clean_1(object sender, RoutedEventArgs e)
        {
           // Console.WriteLine("Has presionado C " );
            
            //Clean textbox
            txtBox.Clear();

            //Set the variables to cero
            number_1 = 0;
            number_2 = 0;
            //Delete all the numbers stored into the Lists
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
        private void Button_Click_P(object sender, RoutedEventArgs e)
        {

            txtBox.Text = txtBox.Text + ".";
        }

        //---------------------------------------------------------------- B_Negative (+/-) ------------------------------------//

        private void Button_Click_Negative(object sender, RoutedEventArgs e)
        {

          

            //When txtBox is empty / turn the number into  negative 
            if (txtBox.Text == "")
            {
                 txtBox.Text = "-";

            }
               
            //When txtBox is not empty // and not "-" symbol // and ResulF == 0 (default )
            if ( txtBox.Text !="" && txtBox.Text != "-" && ResultF == 0)
            {
             
                number_1 = (number_1 * -1);
                txtBox.Text = number_1.ToString();

            }
            if(txtBox.Text != "" && ResultF !=0 )
            {

                ResultF = (ResultF * -1);
                txtBox.Text = ResultF.ToString();
            }




        }


        //----------------------------------------------------- Add (+)--------------------------------//
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            //Adding the symbol and adding the number to the list
            if(symbol == "")
            {
                //Setting the symbol
                symbol = "+";

                //Stoting the number into the List num_1
                num_1.Add(number_1);

            }
          
            //Adding more than two numbers without press igual 
            else
            {
 
                num_1.Add(number_2);
              
            }

            txtBox.Clear();
        }
        //------------------------------------------------ ---Subtract (-) --------------------------------//

        private void Button_Click_Subtract(object sender, RoutedEventArgs e)
        {
            if (symbol == "")
            {
                //Setting the symbol
                symbol = "-";

                //Stoting the number into the List num_1
                num_1.Add(number_1);

            }
            //Adding more than two numbers without press igual 
            else
            {

                num_1.Add(number_2);

            }
           
            txtBox.Clear();

        }
        //------------------------------------------------------ Multiple (*) --------------------------------//

        private void Button_Click_Multiple(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {
                //Setting the symbol
                symbol = "*";
               
                //Stoting the number into the List num_1
                num_1.Add(number_1);

            }
        
            txtBox.Clear();

        }
        //-------------------------------------------------------- Divide (/) --------------------------------//

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {

            if (symbol == "")
            {

                //Setting the symbol
                symbol = "/";

                //Stoting the number into the List num_1
                num_1.Add(number_1);

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


        private void Button_Equal(object sender, RoutedEventArgs e)
        {

           
         
  
            while (symbol.Length > 0)
            {
               
                contador++;
               
                switch (symbol)
                {
                    case "+":
                       
                        //After display firt result / Continue adding
                        //Contador is more than one / already a calculation was made
                        if (contador > 1)
                        {
                            
                           // Sum the Result 
                            txtBox.Text = (ResultF + number_2).ToString();
                            //store the result
                            ResultF = double.Parse(txtBox.Text);
                            symbol = "";
                            
                        }
                        else
                        {
                         
                            //First Sum 
                            //Add the two numbers / store into Result / Display the Result
                            ResultF = (num_1.Sum() + number_2);
                            txtBox.Text = ResultF.ToString();
                            //Clear Symbol in case a different symbol is pressed /not break the App
                            symbol = "";
                            num_1.Clear();
                            
                        }
                        
                        break;
                        
                    case "-":

                        if (contador > 1)
                        {



                            // Subtract the Result //Result and the number 2
                            txtBox.Text = (ResultF - number_2).ToString();
                            //store the result
                            ResultF = double.Parse(txtBox.Text);
                            symbol = "";
                        }
                        else
                        {


                            //Add the two numbers / store into Result / Display the Result
                            ResultF = (num_1.Sum() -  number_2);
                            txtBox.Text = ResultF.ToString();
                            //Clear Symbol in case a different symbol is pressed /not break the App
                            symbol = "";
                            num_1.Clear();


                        }
                        break;

                    case "*":

                        if (contador > 1)
                        {


                            // Multiple the Result //Result and the number 2
                            txtBox.Text = (ResultF * number_2).ToString();
                            //store the result
                            ResultF = double.Parse(txtBox.Text);
                            symbol = "";
                        }
                        else
                        {

                            //Multiple the two numbers / store into Result / Display the Result
                            ResultF = (num_1[0] * number_2);
                            txtBox.Text = ResultF.ToString();
                            //Clear Symbol in case a different symbol is pressed /not break the App
                            symbol = "";
                            num_1.Clear();


                        }
                        break;

                    case "/":

                        if (contador > 1)
                        {


                            // Divide the Result //Result and the number 2
                            txtBox.Text = (ResultF / number_2).ToString();
                            //store the result
                            ResultF = double.Parse(txtBox.Text);
                            symbol = "";
                        }
                        else
                        {


                            //Divide the two numbers / store into Result / Display the Result
                            ResultF = (num_1[0] / number_2);
                            txtBox.Text = ResultF.ToString();
                            //Clear Symbol in case a different symbol is pressed /not break the App
                            symbol = "";
                            num_1.Clear();


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
        double number_1;
        double number_2;
        //Used to run if  or else into the swich 
        int contador = 0;
        int counter = 0;

        //used to store the symbol entered
        string symbol = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
