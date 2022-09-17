using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace Timecord.Utils {
	public class TableRow {

		public class UserStoryItem {
			public string Name = "";
			public int ColorInt;
			[YamlIgnore]
			public Color Color {
				get {
					return Color.FromArgb(ColorInt);
				}
				set {
					ColorInt = value.ToArgb();
				}
			}

			public UserStoryItem() { }

			public UserStoryItem(string name) {
				this.Name = name;
			}

			public UserStoryItem(string name, Color color) {
				this.Name = name;
				this.Color = color;
			}
		}

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
				RealTime = (int) (EndDate.Subtract(StartDate).TotalMilliseconds - BreakTime);
			}
		}

		private DateTime endDate = new DateTime();
		public DateTime EndDate {
			get => endDate;
			set {
				endDate = value;
				RealTime = (int) (EndDate.Subtract(StartDate).TotalMilliseconds - BreakTime);
			}
		}

		private int estimatedTime = 0;
		public int EstimatedTime {
			get => estimatedTime;
			set {
				estimatedTime = value;
				deviation =  RealTime - EstimatedTime;
			}
		}

		private int realTime = 0;
		public int RealTime {
			get => realTime;
			set {
				realTime = value;
				deviation = RealTime - EstimatedTime;
			}
		}

		private int deviation = 0;
		public int Deviation {
			get => deviation;
			set { }
		}

		private int breakTime = 0;
		public int BreakTime {
			get => breakTime;
			set {
				breakTime = value;
				RealTime = (int) (EndDate.Subtract(StartDate).TotalMilliseconds - BreakTime);
			}
		}

		private int percentProgress = 0;
		public int PercentProgress {
			get => percentProgress;
			set => percentProgress = value;
		}

		public TableRow() { }

		public TableRow(string userStoryName, string participant, string working, int estimatedTime, int percentProgress, DateTime startDate, DateTime endDate, int breakTime) {
			this.UserStory = userStoryName;
			this.Participant = participant;
			this.Working = working;
			this.EstimatedTime = estimatedTime;
			this.PercentProgress = percentProgress;
			this.StartDate = startDate;
			this.EndDate = endDate;
			this.BreakTime = breakTime;
		}

		public TableRow(string userStoryName, string participant, string working, int estimatedTime, int percentProgress, DateTime startDate, int breakTime) {
			this.UserStory = userStoryName;
			this.Participant = participant;
			this.Working = working;
			this.EstimatedTime = estimatedTime;
			this.PercentProgress = percentProgress;
			this.StartDate = startDate;
			this.BreakTime = breakTime;
		}

		public TableRowShort ToTableRowShort() {
			return new TableRowShort(UserStory, Participant, Working, EstimatedTime, PercentProgress, StartDate, EndDate, BreakTime);
		}

		public override string ToString() {
			string back = "{";
			back += "\t'userStory': '" + this.UserStory + "',\n";
			back += "\t'participant': '" + this.Participant + "',\n";
			back += "\t'working': '" + this.Working + "',\n";
			back += "\t'estimatedTime': '" + FormatMillis(this.EstimatedTime) + "',\n";
			back += "\t'startDate': '" + this.StartDate.ToString("dd.MM.yyyy HH:mm") + "',\n";
			back += "\t'endDate': '" + this.EndDate.ToString("dd.MM.yyyy HH:mm") + "',\n";
			back += "\t'realTime': '" + FormatMillis(this.RealTime) + "',\n";
			back += "\t'breakTime': '" + FormatMillis(this.BreakTime) + "',\n";
			back += "\t'deviation': '" + FormatMillis(this.Deviation) + "',\n";
			back += "\t'percentProgress': '" + this.PercentProgress + "%',\n";
			back += "}";
			return back;
		}

		public static string FormatMillis(double ms) {
			int min = (int) Math.Round(ms / 60000d, MidpointRounding.AwayFromZero);
			string minS = Math.Abs(min % 60) < 10 ? "0" + Math.Abs(min % 60) : "" + Math.Abs(min % 60);
			string hourS = min / 60 < 10 ? "0" + Math.Abs(min / 60) : "" + Math.Abs(min / 60);
			if(ms < 0)
				return "- " + hourS + ":" + minS;
			else
				return hourS + ":" + minS;
		}
	}
}
