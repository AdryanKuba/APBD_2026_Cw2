// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Feature1")
Console.WriteLine("Feature2")
Console.WriteLine("Feature3")
Console.WriteLine("Feature4")
Console.WriteLine("Feature5")

public static double CalculateAverage(int[] values){

    if (values == null || values.Length == 0){
        return 0;
    }
    double sum = 0;
    foreach(int value in values){
        sum += value;
    }
    return sum/values.Length;
}

public static double CalculateMax(int[] values){
    if (values == null || values.Length == 0){
        return null;
    }
    int max = values[0]
    foreach(int value in values){
        if(value > max){
            max = value;
        }
    }
    return max;
}

public static double CalculateMin(int[] values){
     if (values == null || values.Length == 0){
        return null;
    }
    int min = values[0]
    foreach(int value in values){
        if(value < min){
            min = value;
        }
    }
    return min;
}