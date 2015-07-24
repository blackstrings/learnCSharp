using System;
using DLL;

//testing no namespace
namespace DLL{
	public class DLLDemo
	{
//		public static void Main(){
//			start();
//		}
		
		private static void start(){
			Worker w = new Worker();
			WorkerA wa = new WorkerA();
			
			System.Console.WriteLine("answer is: " + w.sub(5,3) + " workerA " + wa.add(5,5));
			System.Console.ReadKey();
		}
	}
}