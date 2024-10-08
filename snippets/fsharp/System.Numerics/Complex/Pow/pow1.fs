﻿// <Snippet1>
open System.Numerics

let value = Complex(12.0, -6.0)

for power in -1. .. 10. do
    printfn $"{value} ^ {power, 2} = {Complex.Pow(value, power):N2}"
// The example displays the following output:
//    (12, -6) ^ -1 = (0.07, 0.03)
//    (12, -6) ^  0 = (1.00, 0.00)
//    (12, -6) ^  1 = (12.00, -6.00)
//    (12, -6) ^  2 = (108.00, -144.00)
//    (12, -6) ^  3 = (432.00, -2,376.00)
//    (12, -6) ^  4 = (-9,072.00, -31,104.00)
//    (12, -6) ^  5 = (-295,488.00, -318,816.00)
//    (12, -6) ^  6 = (-5,458,752.00, -2,052,864.00)
//    (12, -6) ^  7 = (-77,822,208.00, 8,118,144.00)
//    (12, -6) ^  8 = (-885,157,632.00, 564,350,976.00)
//    (12, -6) ^  9 = (-7,235,785,728.00, 12,083,157,504.00)
//    (12, -6) ^ 10 = (-14,330,483,712.00, 188,412,604,416.00)
// </Snippet1>
