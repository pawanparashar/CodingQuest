using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestBasics
{
    // ***  Strings ***
    // 7.1 Interconvert strings and integers . . . . . . . . . . . . . . . . . . . . . . . . . . . . 86
    // 7.2 Base conversion . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 87
    // 7.3 Compute the spreadsheet column encoding . . . . . . . . . . . . . . . . . . . . . . 88
    // 7.4 Replace and remove . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 89
    // 7.5 Test palindromicity . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 90
    // 7.6 Reverse all the words in a sentence . . . . . . . . . . . . . . . . . . . . . . . . . . . 91
    // 7.7 Compute all mnemonics for a phone number . . . . . . . . . . . . . . . . . . . . . 92
    // 7.8 The look-and-say problem . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 93
    // 7.9 Convert from Roman to decimal . . . . . . . . . . . . . . . . . . . . . . . . . . . . 94
    // 7.10 Compute all valid IP addresses . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 95
    // 7.11 Write a string sinusoidally . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 96
    // 7.12 Implement run-length encoding . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 97
    // 7.13 Find the first occurrence of a substring . . . . . . . . . . . . . . . . . . . . . . . . . 98
    class Chap7
    {
        //Method to convert strings to integers
        public int _7_1_StringtoInt(string number)
        {
            bool isnegative = false;
            int result = 0;
            if (number[0] == '-')
            {
                isnegative = true;
            }

            if(isnegative)
            {
                for(int i=1;i<number.Length;i++)
                {
                    result = result * 10 + (number[i] - '0');
                }
                return -result;
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    
                    result = result * 10 + (number[i]-'0');
                }
                return result;
            }

            
        }

        //Method to convert integers to strings
        public string _7_1_InttoString(int number)
        {
            bool isnegative = false;
            GeneralQuest GQ = new GeneralQuest();
            string result ="";

            if(number <0)
            {
                isnegative = true;
                number = -number;
            }

            while(number>0)
            {
                result = result + number % 10;
                number = number / 10;

            }
            if(isnegative)
            {
                result += '-';
                result = GQ.Reverse(result);
                return result;
            }
            else
            {
                result = GQ.Reverse(result);
                return result;
            }

        }

        //Method to convert number from one base to another
        public string _7_2_BaseConversion(string number,int base1,int base2)
        {
            Hashtable ht = new Hashtable();

            ht.Add('A', 10);
            ht.Add('B', 11);
            ht.Add('C', 12);
            ht.Add('D', 13);
            ht.Add('E', 14);
            ht.Add('F', 15);

            int numberbase10 =0;
            Chap5 c5 = new Chap5();
            GeneralQuest GQ = new GeneralQuest();
            number = GQ.Reverse(number);

            for(int i= number.Length-1; i>=0;i--)
            {
                int temp = 0;
                int powernumber = 0;
                
                if(number[i] =='A')
                {
                    temp = (int)ht['A'];
                    
                }
                else if(number[i] == 'B')
                {
                    temp = (int)ht['B'];
                    
                }
                else if (number[i] == 'C')
                {
                    temp = (int)ht['C'];
                    
                }
                else if (number[i] == 'D')
                {
                    temp = (int)ht['D'];
                    
                }
                else if (number[i] == 'E')
                {
                    temp = (int)ht['E'];
                    
                }
                else if (number[i] == 'F')
                {
                    temp = (int)ht['F'];
                }
                else
                {
                    temp = (int)(number[i] - '0');
                }
                powernumber = c5._5_7_xpowery(base1, i);
                numberbase10 += powernumber * temp;
            }

            string result = "";

            while(numberbase10>0)
            {
                int tempnumber = numberbase10 % base2;
                string tempstring = "";
                if (tempnumber > 9)
                {
                    if(tempnumber==10)
                    {

                        tempstring = "A";
                    }
                    if (tempnumber == 11)
                    {
                        tempstring = "B";
                    }
                    if (tempnumber == 12)
                    {
                        tempstring = "C";
                    }
                    if (tempnumber == 13)
                    {
                        tempstring = "D";
                    }
                    if (tempnumber == 14)
                    {
                        tempstring = "E";
                    }
                    if (tempnumber == 15)
                    {
                        tempstring = "F";
                    }

                }

                if(tempstring !="")
                {
                    result = tempstring + result;
                }
                else
                {
                    result = tempnumber + result;
                }
                
                numberbase10 = numberbase10 / base2;
            }

            return result;

        }

        //Method to Compute the spreadsheet column encoding
        public int _7_3_SpreadsheetEncoding(string number)
        {
            int result = 0;
            
            for(int i= number.Length-1; i>=0;i--)
            {
                result = result * 26 + number[i] - 'A' + 1;

            }
            return result;
        }

        //Method to remove char and replace char 
        public string _7_4_ReplaceandRemove(string str,char remove, char replace,string replacewith)
        {
            string result="";

            for(int i=0;i<str.Length;i++)
            {
                if(str[i] == remove)
                {
                    
                }
                else if(str[i]==replace)
                {
                    result += replacewith; 
                }
                else
                {
                    result += str[i];
                }

            }

            return result;


        }

        //Method to check for palindromicity
        public bool _7_5_isPalindrom(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            bool result = true;
            
            while (i!=j)
            {
                bool somethingisspecial = false;
                if((str[i] >='a' && str[i] <='z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                   
                }
                else
                {
                    somethingisspecial = true;
                    i++;
                }

                if ((str[j] >= 'a' && str[j] <= 'z') || (str[j] >= 'A' && str[j] <= 'Z'))
                {
                    
                }
                else
                {
                    somethingisspecial = true;
                    j--;
                }

                if(somethingisspecial == false)
                {
                     

                    if(str[i].ToString().ToLower() != str[j].ToString().ToLower())
                    {
                        result = false;
                        break;
                    }
                    else
                    {
                        i++;
                        j--;
                    }
                }
                
            }
            return result;

        }

        public string _7_6_ReverseWordsinSentence(string str)
        {


        }


    }
}
