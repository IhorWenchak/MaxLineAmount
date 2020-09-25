using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineMax
{
	public class DataProcessing
	{
		
		private List<int> numbersIncorrect = new List<int>();
		Dictionary<int, double> lineAmounts = new Dictionary<int, double>();

		public void ReviewPath(string fileName)
		{
            int count = 0;
            try
				{
					using (StreamReader sr = new StreamReader(fileName))
					{
						while (!sr.EndOfStream)
						{
							string row = sr.ReadLine();
							count++;
							lineAmounts.Add(count, ProcessingTape(row, count));
						}
					}
				}
				catch (IOException ex)
				{
					MessageBox.Show($"IO error.\n\nError message: {ex.Message}\n\n" +
					$"Details:\n\n{ex.StackTrace}");
				}
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
        }


        public string GetResult()
		{
			string listResult = String.Format("{0}:	{1}", "Line number with the maximum total of elements", MaxIndex(lineAmounts).ToString());

			listResult += String.Format("{0}", "\r");

			listResult += "Line numbers with incorrect values:\r\n";

			foreach (int number in numbersIncorrect)
			{
				listResult += String.Format("	{0}", number.ToString());
			}

			return listResult;
		}

		public double ProcessingTape(string row, int rowNum)
		{
			double sum = 0;
			string[] items = row.Split(',');

			foreach (string item in items)
			{
                if (!double.TryParse(item, NumberStyles.Number, NumberFormatInfo.InvariantInfo, out double numeric) && numbersIncorrect.IndexOf(rowNum) < 0)
                {
					numbersIncorrect.Add(rowNum);
				}
				else
				{
					sum += numeric;
				}
			}
			return sum;
		}

		public int MaxIndex(Dictionary<int, double> dict)
		{
            double maxVal = double.MinValue;
			int maxKey = 0;

			foreach (KeyValuePair<int, double> kvp in dict)
			{
				if (maxVal < kvp.Value)
				{
					maxVal = kvp.Value;
					maxKey = kvp.Key;
				}
			}
			return maxKey;
		}
	}
}
