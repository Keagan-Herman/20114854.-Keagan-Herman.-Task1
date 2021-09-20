using System;

namespace Task1
{
    public class ClassLibModules
    {
        public static int iSizeArray = 0;
        public static int iCounter = 0;

        private int[] iNumCredit;
        private int[] iClassHours;
        private int[] iModuleHours;
        private int[] iSemesterWeeks;
        private String[] strCode;
        private String[] strName;
        
        public void setArray(int num) //(W3schools Online Web Tutorials, 2021)
        {
            strName = new String[num];
            strCode = new String[num];
            iNumCredit = new int[num];
            iClassHours = new int[num];
            iModuleHours = new int[num];
            iSemesterWeeks = new int[num];

            iSizeArray = num;
        }

        public int size()
        {
            return iSizeArray;
        }

        public bool AddToArray(String Name, String Code, int NumofCredits, int ClassHours, int ModuleHours,
            int SemesterWeeks) //(W3schools Online Web Tutorials, 2021)
        {
            if (iCounter < iSizeArray)
            {
                strName[iCounter] = Name;
                strCode[iCounter] = Code;
                iNumCredit[iCounter] = NumofCredits;
                iClassHours[iCounter] = ClassHours;
                iModuleHours[iCounter] = ModuleHours;
                iSemesterWeeks[iCounter] = SemesterWeeks;
                iCounter++;
                return true;
            }
            else
            {
                return false;
            }
        }


        public String getName(int x)
        {
            return strName[x];
        }

        public String getCode(int x)
        {
            return strCode[x];
        }

        public int getNumofCredits(int x)
        {
            return iNumCredit[x];
        }

        public int getClassHours(int x)
        {
            return iClassHours[x];
        }

        public int getModuleHours(int x)
        {
            return iModuleHours[x];
        }

        public int getiSemesterWeeks(int x)
        {
            return iSemesterWeeks[x];
        }

        public int getCounter()
        {
            return iCounter;
        }
    }
}

