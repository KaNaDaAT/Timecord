using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using static Timecord.Utils.TableRow;

namespace Timecord.Utils {
	public class TableRowShort {

		private string userStory;
		public string UserStory {
			get => userStory;
			set => userStory = value;
		}

		private string participant = "";
		public string Participant {
			get => participant;
			set => participant = value;
		}

		private string working = "";
		public string Working {
			get => working;
			set => working = value;
		}

		private DateTime startDate = new DateTime();
		public DateTime StartDate {
			get => startDate;
			set {
				startDate = value;
			}
		}

		private DateTime endDate = new DateTime();
		public DateTime EndDate {
			get => endDate;
			set {
				endDate = value;
			}
		}

		private int estimatedTime = 0;
		public int EstimatedTime {
			get => estimatedTime;
			set {
				estimatedTime = value;
			}
		}

		private int breakTime = 0;
		public int BreakTime {
			get => breakTime;
			set {
				breakTime = value;
			}
		}

		private int percentProgress = 0;
		public int PercentProgress {
			get => percentProgress;
			set => percentProgress = value;
		}

		public TableRowShort() { }

		public TableRowShort(string userStoryName, string participant, string working, int estimatedTime, int percentProgress, DateTime startDate, DateTime endDate, int breakTime) {
			this.UserStory = userStoryName;
			this.Participant = participant;
			this.Working = working;
			this.EstimatedTime = estimatedTime;
			this.PercentProgress = percentProgress;
			this.StartDate = startDate;
			this.EndDate = endDate;
			this.BreakTime = breakTime;
		}

		public TableRowShort(string userStoryName, string participant, string working, int estimatedTime, int percentProgress, DateTime startDate, int breakTime) {
			this.UserStory = userStoryName;
			this.Participant = participant;
			this.Working = working;
			this.EstimatedTime = estimatedTime;
			this.PercentProgress = percentProgress;
			this.StartDate = startDate;
			this.BreakTime = breakTime;
		}

		public TableRow ToTableRow() {
			return new TableRow(UserStory, Participant, Working, EstimatedTime, PercentProgress, StartDate, EndDate, BreakTime);
		}

		public override string ToString() {
			string back = "{";
			back += "\t'userStory': '" + this.UserStory + "',\n";
			back += "\t'participant': '" + this.Participant + "',\n";
			back += "\t'working': '" + this.Working + "',\n";
			back += "\t'estimatedTime': '" + FormatMillis(this.EstimatedTime) + "',\n";
			back += "\t'startDate': '" + this.StartDate.ToString("dd.MM.yyyy HH:mm") + "',\n";
			back += "\t'endDate': '" + this.EndDate.ToString("dd.MM.yyyy HH:mm") + "',\n";
			back += "\t'percentProgress': '" + this.PercentProgress + "%',\n";
			back += "}";
			return back;
		}

		private string FormatMillis(int ms) {
			int min = ms / 60000;
			string minS = Math.Abs(min % 60) < 10 ? "0" + Math.Abs(min % 60) : "" + Math.Abs(min % 60);
			string hourS = min / 60 < 10 ? "0" + Math.Abs(min / 60) : "" + Math.Abs(min / 60);
			if(ms < 0)
				return "- " + hourS + ":" + minS;
			else
				return hourS + ":" + minS;
		}
	}
}
