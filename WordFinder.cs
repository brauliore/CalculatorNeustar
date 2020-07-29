// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

public class Solution1
{

	public class Logger
	{
		public void Log(string message) { Console.WriteLine(message); }
	}

	public class WordFinder
	{
		public bool isInMatrix(string word, char[,] matrix)
		{
			Logger log = new Logger();
			List<bool> isTheWordInRow = new List<bool>();
			List<bool> isTheWordInColumn = new List<bool>();
			int wordLength = word.Length;
			bool canBeRow = false;
			bool canBeColumn = false;
			if (wordLength == matrix.GetLength(0))
            {
				canBeRow = true;
            }
			if (wordLength == matrix.GetLength(1))
            {
				canBeColumn = true;
            }
			if (canBeRow || canBeColumn)
			{
				for (int row = 0; row < matrix.GetLength(0); row++)
				{
					for (int column = 0; column < matrix.GetLength(1); column++)
					{
						if (word[column] == matrix[row, column] && canBeRow)
						{
							isTheWordInRow.Add(true);
                        }
                        else
                        {
							isTheWordInRow.Add(false);
						}

						if (word[column] == matrix[column, row] && canBeColumn)
						{
							isTheWordInColumn.Add(true);
                        }
                        else
                        {
							isTheWordInColumn.Add(false);
                        }
					}
					if (!isTheWordInRow.Contains(false) || !isTheWordInColumn.Contains(false))
                    {
						return true;
                    }
                    else
                    {
						isTheWordInRow = new List<bool>();
						isTheWordInColumn = new List<bool>();
					}



				}
            }
            else
            {
				log.Log("Error: Matrix length does not match with the word");
            }

			return false;
        }
	}
}
