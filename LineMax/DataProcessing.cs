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
		private List<int> _numbersIncorrect = new List<int>();
		Dictionary<int, double> _lineAmounts = new Dictionary<int, double>();
		StringBuilder _listMaxSum = new StringBuilder();

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
							double thisSum = ProcessingTape(row, count);
							if (!_numbersIncorrect.Contains(count))
							{
								_lineAmounts.Add(count, thisSum);
							}
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

			StringBuilder resultList = new StringBuilder("Line number with the maximum total of elements: \r\n");

			double maxAmount = MaxIndex(_lineAmounts);

			resultList.Append(_listMaxSum + "\r\n");

			resultList.Append(" Max Amount: " + maxAmount + "\r\n");

			resultList.Append("Line numbers with incorrect values: \r\n");

			foreach (int number in _numbersIncorrect)
			{
				resultList.Append(" " + number);
			}

			return resultList.ToString();
		}

		public double ProcessingTape(string row, int rowNum)
		{
			double sum = 0;
			string[] items = row.Split(',');

			foreach (string item in items)
			{
                if (!double.TryParse(item, NumberStyles.Number, NumberFormatInfo.InvariantInfo, out double numeric) && _numbersIncorrect.IndexOf(rowNum) < 0)
                {
					_numbersIncorrect.Add(rowNum);
					break;
				}
				else
				{
					sum += numeric;
				}
			}
			return sum;
		}

		public double MaxIndex(Dictionary<int, double> dict)
		{
            double maxVal = double.MinValue;
			int maxKey = 0;

			foreach (KeyValuePair<int, double> kvp in dict)
			{
				if (maxVal < kvp.Value)
				{
					maxVal = kvp.Value;
					maxKey = kvp.Key;
					_listMaxSum.Clear();
				}
				if (maxVal == kvp.Value)
					_listMaxSum.Append(" " + kvp.Key);
			}
			return maxVal;
		}
	}
}
