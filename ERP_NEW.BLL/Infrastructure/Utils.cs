using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace ERP_NEW.BLL.Infrastructure
{
    public class Utils
    {
        public static string HomePath = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]); 
   
        public enum Operation
        {
            Add,
            Update,
            Template,
            Custom
        };

        public enum MouseEvent
        {
            MOUSEEVENTF_LEFTDOWN = 0x02,
            MOUSEEVENTF_LEFTUP = 0x04,
            MOUSEEVENTF_RIGHTDOWN = 0x08,
            MOUSEEVENTF_RIGHTUP = 0x10,
        };

        public enum ExpendTypes
        {
            ExpendByQuantity,
            ExpendBySum
        };

        public enum WeldPosition
        {
            FW,
            BW,
            PA,
            PF,
            PB,
            PC
        };

        public enum ConnectionType
        {
            FW,
            BW
        };

        public enum CurencyOperationType
        {
            Debit,
            Credit
        };


        public enum TextCase
        {
            Nominative/*Кто? Что?*/, 
            Genitive/*Кого? Чего?*/, 
            Dative/*Кому? Чему?*/, 
            Accusative/*Кого? Что?*/, 
            Instrumental/*Кем? Чем?*/, 
            Prepositional/*О ком? О чём?*/
        };

        public enum InvoiceType
        {
            Accountint,
            Storehouses,
            Production

        };

        /*
        * Byte - байты, 
        * KB - килобайты, 
        * MB - мегабайты, 
        * GB - гигабайты, 
        * TB - терабайты, 
        * PB - петабайты, 
        * EB - эксабайты, 
        * ZB - зетабайты, 
        * YB - йоттабайты
        */
        public enum SizeUnits
        {
            Byte, KB, MB, GB, TB, PB, EB, ZB, YB
        };

        public static void OnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '' && e.KeyChar != '' && e.KeyChar != '' && e.KeyChar != '' && e.KeyChar != '/')
                e.Handled = true;
        }

        public static NumberFormatInfo NumFormat(int DecimalDigits)
        {
            NumberFormatInfo Provider = new NumberFormatInfo();
            Provider.NumberDecimalSeparator = ",";
            Provider.NumberGroupSizes = new int[] { 3 };
            Provider.NumberDecimalDigits = DecimalDigits;
            Provider.NumberGroupSeparator = " ";
            return Provider;
        }

        //ковенртировать размер, результат в виде дейсвительного числа
        public static double ToSize(Int64 value, SizeUnits unit)
        {
             return (value / (double)Math.Pow(1024, (Int64)unit));
        }

        public static void EnterCheck(object TBox, KeyPressEventArgs e, int NumberDigits, int DecimalDigits, bool AllowNull = false, bool Unsigned = true)
        {
            if (DecimalDigits == 0)
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                    e.Handled = true;
            }

            if (Unsigned && e.KeyChar == '-')
                e.Handled = true;

            if (e.KeyChar == '.')
                e.KeyChar = ',';

            TextBox TxtBox = ((TextBox)TBox);
            string Text = TxtBox.Text.Insert(TxtBox.SelectionStart, e.KeyChar.ToString());

            if (Text.Length == 0)
                return;

            if (Text.Length == 1 && Text == "-")
                return;
            if (Text.Length == TxtBox.SelectionStart + 1 && e.KeyChar == '-')
                e.Handled = true;

            if (Text.Length == 1 && Text == "0")
                return;

            if (Text[0] == '0' && Text[1] != ',' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            if (Text[0] == '-' && TxtBox.SelectionStart == 1 && Text[TxtBox.SelectionStart] == '0')
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Back && TxtBox.SelectionStart > 0 && Text[TxtBox.SelectionStart - 1] == ',')
            {
                if (Text.Substring(0, Text.Replace(",", "").Replace("-", "").Length).Length > NumberDigits + 1)
                {
                    e.Handled = true;
                }
            }

            if (TxtBox.SelectionStart == 0 && e.KeyChar == ',')
                e.Handled = true;
            if (Text[0] == '-' && TxtBox.SelectionStart == 1 && Text[TxtBox.SelectionStart] == ',')
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Back)
                return;

            double num;
            if (!double.TryParse(Text, out num))
                e.Handled = true;

            if (Text.IndexOf(',') != -1)
            {
                if (Text.Substring(Text.IndexOf(',')).Length - 1 > DecimalDigits)
                {
                    e.Handled = true;
                }
            }

            if (Text.Substring(0, Text.Replace("-", "").IndexOf(',') != -1 ? Text.Replace("-", "").IndexOf(',') : Text.Replace("-", "").Length).Length > NumberDigits)
            {
                e.Handled = true;
            }
        }

        public enum FixedAssetsDecreeType
        {
            Add,
            Increase,
            Sold,
            Expenditure
        };





    }
}
