import java.util.Arrays;
import java.util.Scanner;
import java.util.Comparator;
import java.util.function.DoubleToIntFunction;

public class SJF_Schedule{

    public static class Process{
        int id, at, bt, wt, tt, st, et;
    }

    public static void main(String[] args){
        int n = 4;
        Process[] processes = new Process[n];

        System.out.println("Enter arrival time and burst time.");
        System.out.println();


        Scanner scan = new Scanner(System.in);

        for(int i = 0; i < n; i++){
            processes[i] = new Process();
            processes[i].id = i+1;

            System.out.println("Process " + processes[i].id + ": ");

            System.out.print("Arrival Time: ");
            processes[i].at = scan.nextInt();

            System.out.print("Burst Time: ");
            processes[i].bt = scan.nextInt();

            System.out.println();
        }

        computerSJF(processes, n);
        scan.close();
    }


/*    static void sortBurstTime(Process[] prcs, int start, int stop)
 // Insertion sort
    {
        System.out.println("Burst Times: ");

        for(int index = start; index < stop; index++)
        {
            Process key = prcs[index];
            int it = index - 1; 
            while(it >= start && prcs[it].bt > key.bt)
            {
                System.out.println( 
                                "Iteration: " + it + " " +
                                prcs[it].bt + 
                                " \t " + prcs [it + 1].bt);
                prcs[it + 1] = prcs[it];  
                it -= 1;
                System.out.println( 
                                "\nChanged: " + it + " " +
                                prcs[it].bt + 
                                " \t " + prcs [it + 1].bt);

            }
            prcs[it + 1] = key;

        }
        for(var c : prcs)
            System.out.print(c.bt + ", ");
        System.out.println();
    } */
    
    static void computerSJF(Process[] processes, int n){
        int totalWaiting = 0;
        int totalTurnAround = 0;

        processes[0].wt = 0;
        processes[0].st = 0;
        processes[0].tt = processes[0].bt;
        processes[0].et = processes[0].bt;

        totalWaiting = totalWaiting + processes[0].wt;
        totalTurnAround += processes[0].tt;
        
        // !! easy way !!           literally taking the bt and comparing it
        //                          on the rest bt's
        Arrays.sort(processes, 1, n, Comparator.comparingInt(p -> p.bt)); 
        /*
         * @override 
         * Comparator<Process> 
         *  public int compare(Process p1, Process p2)
         *  { return Integer.compare(p1.bt, p2.bt); }
        */
    //    sortBurstTime(processes, 1, n);

        for(int i = 1; i < n; i++){
            processes[i].st = processes[i-1].bt + processes[i-1].st;
            processes[i].wt = processes[i].st - processes[i].at;
            processes[i].et = processes[i].bt + processes[i-1].et;
            processes[i].tt = processes[i].et - processes[i].at;

            totalWaiting = totalWaiting + processes[i].wt;
            totalTurnAround += processes[i].tt;

            System.out.println("Turnaround T: " + processes[i].tt);
            System.out.println("Waiting T: " + processes[i].wt);
            
        }
        System.out.println();
        System.out.println("TWT: " + totalWaiting);
        System.out.println("TTT: " + totalTurnAround);
        System.out.println();

        float averageWT = (float)totalWaiting/n;
        System.out.println("AWT: " +averageWT);

        float averageTT = (float)totalTurnAround/n;
        System.out.println("ATT: " +averageTT);
    }
}
