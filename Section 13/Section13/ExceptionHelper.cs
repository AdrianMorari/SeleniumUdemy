﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13
{
    class ExceptionHelper
    {
        public static void DivisionTest()
        {
            try
            {
                int totalScores = 10;
                int countOfScores = 0;

                double average = totalScores / countOfScores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Division operation");
            }
        }

        public static string state;
        
        public static void CheckStateOK(string st)
        {
            switch (st.ToUpper())
            {
                case "FL":
                case "GA":
                case "NC":
                case "VA":
                    state = st.ToUpper();
                    break;
                default:
                    CustomException ex = new CustomException("State not Part" + " of Atlantic ICW");
                    throw ex;
            }
        }
    }
}
