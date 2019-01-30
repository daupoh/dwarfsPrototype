using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond
{
    public class CSettings
    {
        const int COUNTS_OF_FIELDS = 2;
        int m_iCountOfStowns, m_iCountOfStowForms, m_iCountOfEnemies;
        string[] m_asStownsNames = { "Алмаз", "Изумруд", "Рубин", "Сапфир", "Золото",
                                 "Серебро","Топаз","Аметист","Гранат",
                                    "Опал","Це","Ам","Аз"};
        string[] m_asStownsShortNames = { "А", "И", "Р", "С", "З",
                                 "С","Т","Ам","Гр",
                                    "О","Ц","Ам","Аз"};
        string[] m_asFormsNames = { "Круглый", "Треугольный", "Каплевидный", "Граненный"};
        string[] m_asEnemiesNames = { "Виктор", "Василий", "Егор", "Иван",
                                 "Олег", "Константин", "Андрей", "Григорий"};
        string[] m_asFieldsNames = { "Количество камней", "Количество Мешков", "Каплевидный", "Граненный" };


        public int CountOfStowns { get { return m_iCountOfStowns; } }
        public int CountOfStownForms
        {
            get { return m_iCountOfStowForms; }
           
        }
        public int CountOfFields
        {
            get
            {
                return COUNTS_OF_FIELDS;
            }
        }
        public int CountOfEnemies {
            get
            {
               return m_iCountOfEnemies;
            }
            set
            {
                checkNumber(value, 1, 9,null, "Некорректное количество противников");
                m_iCountOfEnemies = value;
            }
        }

        public CSettings(int nStowns, int nForms)
        {
            checkCount(nForms);
            checkCount(nStowns);
            m_iCountOfStowForms = nForms;
            m_iCountOfStowns = nStowns;
            m_iCountOfEnemies = 2;
        }
        public string Hint {
            get
            {
                string hint = "";
                for (int i = 0; i < m_iCountOfStowns/2; i++)
                {
                    hint += m_asStownsNames[i] + " - " + m_asStownsShortNames[i] + ". ";
                }
                hint += "\r\n";
                for (int i = m_iCountOfStowns / 2+1; i < m_iCountOfStowns; i++)
                {
                    hint += m_asStownsNames[i] + " - " + m_asStownsShortNames[i] + ". ";
                }
                return hint;
            }
        }
        public string getFormName(int index)
        {
            checkIndex(index, 5);
            return m_asFormsNames[index];
        }
        public string getFieldName(int index)
        {
            checkIndex(index, 5);
            return m_asFieldsNames[index];
        }
        public string getStownName(int index)
        {
            checkIndex(index, 15);
            return m_asStownsNames[index];            
        }
        public string getEnemiesName(int index)
        {
            checkIndex(index, 8);
            return m_asEnemiesNames[index];
        }
        void checkCount(int count)
        {
            string erText = "Количество не должно быть равно 0";
            checkNumber(count, 0, int.MaxValue, null, erText);           
           
        }
        void checkIndex(int index,int maxIndex)
        {
            string erText = "Индекс выходит за границы массива";
            checkNumber(index, 0, maxIndex, null, erText);
            
        }
        void checkNumber(int number, int min, int max, int[] notValueNumbers,string erText)
        {            
            if (number < min || number > max)
            {
                throw new FormatException(erText);
            }
            if (notValueNumbers!=null)
            {
                foreach(int n in notValueNumbers)
                {
                    if (n==number)
                    {
                        throw new FormatException(erText);
                    }
                }
            }
        }

    }
}
