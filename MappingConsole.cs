

using System;
using System.Diagnostics;

namespace Mapping
{
	public class MappingConsole 
	{

		public static void Main(string[] args) 
		{
			//Console.Error.WriteLine("Mapping Application");
        
			try 
			{
#if TRACE
                #region EXPORT FILE



                OutlookUIExampleTest.ExporterClass1.exportTasks();



                #endregion


#endif

                string dboxpath = System.Environment.GetEnvironmentVariable("DROPBOX", EnvironmentVariableTarget.User);


#region start SWIPL




                Process process0 = new Process();
                // Configure the process using the StartInfo properties.
                process0.StartInfo.FileName = @"c:\Program Files\swipl\bin\swipl.exe";
                //process0.StartInfo.Arguments = @"-f ""D:\From_OneDrive\OneDrive\DBox\Dropbox\Tasks2Project_prolog\Tasks2Project_prolog\csvread1.pl"" -g (chdir('D:/From_OneDrive/OneDrive/DBox/Dropbox/Tasks2Project_prolog/Tasks2Project_prolog'),openme,halt).";

                string prologpath = dboxpath + @"Tasks2Project_prolog\Tasks2Project_prolog\";

                string unixprologpath = prologpath.Replace(@"\", "/");

                process0.StartInfo.Arguments = @"-f "+ unixprologpath + "csvread1.pl " + "-g (chdir('" + unixprologpath + "'),openme,halt).";
                process0.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process0.Start();
                // process.WaitForExit();// Waits here for the process to exit.



#endregion





#if DEBUG
#region start Browser

                System.Diagnostics.Process.Start("Chrome", Uri.EscapeDataString( dboxpath + @"Tasks2Project_prolog\open-msp-viewer-master\open-msp-viewer-master\dist\msp-viewer\msp-viewer\resources\html\index.html"));




                //Process process = new Process();
                //// Configure the process using the StartInfo properties.
                //process.StartInfo.FileName = @"c:\Program Files (x86)\Microsoft Office\Office10\WINPROJ.EXE";
                //process.StartInfo.Arguments = "-n";
                //process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                //process.Start();
                //// process.WaitForExit();// Waits here for the process to exit.



#endregion
#endif




                //#region start MS Project




                //Process process = new Process();
                //// Configure the process using the StartInfo properties.
                //process.StartInfo.FileName = @"c:\Program Files (x86)\Microsoft Office\Office10\WINPROJ.EXE";
                //process.StartInfo.Arguments = "-n";
                //process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                //process.Start();
                //// process.WaitForExit();// Waits here for the process to exit.



                //#endregion


                // Console.Error.WriteLine("Finished");
            }
   //         catch (Altova.UserException ue)
			//{
			//	Console.Error.Write("USER EXCEPTION: ");
			//	Console.Error.WriteLine( ue.Message );
			//	System.Environment.Exit(1);
			//}
			catch (Exception e) 
			{
				Console.Error.Write("ERROR: ");
				Console.Error.WriteLine( e.Message );
                if (e.InnerException != null)
                {
                    Console.Error.Write("Inner Exception: ");
                    Console.Error.WriteLine(e.InnerException.Message);
                }
                Console.Error.WriteLine("\nStack Trace: ");
				Console.Error.WriteLine( e.StackTrace );
				System.Environment.Exit(1);
			}
		}
	}


	//class TraceTargetConsole : Altova.TraceTarget {
	//	public void WriteTrace(string info) {
	//		Console.Error.WriteLine(info);
	//	}
	//}
}
