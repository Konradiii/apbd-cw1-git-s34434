public class StatisticsHelper
{

    public static double kwadrat(double liczba)
    {
        return liczba * liczba;
    }


    public static double OdlegloscEuklidesowa(double x1, double y1, double x2, double y2)
    {
        
        double dx =  x2 - x1;
        double dy = y2 - y1;
        
        return Math.Sqrt(dx*dx + dy*dy);
    }


    public static double CalculateAverage(int[]  values)
    {

     if (values.Length == 0 ) return 0;

     int sum = 0;
     foreach (var v in values)
         sum += v;

     return (double)sum / values.Length;



    }


    public static int CalculateMax(int[] values)
    {
        
        int max = values[0];

        foreach (int x in values)
        {
            if(value> max)
                max = x;
        }
        
        return max;
        
    }

    





}
