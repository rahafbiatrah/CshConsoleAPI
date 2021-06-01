using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace CshConsoleAPI
{
	public class AppCommands
	{
		public const string CMD_PROMPED = "\n>";
		public const string CMD_ECHO = "echo";
		public const string CMD_EXIT = "exit";




		/***
		* Echo demonstrates a command execution function.
		* the command prints the parameters it receives.
		*/
		public static bool CommandEcho(string[] parameters)
		{
			foreach (string param in parameters){
				Console.WriteLine(param);
			}
			return (true);
		}


		/***
		* Exit terminates the application.
		* the command prints the exit messsage.
		*/
		public static bool CommandExit(string[] parameters)
		{
			Console.WriteLine(CMD_EXIT);
			return (false);
		}
	}
}
