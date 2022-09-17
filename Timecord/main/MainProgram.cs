using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timecord.Forms;

namespace Timecord {
	static class MainProgram {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if(args.Length == 1) {
				Application.Run(new MainForm(args[0]));
			} else {
				Application.Run(new MainForm());
			}

		}
	}
}
