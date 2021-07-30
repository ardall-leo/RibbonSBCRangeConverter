﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RibbonSBCRangeConverter
{
    public class NumberHelper
    {
        public static List<PhoneNumber> SetNumbers(int RangeStart,int RangeEnd, string Customer)
        {
            List<PhoneNumber> result = new List<PhoneNumber>();

            for (var m = RangeStart; m <= RangeEnd; m++)
            {
                result.Add(new PhoneNumber
                {
                    Customer = Customer,
                    Number = m
                });
            }

            return result;
        }

    }
}
