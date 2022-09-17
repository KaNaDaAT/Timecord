using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timecord.Utils {
	public class StringMethods {

		public static bool EqualsOneOf(string text, string[] values) {
			foreach(string value in values) {
				if(text.Equals(value))
					return true;
			}
			return false;
		}

		public static bool EndsWithOneOf(string text, string[] values) {
			foreach(string value in values) {
				if(text.EndsWith(value))
					return true;
			}
			return false;
		}

	}
}
