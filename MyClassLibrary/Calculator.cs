using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Calculator
    {
        List<Data> DataList = new List<Data>();
        //Constructor
        public Calculator(List<Data> _dataList)
        {
            DataList = _dataList;
        }

        public void CalcInterest(float inputAmount, string inputStartDate, string inputEndDate)
        {
            //Converting input dates to <DateTime>
            DateTime start = DateTime.Parse(inputStartDate);
            DateTime end = DateTime.Parse(inputEndDate);

            //**Visualization of data**

            //foreach (var item in DataList)
            //{
            //    Console.Write(@" start: {0}" + " end: {1}" + " dikaio: {2}" + " iper: {3}" + " Id: {4}" + "\n", item.StartDate, item.EndDate, item.Dikaiopraktikos, item.Iperimerias, item.Id);
            //}

            float Dikaio = 0;
            float Iper = 0;

            for (int i = 0; i < DataList.Count(); i++)
            {
                //Parsing values to DateTime
                var startList = DateTime.Parse(DataList[i].StartDate);
                var endList = DateTime.Parse(DataList[i].EndDate);
                float sumD = 0;
                float sumI = 0;

                //Conditioning
                if (start < startList && end > endList)
                {
                    //Total days
                    var days = (endList - startList).TotalDays+1;
                    //Dikaiopratiko amount
                    Dikaio = inputAmount * ((DataList[i].Dikaiopraktikos / 100) / (360.0F)) * Convert.ToSingle(days);
                    //Dikaiopratiko sum amount
                    sumD += Dikaio;
                    //Iperimerias amount
                    Iper = inputAmount * ((DataList[i].Iperimerias / 100) / (360.0F)) * Convert.ToSingle(days);
                    //Iperimerias sum amount
                    sumI += Iper;
                    //Formated Data to console
                    Console.Write($"startDate: {startList.ToString("dd/MM/yyyy")} endDate: {endList.ToString("dd/MM/yyyy")} days: {days} Epitokio: {DataList[i].Dikaiopraktikos}% Dikaiopratikos: {Dikaio} Epitokio: {DataList[i].Iperimerias}% Iperimerias: {Iper} \n");
                }
                else if ((start>=startList && end>endList)&&endList>=start)
                {
                    var days = (endList - start).TotalDays + 1;
                    Dikaio = inputAmount * ((DataList[i].Dikaiopraktikos / 100) / (360.0F)) * Convert.ToSingle(days);
                    sumD += Dikaio;
                    Iper = inputAmount * ((DataList[i].Iperimerias / 100) / (360.0F)) * Convert.ToSingle(days);
                    Console.Write($"startDate: {start.ToString("dd/MM/yyyy")} endDate: {endList.ToString("dd/MM/yyyy")} days: {days} Epitokio: {DataList[i].Dikaiopraktikos}% Dikaiopratikos: {Dikaio} Epitokio: {DataList[i].Iperimerias}% Iperimerias: {Iper} \n");
                }
                else if (start < startList || end <= endList)
                {
                    var days = (end - startList).TotalDays+1;
                    Dikaio = inputAmount * ((DataList[i].Dikaiopraktikos / 100) / (360.0F)) * Convert.ToSingle(days);
                    sumD += Dikaio;
                    Iper = inputAmount * ((DataList[i].Iperimerias / 100) / (360.0F)) * Convert.ToSingle(days);
                    sumI += Iper;
                    Console.Write($"startDate: {startList.ToString("dd/MM/yyyy")} endDate: {end.ToString("dd/MM/yyyy")} days: {days} Epitokio: {DataList[i].Dikaiopraktikos}% Dikaiopratikos: {Dikaio} Epitokio: {DataList[i].Iperimerias}% Iperimerias: {Iper} \n");
                }   
            }
        }


    }
}
