using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double PI = 3.1415;
        string c;
        double y;
        private void button14_Click(object sender, EventArgs e)  // numbers
        {
            Button x = (Button)sender;
          
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + x.Text; 
            if (x.Text == "."&& textBox1.Text==".")
            {
                textBox1.Text = "0.";
            }
        }

        private void button1_Click(object sender, EventArgs e) // clear button
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text== "")
            {
                textBox1.Text = "0";
            }
        }
 private void button17_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            y = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text + " " + c;
            textBox1.Clear();
        }

      private void button21_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
                c = x.Text;
            y = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text + " " + c;
            textBox1.Clear();
        }
        private void button18_Click(object sender, EventArgs e)
        {                                                        // equal button
            switch (c)
            {
                case "Hexa to Bin":
                    {
                        string result2 = "";
                        string hexa;
                        Int64 x, y, index = 0;
                        Int64[] binary = new Int64[10000];
                        char ch;
                        hexa = textBox1.Text;
                        for (int i = 0; i < hexa.Length; i++)
                        {
                            ch = hexa.ElementAt(i);
                            x = Convert.ToInt64(ch);
                            if (ch >= '0' && ch <= '9') y = x - 48;
                            else y = x - 55;
                            for (Int64 j = 0; j < 4; j++)
                            {
                                if (y % 2 == 0)
                                {
                                    binary[index] = 0;
                                }
                                else binary[index] = 1;
                                index++;
                                y = y / 2;
                            }
                            Int64 t = 0;

                            for (Int64 d = index - 1; d >= 0; d--)
                            {
                                result2 += binary[d];
                                index = 0;
                                t++;
                            }
                            if (t == 4)
                            {
                                result2 += " ";
                                t = 0;
                            }

                        }
                        textBox1.Text = Convert.ToString("Binary: " + result2);
                        label1.Text = "";
                    }
                    break;
                case "Hexa to Oct":
                    {
                        string result2 = "";
                        string hexa;
                        Int64 x, pow = 1, rem, index = 0;
                        char ch;
                        Int64 deci = 0;
                        Int64[] oct = new Int64[100000];
                        hexa = textBox1.Text;
                        for (int i = 0; i < hexa.Length; i++)
                        {
                            ch = hexa.ElementAt(i);
                            x = Convert.ToInt32(ch);
                            pow = 1;
                            for (Int64 j = i; j < hexa.Length - 1; j++)
                            {
                                pow *= 16;
                            }
                            if (ch >= '0' && ch <= '9')
                            {
                                deci += pow * (x - 48);
                            }
                            else
                                deci += pow * (x - 55);
                        }
                        while (deci > 0)
                        {
                            rem = deci % 8;
                            oct[index] = rem;
                            deci = deci / 8;
                            index++;
                        }
                        Int64 t = 1;

                        for (Int64 d = index - 1; d >= 0; d--)
                        {
                            result2 += oct[d];
                            t++;

                            if (t == 4)
                            {
                                result2 += " ";
                                t = 1;
                            }
                        } textBox1.Text = Convert.ToString("Octal: " + result2);
                        label1.Text = "";
                    }
                    break;

                case "Hexa to Deci":
                    {
                        string hexa;
                        Int64 x, pow = 1;
                        char ch;
                        Int64 deci = 0;
                        hexa = textBox1.Text;
                        for (int i = 0; i < hexa.Length; i++)
                        {
                            ch = hexa.ElementAt(i);
                            x = Convert.ToInt32(ch);
                            pow = 1;
                            for (Int64 j = i; j < hexa.Length - 1; j++)
                            {
                                pow *= 16;
                            }
                            if (ch >= '0' && ch <= '9')
                            {
                                deci += pow * (x - 48);
                            }
                            else
                                deci += pow * (x - 55);
                        }
                        textBox1.Text = Convert.ToString("Decimal: " + deci);
                        label1.Text = "";
                    }
                    break;
                case "Bin to Deci":
                    {
                        Int64 binary, i = 0, sum = 0;

                        Int64 s;
                        binary = Convert.ToInt64(textBox1.Text);
                        while (Convert.ToBoolean(binary))
                        {
                            Int64 result = 1;
                            for (int j = 0; j < i; j++)
                            {
                                result *= 2;
                            }
                            s = binary % 10;
                            sum += result * s;
                            binary = binary / 10;
                            i++;
                        }
                        textBox1.Text = Convert.ToString("Decimal: " + sum);
                        label1.Text = "";

                    }
                    break;
                case "Bin to Hexa":
                    {
                        string result2 = "";
                        Int64[] hex = new Int64[1000];
                        Int64 i = 0, j = 0, rem, dec = 0, binary = 0;
                        binary = Int64.Parse(textBox1.Text);
                        while (Convert.ToBoolean(binary))
                        {
                            Int64 result = 1;
                            for (Int64 r = 0; r < i; r++)
                            {
                                result *= 2;
                            }
                            rem = binary % 2;
                            dec = dec + rem * result;
                            binary = binary / 10;
                            i++;
                        }
                        i = 0;
                        while (dec != 0)
                        {
                            hex[i] = dec % 16;
                            dec = dec / 16;
                            i++;
                        }
                        Int64 p = 0;
                        for (j = i - 1; j >= 0; j--)
                        {
                            if (hex[j] > 9)
                            {
                                if (hex[j] == 10) result2 += "A";
                                else if (hex[j] == 11) result2 += "B";
                                else if (hex[j] == 12) result2 += "C";
                                else if (hex[j] == 13) result2 += "D";
                                else if (hex[j] == 14) result2 += "E";
                                else if (hex[j] == 15) result2 += "F";
                            }
                            else
                            {
                                result2 += hex[j].ToString();
                            }
                            p++;
                            if (p == 4)
                            {
                                result2 += " ";
                                p = 0;
                            }
                        }
                        textBox1.Text = Convert.ToString("Hexadecimal: " + result2);
                        label1.Text = "";
                    }
                    break;

                case "Oct to Bin":
                    {
                        string result = "";
                        Int64 octal, s, j = 0;
                        Int64[] binary = new Int64[1000];
                        octal = Int64.Parse(textBox1.Text);
                        while (octal > 0)
                        {
                            s = octal % 10;
                            for (Int64 i = 0; i < 3; i++)
                            {
                                binary[j] = s % 2;
                                s = s / 2;
                                j++;
                            }
                            octal = octal / 10;
                        }
                        Int64 t = 0;
                        foreach (Int64 m in binary)
                        {
                            result += m.ToString();
                            t++;
                            if (t == 4)
                            {
                                result += " ";
                                t = 0;
                            }
                        }
                        char[] strArray = result.ToCharArray();
                        Array.Reverse(strArray);
                        result = new string(strArray);
                        string f_result = result.Remove(0, 1231);
                        textBox1.Text = Convert.ToString("Binary: " + f_result);
                        label1.Text = "";
                    }
                    break;
                case "Bin to Oct":
                    {
                        string result2 = "";
                        Int64 binary, s, j = 0;
                        Int64[] octal = new Int64[1000];
                        binary = Int64.Parse(textBox1.Text);
                        while (binary > 0)
                        {

                            for (Int64 i = 0; i < 3; i++)
                            {
                                Int64 result = 1;
                                for (Int64 r = 0; r < i; r++)
                                {
                                    result *= 2;
                                }
                                s = binary % 10;
                                octal[j] += result * s;
                                binary = binary / 10;
                            }
                            j++;
                        }
                        Int64 t = 1;
                        foreach (Int64 m in octal)
                        {
                            result2 += m.ToString();
                            t++;
                            if (t == 4)
                            {
                                result2 += " ";
                                t = 1;
                            }
                        }
                        char[] strArray = result2.ToCharArray();
                        Array.Reverse(strArray);
                        result2 = new string(strArray);
                        string f_result = result2.Remove(0, 1305);
                        textBox1.Text = Convert.ToString("Octal: " + f_result);
                        label1.Text = "";
                    }
                    break;
                case "Oct to Deci":
                    {
                        Int64 octal;
                        Int64[] binary = new Int64[1000];
                        octal = Int64.Parse(textBox1.Text);
                        Int64 deci = 0, d, o = 0;
                        while (octal > 0)
                        {
                            Int64 result2 = 1;
                            for (Int64 i = 0; i < o; i++)
                            {
                                result2 *= 8;
                            }
                            d = octal % 10;
                            deci += d * result2;
                            o++;
                            octal = octal / 10;
                        }
                        textBox1.Text = Convert.ToString("Decimal: " + deci);
                        label1.Text = "";
                    }
                    break;
                case "Oct to Hexa":
                    {
                        string result2 = "";
                        Int64 octal, s, deci = 0, j = 0, i = 0;
                        Int64[] hexa = new Int64[1000];
                        octal = Int64.Parse(textBox1.Text);
                        while (octal > 0)
                        {
                            Int64 result = 1;
                            for (Int64 r = 0; r < j; r++)
                            {
                                result *= 8;
                            }
                            s = octal % 10;
                            deci += s * result;
                            j++;
                            octal = octal / 10;
                        }
                        while (deci != 0)
                        {
                            hexa[i] = deci % 16;
                            deci = deci / 16;
                            i++;
                        }
                        Int64 p = 0;
                        for (Int64 y = i - 1; y >= 0; y--)
                        {
                            if (hexa[y] > 9)
                            {
                                if (hexa[y] == 10) result2 += "A";
                                else if (hexa[y] == 11) result2 += "B";
                                else if (hexa[y] == 12) result2 += "C";
                                else if (hexa[y] == 13) result2 += "D";
                                else if (hexa[y] == 14) result2 += "E";
                                else if (hexa[y] == 15) result2 += "F";

                            }
                            else result2 += hexa[y].ToString();
                            p++;
                            if (p == 4)
                            {
                                result2 += " ";
                                p = 0;
                            }
                        }
                        textBox1.Text = Convert.ToString("Hexadecimal: " + result2);
                        label1.Text = "";
                    }
                    break;
                case "Deci to Bin":
                    {
                        string result2 = "";
                        Int64 number;
                        Int64[] arr = new Int64[1000];
                        Int64 digit = 0;
                        number = Int64.Parse(textBox1.Text);
                        while (number > 0)
                        {
                            arr[digit] = number % 2;
                            number = number / 2;
                            digit++;
                        }
                        Int64 t = 0;
                        foreach (Int64 m in arr)
                        {
                            result2 += m.ToString();
                            t++;
                            if (t == 4)
                            {
                                result2 += " ";
                                t = 0;
                            }
                        }
                        char[] strArray = result2.ToCharArray();
                        Array.Reverse(strArray);
                        result2 = new string(strArray);
                        string f_result = result2.Remove(0, 1231);
                        textBox1.Text = Convert.ToString("Binary: " + f_result);
                        label1.Text = "";
                    }
                    break;
                case "Deci to Oct":
                    {
                        string result2 = "";
                        Int64 deci, j = 0;
                        Int64[] octal = new Int64[1000];
                        deci = Int64.Parse(textBox1.Text);
                        while (deci > 0)
                        {
                            octal[j] = deci % 8;
                            deci = deci / 8;
                            j++;
                        }
                        Int64 t = 1;
                        foreach (Int64 m in octal)
                        {
                            result2 += m.ToString();
                            t++;
                            if (t == 4)
                            {
                                result2 += " ";
                                t = 1;
                            }
                        }
                        char[] strArray = result2.ToCharArray();
                        Array.Reverse(strArray);
                        result2 = new string(strArray);
                        string f_result = result2.Remove(0, 1310);
                        textBox1.Text = Convert.ToString("Octal: " + f_result);
                        label1.Text = "";
                    }
                    break;
                case "Deci to Hexa":
                    {
                        string result2 = "";
                        Int64[] hex = new Int64[1000];
                        Int64 i = 0, decimalnumber;
                        decimalnumber = Int64.Parse(textBox1.Text);
                        while (decimalnumber != 0)
                        {
                            hex[i] = decimalnumber % 16;
                            decimalnumber = decimalnumber / 16;
                            i++;
                        }
                        Int64 p = 0;
                        for (Int64 j = i - 1; j >= 0; j--)
                        {
                            if (hex[j] > 9)
                            {
                                if (hex[j] == 10) result2 += "A";
                                else if (hex[j] == 11) result2 += "B";
                                else if (hex[j] == 12) result2 += "C";
                                else if (hex[j] == 13) result2 += "D";
                                else if (hex[j] == 14) result2 += "E";
                                else if (hex[j] == 15) result2 += "F";
                            }
                            else
                            {
                                result2 += hex[j].ToString();
                            }
                            p++;
                            if (p == 4)
                            {
                                result2 += " ";
                                p = 0;
                            }
                        }
                        textBox1.Text = Convert.ToString("Hexadecimal: " + result2);
                        label1.Text = "";
                    }
                    break;

                case "1/x":
                    {
                        double number = double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString(1 / number);
                        label1.Text = "";
                    }
                    break;
                case "n!":
                    {
                        
                        int result = 1;
                        for (int i = 1; i <=int.Parse(textBox1.Text) ; i++)
                        {
                            result *= i;
                        }
                      textBox1.Text= Convert.ToString(result);
                      label1.Text = "";
                    }break;
                case "%":
                    {
                        double number = double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString(number / 100);
                        label1.Text = "";
                    } break;
                case "Mod":
                    {
                        double b = double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString((y % b));
                        label1.Text = "";
                    } break;
                case "Cubrt":
                    {
                        bool cubrt = true;
                        double number = double.Parse(textBox1.Text);
                        double i = 1;
                        if (number < 0)
                        {
                            for (int j = -1; j >= number; j--)
                            {
                                if (j * j * j == number)
                                {
                                    textBox1.Text = Convert.ToString(j);
                                    label1.Text = "";
                                    cubrt = false;
                                    break;
                                }

                            }
                            if (cubrt == true)
                            {
                                for (i = -1; i * i * i > number; i -= 0.0000001) ;
                                textBox1.Text = String.Format("{0:0.000000}", i);
                                label1.Text = "";
                            }
                        }
                        else
                        {
                            for (int j = 0; j <= number; j++)
                            {
                                if (j * j * j == number)
                                {
                                    textBox1.Text = Convert.ToString(j);
                                    label1.Text = "";
                                    cubrt = false;
                                    break;
                                }

                            }
                            if (cubrt == true)
                            {
                                for (i = 0; i * i * i < number; i += 0.0000001) ;
                                textBox1.Text = String.Format("{0:0.000000}", i);
                                label1.Text = "";
                            }

                        }
                    } break;
                case "sqrt":
                    {
                        bool sqrt = true;
                        double number = double.Parse(textBox1.Text);
                        if (number < 0) { MessageBox.Show("this is impossible for negative numbers"); }
                        else
                        {
                            double i = 0;
                            for (int j = 0; j <= number; j++)
                            {
                                if (j * j == number)
                                {
                                    textBox1.Text = Convert.ToString(j);
                                    label1.Text = "";
                                    sqrt = false;
                                    break;
                                }

                            }
                            if (sqrt == true)
                            {
                                for (i = 0; i * i < number; i += 0.0000001) ;
                                textBox1.Text = String.Format("{0:0.000000}", i);
                                label1.Text = "";
                            }
                        }
                    } break;
                case "ln":
                    {
                        double power = 1;
                        double y = (double.Parse(textBox1.Text) - 1) / (double.Parse(textBox1.Text) + 1);

                        double count = 3;
                        double ln = 1;
                        for (int i = 2; i <= 1000; i += 2)
                        {
                            power = 1;
                            for (int j = 0; j < i; j++)
                            {
                                power *= y;
                            }
                            ln += power / (double)count;
                            count += 2;
                        }
                        ln = ln * 2 * y;
                        textBox1.Text = Convert.ToString(ln);
                        
                    }break;
                case "Sin":
                    {
                        double angle_degree = Convert.ToDouble(textBox1.Text);
                        double angle_radian, sum = 0, term, nume, deno;
                        angle_radian = (angle_degree * PI) / 180;
                        int i = 2;
                        nume = angle_radian;
                        deno = 1;
                        do
                        {
                            term = nume / deno;
                            nume = -nume * angle_radian * angle_radian;
                            deno = deno * i * (i + 1);
                            sum = sum + term;
                            i = i + 2;
                        } while (term >= 0.00001);
                        textBox1.Text = Convert.ToString(sum);
                            label1.Text = "";
                    }break;

                case "Cos":
                    {
                        double angle_degree = double.Parse(textBox1.Text);
                        double angle_radian = (angle_degree * PI) / 180;
                        double ans = 1;
                        double temp = 1;
                        int accuracy = 4;
                        for (int i = 1; i <= 2 * accuracy; i += 2)
                        {
                            temp = temp * (-1) * angle_radian * angle_radian / (i * (i + 1));
                            ans += temp;
                        }
                        textBox1.Text = Convert.ToString(ans);
                        label1.Text = "";
                    }break;

                case "Tan":
                    {
                        double angle_degree = double.Parse(textBox1.Text);
                        double angle_radian, sum = 0, term, nume, deno;
                        angle_radian = (angle_degree * PI) / 180;
                        int a = 2;
                        nume = angle_radian;
                        deno = 1;
                        do
                        {
                            term = nume / deno;
                            nume = -nume * angle_radian * angle_radian;
                            deno = deno * a * (a + 1);
                            sum = sum + term;
                            a = a + 2;
                        } while (term >= 0.00001);
                        double ans = 1;
                        double temp = 1;
                        int accuracy = 4;
                        for (int i = 1; i <= 2 * accuracy; i += 2)
                        {
                            temp = temp * (-1) * angle_radian * angle_radian / (i * (i + 1));
                            ans += temp;
                        }
                        textBox1.Text = Convert.ToString(sum / ans);
                        label1.Text = "";
                    }break;
                case "Sinh":
                    {
                        double angle_degree = double.Parse(textBox1.Text);
                        double angle_radian = (angle_degree * PI) / 180;
                        double ans = 1;
                        double temp = 1;
                        int accuracy = 4;
                        for (int i = 1; i <= 2 * accuracy; i += 2)
                        {
                            temp = temp * (-1) * angle_radian * angle_radian / (i * (i + 1));
                            ans += temp;
                        }
                        textBox1.Text = Convert.ToString(1 / ans);
                        label1.Text = "";
                    }break;
                case "Cosh":
                    {

                        double angle_degree = double.Parse(textBox1.Text);
                      
                        double angle_radian, sum = 0, term, nume, deno;
                        angle_radian = (angle_degree * PI) / 180;
                        int i = 2;
                        nume = angle_radian;
                        deno = 1;
                        do
                        {
                            term = nume / deno;
                            nume = -nume * angle_radian * angle_radian;
                            deno = deno * i * (i + 1);
                            sum = sum + term;
                            i = i + 2;
                        } while (term >= 0.00001);
                        textBox1.Text = Convert.ToString(1 / sum);
                        label1.Text = "";
                    }break;
                case "Tanh":
                    {
                         double angle_degree = double.Parse(textBox1.Text);
            
            double angle_radian, sum = 0, term, nume, deno;
            angle_radian = (angle_degree * PI) / 180;
            int a = 2;
            nume = angle_radian;
            deno = 1;
            do
            {
                term = nume / deno;
                nume = -nume * angle_radian * angle_radian;
                deno = deno * a * (a + 1);
                sum = sum + term;
                a = a + 2;
            } while (term >= 0.00001);
            double ans = 1;
            double temp = 1;
            int accuracy = 4;
            for (int i = 1; i <= 2 * accuracy; i += 2)
            {
                temp = temp * (-1) * angle_radian * angle_radian / (i * (i + 1));
                ans += temp;
            }
            textBox1.Text = Convert.ToString( ans / sum);
            label1.Text = "";

                    }break;
                case "log":
                    {
                        double x;
                        x = int.Parse(textBox1.Text);
                        if (x > 0)
                        {
                            double power = 1;
                            double y = (x - 1) / (x + 1);
                            double count = 3;
                            double ln = 1;
                            for (int i = 2; i <= 1000; i += 2)
                            {
                                power = 1;
                                for (int j = 0; j < i; j++)
                                {
                                    power *= y;
                                }
                                ln += power / (double)count;
                                count += 2;
                            }
                            ln = ln * 2 * y;
                            double x2 = 10;
                            double power2 = 1;
                            double y2 = (x2 - 1) / (x2 + 1);
                            double count2 = 3;
                            double ln10 = 1;
                            for (int i = 2; i <= 1000; i += 2)
                            {
                                power2 = 1;
                                for (int j = 0; j < i; j++)
                                {
                                    power2 *= y2;
                                }
                                ln10 += power2 / (double)count2;
                                count2 += 2;
                            }
                            ln10 = ln10 * 2 * y2;
                            double log10 = ln / ln10;
                            textBox1.Text = Convert.ToString(log10);
                        }
                        label1.Text = "";
                    }break;

                case "x^2":
                    {
                        double number = double.Parse(textBox1.Text);
                        double result = 1;
                        for (int i = 1; i <= 2; i++)
                        {
                            result *= number;
                        }
                        textBox1.Text = Convert.ToString (result );
                        label1.Text = "";
                    }  break;

                case "x^3":
                    {
                        double number = double.Parse(textBox1.Text);
                        double result = 1;
                        for (int i = 1; i <= 3 ; i++ )
                        {
                            result *= number;
                        }
                        textBox1.Text = Convert.ToString(result);
                        label1.Text = "";
                    }break;

                case "e^x":
                    {

                        double power = double.Parse(textBox1.Text);
                        int accuracy = 30;
                        double answer = 1;
                        double temp = 1;
                        for (int i = 1; i <= accuracy; i++)
                        {
                            temp = (temp * power) / i;
                            answer = answer + temp;
                        }
                        textBox1.Text = Convert.ToString(answer);
                        label1.Text = "";
                    }break;

                case "even or odd":
                    {

                        int number = int.Parse(textBox1.Text);
                       if (number % 2 == 0)
                        {
                            textBox1.Text = Convert.ToString("'" + number + "' is an even number");
                        }
                        else
                            textBox1.Text = Convert.ToString("'"+number +"' is an odd number");
                        label1.Text = "";
                    }break;

                case "prime or  not":
                    {
                        int number = int.Parse(textBox1.Text);
                        bool prime = false;
                        if (number == 1)
                        {
                            textBox1.Text = "is not prime  ";
                        }
                        else if (number == 2)
                        {
                            textBox1.Text = "prime  ";
                        }
                        else
                        {
                            for (int i = 2; i < number; i++)
                            {
                                if (number % i == 0)
                                {
                                    prime = false;
                                    break;
                                }
                                else
                                    prime = true;
                            }
                            if (prime)
                            {
                                textBox1.Text = "prime ";
                            }
                            else
                                textBox1.Text = "is not prime ";
                        }
                        label1.Text = "";
                    }break;

                case "PI":
                    {
                        label1.Text = Convert.ToString(3.14);
                    }
                    break;

                case "+":
                    {
                        double b = double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString((y+b));
                        label1.Text="";
                    }

                    break;
                case "-":
                    {
                        double b = double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString((y-b));
                        label1.Text = "";
                    }
                    break;
                case "*":
                    {
                        double b = double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString((y*b));
                        label1.Text = "";
                    }
                    break;
                case "/":
                    {
                        double b = double.Parse(textBox1.Text);
                        textBox1.Text = Convert.ToString((y/b));
                        label1.Text = "";
                    }
                    break;
               
                    }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {                                                                  // to control from the key board
            switch (e.KeyChar)
            {
                case 'l':
                    {
                        e.Handled = true;
                        button39.PerformClick();
                    }
                    break;
                case '!':
                    {
                        e.Handled = true;
                        button42.PerformClick();
                    }
                    break;
                case 's':
                    {
                        e.Handled = true;
                        button35.PerformClick();
                    }
                    break;
                case 'c':
                    {
                        e.Handled = true;
                        button31.PerformClick();
                    }
                    break;
                case 't':
                    {
                        e.Handled = true;
                        button27.PerformClick();
                    }
                    break;
                case 'n':
                    {
                        e.Handled = true;
                        button41.PerformClick();
                    }
                    break;
                case '+':
                    {
                        e.Handled = true;
                        button4.PerformClick();
                    } break;
                case '-':
                    {
                        e.Handled = true;
                        button9.PerformClick();
                    } break;
                case '*':
                    {
                        e.Handled = true;
                        button13.PerformClick();
                    } break;
                case '/':
                    {
                        e.Handled = true;
                        button17.PerformClick();
                    } break;
                case (char)Keys.Enter:
                    {
                        button18.PerformClick();
                    } break;
                case (char)Keys.Back:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case 'A':
                case 'B':
                case 'C':
                case 'E':
                case 'F':
               
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Please Enter Numbers Only");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            c = x.Text;
            label1.Text = textBox1.Text + " " + c;
        }

        private void button52_Click(object sender, EventArgs e)
        {
              Button x = (Button)sender;
            c = x.Text;
            y = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text + " " + c;
            textBox1.Clear();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + x.Text;
            if (x.Text == "." && textBox1.Text == ".")
            {
                textBox1.Text = "0.";
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + x.Text;
            if (x.Text == "." && textBox1.Text == ".")
            {
                textBox1.Text = "0.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Form frm=new Form4();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      }
  }
