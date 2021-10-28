using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.Infrastructure
{
    public static class RuDateAndMoneyConverter
    {
        static string[] monthNamesGenitive =
            {
                "", "січня", "лютого", "березня", "квітня", "травня", "червня", "липня", "серпня", "вересня", "жовтня", "листопада", "грудня" 
            };

        static string[] monthNamesNominative =
            {
                "", "січень", "лютий", "березень", "квітень", "травень", "червень", "липень", "серпень", "вересень", "жовтень", "листопад", "грудень" 
            };


        static string zero = "нуль";
        static string firstMale = "один";
        static string firstFemale = "одна";
        static string firstFemaleAccusative = "одну";
        static string firstMaleGenetive = "одно";
        static string secondMale = "два";
        static string secondFemale = "дві";
        static string secondMaleGenetive = "двух";
        static string secondFemaleGenetive = "двух";

        static string[] from3till19 = 
            {
                "", "три", "чотири", "п'ять", "шість",
                "сім", "вісім", "дев'ять", "десять", "одиннадцать",
                "дванадцять", "тринадцять", "чотирнадцять", "п'ятнадцять",
                "шістнадцять", "сімнадцять", "вісімнадцять", "дев'ятнадцять"
            };
        static string[] from3till19Genetive = 
            {
                "", "трьох", "чотирьох", "п'ятьох", "шістьох",
                "сімох", "вісьмох", "дев'ятьох", "десятьох", "одинадцятьох",
                "дванадцятьох", "тринадцятьох", "чотирнадцятьох", "п'ятнадцятьох",
                "шістнадцятьох", "сімнадцятьох", "вісімнадцятьох", "дев'ятнадцятьох"
            };
        static string[] tens =
            {
                "", "двадцять", "тридцять", "сорок", "п'ятдесят",
                "шістдесят", "сімдесят", "вісімдесят", "дев'яносто"
            };
        static string[] tensGenetive =
            {
                "", "двадцяти", "тридцяти", "сорока", "п'ятдесяти",
                "шістдесяти", "сімдесяти", "вісімдесяти", "дев'яноста"
            };
        static string[] hundreds =
            {
                "", "сто", "двісті", "триста", "чотириста",
                "п'ятсот", "шістсот", "сімсот", "вісімсот", "дев'ятсот"
            };
        static string[] hundredsGenetive =
            {
                "", "ста", "двухсот", "трьохсот", "чотирьохсот",
                "пятисот", "шестисот", "семисот", "восемисот", "девятисот"
            };
        static string[] thousands =
            {
                "", "тисяча", "тисячі", "тисяч"
            };
        static string[] thousandsAccusative =
            {
                "", "тисячу", "тисячі", "тисяч"
            };
        static string[] millions =
            {
                "", "мільйон", "мільйона", "мільйонів"
            };
        static string[] billions =
            {
                "", "миллиард", "миллиарда", "миллиардов"
            };
        static string[] trillions =
            {
                "", "трилион", "трилиона", "триллионов"
            };
        static string[] rubles =
            {
                "", "гривня", "гривні", "гривень"
            };
        static string[] copecks =
            {
                "", "копійка", "копійки", "копійок"
            };
        /// <summary>
        /// II квартал 2004
        /// </summary>
        /// <param name="_date"></param>
        /// <returns></returns>
        public static string DateToTextShort(DateTime _date)
        {
            return String.Format(" {1} {2}",
                                    _date.Day.ToString("D2"),             
                                    MonthName(_date.Month, Utils.TextCase.Nominative),
                                    _date.Year.ToString());
        }

        /// <summary>
        /// «07» января 2004 [+ _year(:года)]
        /// </summary>
        /// <param name="_date"></param>
        /// <param name="_year"></param>
        /// <returns></returns>
        public static string DateToTextLong(DateTime _date, string _year)
        {
            return String.Format("«{0}» {1} {2}",
                                    _date.Day.ToString("D2"),
                                    MonthName(_date.Month, Utils.TextCase.Genitive),
                                    _date.Year.ToString()) + ((_year.Length != 0) ? " " : "") + _year;
        }

        /// <summary>
        /// «07» января 2004
        /// </summary>
        /// <param name="_date"></param>
        /// <returns></returns>
        public static string DateToTextLong(DateTime _date)
        {
            return String.Format("«{0}» {1} {2}",
                                    _date.Day.ToString("D2"),
                                    MonthName(_date.Month, Utils.TextCase.Genitive),
                                    _date.Year.ToString());
        }
        /// <summary>
        /// II квартал 2004
        /// </summary>
        /// <param name="_date"></param>
        /// <returns></returns>
        public static string DateToTextQuarter(DateTime _date)
        {
            return NumeralsRoman(DateQuarter(_date)) + " квартал " + _date.Year.ToString();
        }
        /// <summary>
        /// 07.01.2004
        /// </summary>
        /// <param name="_date"></param>
        /// <returns></returns>
        public static string DateToTextSimple(DateTime _date)
        {
            return String.Format("{0:dd.MM.yyyy}", _date);
        }
        public static int DateQuarter(DateTime _date)
        {
            return (_date.Month - 1) / 3 + 1;
        }

        static bool IsPluralGenitive(int _digits)
        {
            if (_digits >= 5 || _digits == 0)
                return true;

            return false;
        }
        static bool IsSingularGenitive(int _digits)
        {
            if (_digits >= 2 && _digits <= 4)
                return true;

            return false;
        }
        static int lastDigit(long _amount)
        {
            long amount = _amount;

            if (amount >= 100)
                amount = amount % 100;

            if (amount >= 20)
                amount = amount % 10;

            return (int)amount;
        }
        /// <summary>
        /// Десять тысяч рублей 67 копеек
        /// </summary>
        /// <param name="_amount"></param>
        /// <param name="_firstCapital"></param>
        /// <returns></returns>
        public static string CurrencyToTxt(double _amount, bool _firstCapital)
        {
            //Десять тысяч рублей 67 копеек
            long rublesAmount = (long)Math.Floor(_amount);
            long copecksAmount = ((long)Math.Round(_amount * 100)) % 100;
            int lastRublesDigit = lastDigit(rublesAmount);
            int lastCopecksDigit = lastDigit(copecksAmount);

            string s = NumeralsToTxt(rublesAmount, Utils.TextCase.Nominative, true, _firstCapital) + " ";

            if (IsPluralGenitive(lastRublesDigit))
            {
                s += rubles[3] + " ";
            }
            else if (IsSingularGenitive(lastRublesDigit))
            {
                s += rubles[2] + " ";
            }
            else
            {
                s += rubles[1] + " ";
            }

            s += String.Format("{0:00} ", copecksAmount);

            if (IsPluralGenitive(lastCopecksDigit))
            {
                s += copecks[3] + " ";
            }
            else if (IsSingularGenitive(lastCopecksDigit))
            {
                s += copecks[2] + " ";
            }
            else
            {
                s += copecks[1] + " ";
            }

            return s.Trim();
        }
        /// <summary>
        /// 10 000 (Десять тысяч) рублей 67 копеек
        /// </summary>
        /// <param name="_amount"></param>
        /// <param name="_firstCapital"></param>
        /// <returns></returns>
        public static string CurrencyToTxtFull(double _amount, bool _firstCapital)
        {
            //10 000 (Десять тысяч) рублей 67 копеек
            long rublesAmount = (long)Math.Floor(_amount);
            long copecksAmount = ((long)Math.Round(_amount * 100)) % 100;
            int lastRublesDigit = lastDigit(rublesAmount);
            int lastCopecksDigit = lastDigit(copecksAmount);

            string s = String.Format("{0:N0} ({1}) ", rublesAmount, NumeralsToTxt(rublesAmount, Utils.TextCase.Nominative, true, _firstCapital));

            if (IsPluralGenitive(lastRublesDigit))
            {
                s += rubles[3] + " ";
            }
            else if (IsSingularGenitive(lastRublesDigit))
            {
                s += rubles[2] + " ";
            }
            else
            {
                s += rubles[1] + " ";
            }

            s += String.Format("{0:00} ", copecksAmount);

            if (IsPluralGenitive(lastCopecksDigit))
            {
                s += copecks[3] + " ";
            }
            else if (IsSingularGenitive(lastCopecksDigit))
            {
                s += copecks[2] + " ";
            }
            else
            {
                s += copecks[1] + " ";
            }

            return s.Trim();
        }
        /// <summary>
        /// 10 000 рублей 67 копеек  
        /// </summary>
        /// <param name="_amount"></param>
        /// <param name="_firstCapital"></param>
        /// <returns></returns>
        public static string CurrencyToTxtShort(double _amount, bool _firstCapital)
        {
            //10 000 рублей 67 копеек        
            long rublesAmount = (long)Math.Floor(_amount);
            long copecksAmount = ((long)Math.Round(_amount * 100)) % 100;
            int lastRublesDigit = lastDigit(rublesAmount);
            int lastCopecksDigit = lastDigit(copecksAmount);

            string s = String.Format("{0:N0} ", rublesAmount);

            if (IsPluralGenitive(lastRublesDigit))
            {
                s += rubles[3] + " ";
            }
            else if (IsSingularGenitive(lastRublesDigit))
            {
                s += rubles[2] + " ";
            }
            else
            {
                s += rubles[1] + " ";
            }

            s += String.Format("{0:00} ", copecksAmount);

            if (IsPluralGenitive(lastCopecksDigit))
            {
                s += copecks[3] + " ";
            }
            else if (IsSingularGenitive(lastCopecksDigit))
            {
                s += copecks[2] + " ";
            }
            else
            {
                s += copecks[1] + " ";
            }

            return s.Trim();
        }
        static string MakeText(int _digits, string[] _hundreds, string[] _tens, string[] _from3till19, string _second, string _first, string[] _power)
        {
            string s = "";
            int digits = _digits;

            if (digits >= 100)
            {
                s += _hundreds[digits / 100] + " ";
                digits = digits % 100;
            }
            if (digits >= 20)
            {
                s += _tens[digits / 10 - 1] + " ";
                digits = digits % 10;
            }

            if (digits >= 3)
            {
                s += _from3till19[digits - 2] + " ";
            }
            else if (digits == 2)
            {
                s += _second + " ";
            }
            else if (digits == 1)
            {
                s += _first + " ";
            }

            if (_digits != 0 && _power.Length > 0)
            {
                digits = lastDigit(_digits);

                if (IsPluralGenitive(digits))
                {
                    s += _power[3] + " ";
                }
                else if (IsSingularGenitive(digits))
                {
                    s += _power[2] + " ";
                }
                else
                {
                    s += _power[1] + " ";
                }
            }

            return s;
        }

        /// <summary>
        /// реализовано для падежей: именительный (nominative), родительный (Genitive),  винительный (accusative)
        /// </summary>
        /// <param name="_sourceNumber"></param>
        /// <param name="_case"></param>
        /// <param name="_isMale"></param>
        /// <param name="_firstCapital"></param>
        /// <returns></returns>
        public static string NumeralsToTxt(long _sourceNumber, Utils.TextCase _case, bool _isMale, bool _firstCapital)
        {
            string s = "";
            long number = _sourceNumber;
            int remainder;
            int power = 0;

            if ((number >= (long)Math.Pow(10, 15)) || number < 0)
            {
                return "";
            }

            while (number > 0)
            {
                remainder = (int)(number % 1000);
                number = number / 1000;

                switch (power)
                {
                    case 12:
                        s = MakeText(remainder, hundreds, tens, from3till19, secondMale, firstMale, trillions) + s;
                        break;
                    case 9:
                        s = MakeText(remainder, hundreds, tens, from3till19, secondMale, firstMale, billions) + s;
                        break;
                    case 6:
                        s = MakeText(remainder, hundreds, tens, from3till19, secondMale, firstMale, millions) + s;
                        break;
                    case 3:
                        switch (_case)
                        {
                            case Utils.TextCase.Accusative:
                                s = MakeText(remainder, hundreds, tens, from3till19, secondFemale, firstFemaleAccusative, thousandsAccusative) + s;
                                break;
                            default:
                                s = MakeText(remainder, hundreds, tens, from3till19, secondFemale, firstFemale, thousands) + s;
                                break;
                        }
                        break;
                    default:
                        string[] powerArray = { };
                        switch (_case)
                        {
                            case Utils.TextCase.Genitive:
                                s = MakeText(remainder, hundredsGenetive, tensGenetive, from3till19Genetive, _isMale ? secondMaleGenetive : secondFemaleGenetive, _isMale ? firstMaleGenetive : firstFemale, powerArray) + s;
                                break;
                            case Utils.TextCase.Accusative:
                                s = MakeText(remainder, hundreds, tens, from3till19, _isMale ? secondMale : secondFemale, _isMale ? firstMale : firstFemaleAccusative, powerArray) + s;
                                break;
                            default:
                                s = MakeText(remainder, hundreds, tens, from3till19, _isMale ? secondMale : secondFemale, _isMale ? firstMale : firstFemale, powerArray) + s;
                                break;
                        }
                        break;
                }

                power += 3;
            }

            if (_sourceNumber == 0)
            {
                s = zero + " ";
            }

            if (s != "" && _firstCapital)
                s = s.Substring(0, 1).ToUpper() + s.Substring(1);

            return s.Trim();
        }
        public static string NumeralsDoubleToTxt(double _sourceNumber, int _decimal, Utils.TextCase _case, bool _firstCapital)
        {
            long decNum = (long)Math.Round(_sourceNumber * Math.Pow(10, _decimal)) % (long)(Math.Pow(10, _decimal));

            string s = String.Format(" {0} цiлих {1} сотих", NumeralsToTxt((long)_sourceNumber, _case, true, _firstCapital), (long)decNum);
            // NumeralsToTxt((long)decNum, _case, true, false));
            return s.Trim();
        }
        /// <summary>
        /// название м-ца
        /// </summary>
        /// <param name="_month">с единицы</param>
        /// <param name="_case"></param>
        /// <returns></returns>
        public static string MonthName(int _month, Utils.TextCase _case)
        {
            string s = "";

            if (_month > 0 && _month <= 12)
            {
                switch (_case)
                {
                    case Utils.TextCase.Genitive:
                        s = monthNamesGenitive[_month];
                        break;
                    case Utils.TextCase.Nominative:
                        s = monthNamesNominative[_month];
                        break;
                }
            }

            return s;
        }
        public static string NumeralsRoman(int _number)
        {
            string s = "";

            switch (_number)
            {
                case 1: s = "I"; break;
                case 2: s = "II"; break;
                case 3: s = "III"; break;
                case 4: s = "IV"; break;
            }

            return s;
        }
    }
}
