﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Extenstion
{
  public static partial class Extenstion
  {
    public static int ToInt(this string value) => Numbers.ToInt(value);

    public static double ToDouble(this string value) => Numbers.ToDouble(value);

    public static bool ToBool(this string value) => Numbers.Map<bool>(value);

    public static DateTime ToDateTime(this string value) => Numbers.Map<DateTime>(value);

    public static bool IsValid(this string value) => Strings.IsValid(value);


    // String Array
    public static string Join(this string[] value, string separator) => string.Join(separator, value);
  }

}
