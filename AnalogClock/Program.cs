using System;


//input data
Console.WriteLine("Hours: ");
double hour = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Minutes: ");
double minut = Convert.ToDouble(Console.ReadLine());


// Result
if (hour < 0 || minut < 0 || hour > 12 || minut > 60)
{
    Console.Write("Wrong input");
}
else
{
    Console.Write("angle between hours arrow and minutes arrow: ");
    Console.WriteLine(calcAngle(hour, minut) + " degrees");
}


// Calculate the angles
static int calcAngle(double h, double m)
{
    // validate the input
    

    if (h == 12)
        h = 0;

    if (m == 60)
    {
        m = 0;
        h += 1;
        if (h > 12)
            h = h - 12;
    }

    // Calculate the angles
    int hour_angle = (int)(0.5 * (h * 60 + m));
    int minute_angle = (int)(6 * m);

    // Find the difference between two angles
    int angle = Math.Abs(hour_angle - minute_angle);

    // smaller angle of two possible angles
    angle = Math.Min(360 - angle, angle);

    return angle;
}