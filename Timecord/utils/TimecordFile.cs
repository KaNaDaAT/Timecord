using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using static Timecord.Utils.TableRow;

namespace Timecord.Utils {
	public class TimecordFile {

		public class TimecordContent {
			public List<UserStoryItem> UserStorys = new List<UserStoryItem>();
			public List<string> Participants = new List<string>();
			public List<TableRow> TableRows = new List<TableRow>();

			public void SetUserStory(List<string> names, List<Color> colors) {
				if(names.Count != colors.Count)
					return;
				UserStorys.Clear();
				for(int i = 0; i < names.Count; i++) {
					UserStorys.Add(new UserStoryItem(names[i], colors[i]));
				}
			}

			public TimecordContentShort ToTimecordContentShort() {
				TimecordContentShort tcs = new TimecordContentShort();
				tcs.UserStorys = UserStorys;
				tcs.Participants = Participants;
				foreach(TableRow tableRow in TableRows) {
					tcs.TableRowsShort.Add(tableRow.ToTableRowShort());
				}
				return tcs;
			}
		}

		public class TimecordContentShort {
			public List<UserStoryItem> UserStorys = new List<UserStoryItem>();
			public List<string> Participants = new List<string>();
			public List<TableRowShort> TableRowsShort = new List<TableRowShort>();

			public void SetUserStory(List<string> names, List<Color> colors) {
				if(names.Count != colors.Count)
					return;
				UserStorys.Clear();
				for(int i = 0; i < names.Count; i++) {
					UserStorys.Add(new UserStoryItem(names[i], colors[i]));
				}
			}

			public TimecordContent ToTimecordContent() {
				TimecordContent tc = new TimecordContent();
				tc.UserStorys = UserStorys;
				tc.Participants = Participants;
				foreach(TableRowShort tableRow in TableRowsShort) {
					tc.TableRows.Add(tableRow.ToTableRow());
				}
				return tc;
			}
		}

		public TimecordContent Content = new TimecordContent();
		private TimecordContentShort ShortContent = new TimecordContentShort();

		public TimecordFile() {

		}

		public bool Open(string path) {
			StreamReader reader = new StreamReader(path);
			string readString = reader.ReadToEnd();
			reader.Close();

			Deserializer deserializer = new Deserializer();
			try {
				ShortContent = (TimecordContentShort) deserializer.Deserialize(readString, typeof(TimecordContentShort));
				Content = ShortContent.ToTimecordContent();
			} catch(Exception) {
				Content = null;
			}

			if(Content == null) { 
				MessageBox.Show("The File seems to be not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		public void Save(string path) {
			ShortContent = Content.ToTimecordContentShort();
			Serializer serializer = new Serializer();
			string saveString = serializer.Serialize(this.ShortContent);
			StreamWriter writer = new StreamWriter(path);
			writer.Write(saveString);
			writer.Close();
		}
	}
}
