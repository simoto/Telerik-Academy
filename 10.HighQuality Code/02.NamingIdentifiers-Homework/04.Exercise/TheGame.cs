namespace MineGame
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class TheGame
	{
		public class Point
		{
			string name;
			int points;

			public string Name
			{
				get { return name; }
				set { name = value; }
			}

			public int Points
			{
				get { return points; }
				set { points = value; }
			}

			public Point() { }

			public Point(string name, int points)
			{
				this.name = name;
				this.points = points;
			}
		}

		static void Main()
		{
            const int MAX_POINTS = 35;

			string userInput = string.Empty;
			char[,] gameField = GenerateGameField();
			char[,] mines = GenerateMines();
			int pointCount = 0;
			bool onMine = false;
			List<Point> topScores = new List<Point>(6);
			int row = 0;
			int col = 0;
			bool isFirstGame = true;	
			bool hasMaxScore = false;

			do
			{
				if (isFirstGame)
				{
					Console.WriteLine("Let's play “Mines”. Try your lucky strike!" +
					"\nHere is the command: \n top - show highscores \n restart - starts new game \n exit - end the game");
					RenderGameField(gameField);
					isFirstGame = false;
				}
				Console.Write("Enter row and col numbers: ");
				userInput = Console.ReadLine().Trim();
				if (userInput.Length >= 3)
				{
					if (int.TryParse(userInput[0].ToString(), out row) &&
					int.TryParse(userInput[2].ToString(), out col) &&
						row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
					{
						userInput = "turn";
					}
				}
				switch (userInput)
				{
					case "top":
						GetHighScore(topScores);
						break;
					case "restart":
						gameField = GenerateGameField();
						mines = GenerateMines();
						RenderGameField(gameField);
						onMine = false;
						isFirstGame = false;
						break;
					case "exit":
						Console.WriteLine("Goodbye!");
						break;
					case "turn":
						if (mines[row, col] != '*')
						{
							if (mines[row, col] == '-')
							{
								PlayerTurn(gameField, mines, row, col);
								pointCount++;
							}
							if (MAX_POINTS == pointCount)
							{
								hasMaxScore = true;
							}
							else
							{
								RenderGameField(gameField);
							}
						}
						else
						{
							onMine = true;
						}
						break;
					default:
						Console.WriteLine("\nInvalid input!\n");
						break;
				}
				if (onMine)
				{
					RenderGameField(mines);
					Console.Write("\nGame Over! You have made {0} points. " +
						"Enter your name: ", pointCount);
					string playerName = Console.ReadLine();
					Point currentPlayerPoints = new Point(playerName, pointCount);
					if (topScores.Count < 5)
					{
                        topScores.Add(currentPlayerPoints);
					}
					else
					{
						for (int i = 0; i < topScores.Count; i++)
						{
                            if (topScores[i].Points < currentPlayerPoints.Points)
							{
                                topScores.Insert(i, currentPlayerPoints);
								topScores.RemoveAt(topScores.Count - 1);
								break;
							}
						}
					}
					topScores.Sort((Point x, Point y) => y.Name.CompareTo(x.Name));
					topScores.Sort((Point x, Point y) => y.Points.CompareTo(x.Points));
					GetHighScore(topScores);

					gameField = GenerateGameField();
					mines = GenerateMines();
					pointCount = 0;
					onMine = false;
					isFirstGame = true;
				}
				if (hasMaxScore)
				{
                    Console.WriteLine("\nCongratulation! You have open all 35 cells without fail.");
					RenderGameField(mines);
					Console.WriteLine("Enter your name: ");
                    string playerName = Console.ReadLine();
                    Point currentPlayerPoints = new Point(playerName, pointCount);
                    topScores.Add(currentPlayerPoints);
					GetHighScore(topScores);
					gameField = GenerateGameField();
					mines = GenerateMines();
					pointCount = 0;
					hasMaxScore = false;
					isFirstGame = true;
				}
			}
			while (userInput != "exit");
			Console.WriteLine("See you soon!");
			Console.Read();
		}

		private static void GetHighScore(List<Point> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} cells",
						i + 1, points[i].Name, points[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Top list is empty!\n");
			}
		}

		private static void PlayerTurn(char[,] gameField,
			char[,] mines, int row, int col)
		{
			char mineCount = MineCounter(mines, row, col);
			mines[row, col] = mineCount;
			gameField[row, col] = mineCount;
		}

		private static void RenderGameField(char[,] gameField)
		{
			int rows = gameField.GetLength(0);
			int cols = gameField.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < cols; j++)
				{
					Console.Write(string.Format("{0} ", gameField[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] GenerateGameField()
		{
			int gameFieldRows = 5;
			int gameFieldColumns = 10;
			char[,] gameField = new char[gameFieldRows, gameFieldColumns];
			for (int i = 0; i < gameFieldRows; i++)
			{
				for (int j = 0; j < gameFieldColumns; j++)
				{
					gameField[i, j] = '?';
				}
			}

			return gameField;
		}

		private static char[,] GenerateMines()
		{
			int rows = 5;
			int cols = 10;
			char[,] gameField = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					gameField[i, j] = '-';
				}
			}

			List<int> mineList = new List<int>();
			while (mineList.Count < 15)
			{
				Random random = new Random();
				int currentMines = random.Next(50);
				if (!mineList.Contains(currentMines))
				{
					mineList.Add(currentMines);
				}
			}

			foreach (int mine in mineList)
			{
				int col = (mine / cols);
				int row = (mine % cols);
				if (row == 0 && mine != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}
				gameField[col, row - 1] = '*';
			}

			return gameField;
		}

		private static void smetki(char[,] gameField)
		{
			int col = gameField.GetLength(0);
			int row = gameField.GetLength(1);

			for (int i = 0; i < col; i++)
			{
				for (int j = 0; j < row; j++)
				{
					if (gameField[i, j] != '*')
					{
						char mine = MineCounter(gameField, i, j);
						gameField[i, j] = mine;
					}
				}
			}
		}

		private static char MineCounter(char[,] mines, int row, int col)
		{
			int count = 0;
			int rows = mines.GetLength(0);
			int cols = mines.GetLength(1);

			if (row - 1 >= 0)
			{
				if (mines[row - 1, col] == '*')
				{ 
					count++; 
				}
			}
			
			if (row + 1 < rows)
			{
				if (mines[row + 1, col] == '*')
				{ 
					count++; 
				}
			}
			
			if (col - 1 >= 0)
			{
				if (mines[row, col - 1] == '*')
				{ 
					count++;
				}
			}
			
			if (col + 1 < cols)
			{
				if (mines[row, col + 1] == '*')
				{ 
					count++;				
				}
			}
			
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (mines[row - 1, col - 1] == '*')
				{ 
					count++; 
				}
			}
			
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (mines[row - 1, col + 1] == '*')
				{ 
					count++; 
				}
			}
			
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (mines[row + 1, col - 1] == '*')
				{ 
					count++; 
				}
			}
			
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (mines[row + 1, col + 1] == '*')
				{ 
					count++; 
				}
			}
			
			return char.Parse(count.ToString());
		}
	}
}