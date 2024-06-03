using System;
using System.Collections;
using System.Linq;
public class RecursiveNestedLoops
{
    static int numberofLoops;
    static int numberofIterations;
    static int[]  loops;
    public static void Main(String [] args){
        Console.Write("N = ");
        numberofLoops = Convert.ToInt32(Console.ReadLine());

        Console.Write("K = "); 

        numberofIterations = Convert.ToInt32(Console.ReadLine());

        loops = new int[numberofLoops];
         
        NestedLoops(0);
    }
    static void NestedLoops(int currentLoop){
        if (currentLoop == numberofLoops){
            PrintLoops();
            return;
        }
        for (int counter = 1; counter <= numberofIterations; counter = counter + 1){
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
        }
    }
    static void PrintLoops(){
        for (int i = 0; i < numberofLoops; i++){
            Console.Write("{0}", loops[i]);
        }
        Console.WriteLine();
    }
}