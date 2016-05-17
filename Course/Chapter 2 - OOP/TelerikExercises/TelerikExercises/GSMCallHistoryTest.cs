using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikExercises
{
    public class GSMCallHistoryTest
    {
        public void Test()
        {
            GSM[] GSMArray = new GSM[4];

            GSM firstGSM = new GSM("G4", "LG", 1299f, "Ivan Petrov", "NM-133", 250f, 50f, 5.0f, 65536);
            GSMArray[0] = firstGSM;
            GSM secondGSM = new GSM("Galaxy A7", "Samsung", 899f, "Georgi Dimov", "MCH-1000", 200f, 35f, 4.8f, 120000);
            GSMArray[1] = secondGSM;
            GSM thirdGSM = new GSM("Mi Redmi 3", "Xiaomi", 599f, "Atanas Atanasov", "CBH-300", 300f, 80f, 5.5f, 16700000);
            GSMArray[2] = thirdGSM;
            GSM fourthGSM = new GSM("Galaxy S3 Neo", "Samsung", 499f, "Nikolai Stefanov", "SSM-100", 230f, 4.8f, 65f, 65536);
            GSMArray[3] = fourthGSM;

            for (int i = 0; i < GSMArray.Length; i++)
            {
                string something = GSMArray[i].ToString();
                Console.WriteLine(something);
            }

            GSM.iPhone4S.ToString();

            GSM myGSM = new GSM();
            myGSM.AddCalls(DateTime.Now, "0889111888", 323);
            myGSM.AddCalls(DateTime.Now, "082523318", 120);
            myGSM.AddCalls(DateTime.Now, "0877357618", 402);
            myGSM.AddCalls(DateTime.Now, "0888929081", 133);
            myGSM.PrintCalls();

            myGSM.RemoveLongestCall();
            myGSM.PrintCalls();
            myGSM.CalculateCallPrice(0.37d);

            myGSM.RemoveHistory();
            myGSM.PrintCalls();
        }
    }
}

