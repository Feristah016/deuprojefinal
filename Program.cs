using System;
using System.Threading;

namespace asd
{
    class Program
    {
        static void Main(String[] args)
        {
		
			/*Random r = new Random();
			string x;
			x = Console.ReadLine();
			Console.Clear();
			for (int y = 0; y < Convert.ToInt32(x); y++)
			{
				Console.WriteLine(r.Next(1, 7));
			}
			*/
			Console.Clear();
			Random r = new Random();

			int x;
			int y;

			try
			{
			System.Console.WriteLine("Enter the location of A: ");
			System.Console.Write("AX: ");
			string xx = Console.ReadLine();
			x = Convert.ToInt32(xx);

			System.Console.Write("AY: ");

			string yy = Console.ReadLine();
			y = Convert.ToInt32(yy);
			}
			catch (System.Exception)
			{
				System.Console.WriteLine("input a valid integer!");
				Thread.Sleep(3000);
			
			try
			{
			System.Console.Write("AX: ");
			string xx = Console.ReadLine();
			x = Convert.ToInt32(xx);

			System.Console.Write("AY: ");

			string yy = Console.ReadLine();
			y = Convert.ToInt32(yy);
			}
			catch (System.Exception)
			{
				System.Console.WriteLine("not valid, exiting the program...");
				Thread.Sleep(2000);
				Environment.Exit(0);
				throw;
			}
			}

			if ((x < -10) || (x > 10) || (y < -10) || (y > 10))
			{
				System.Console.WriteLine("x and y must be between -10, 10");
				System.Console.WriteLine("exiting the program...");
				Thread.Sleep(2000);
				Environment.Exit(0);
			}

			int xxx = x;
			int yyy = y;

			x = x+12;
			y = 11-y;

			System.Console.WriteLine("");
			
			int[] sets = {1, 2, 3};
			int sss = r.Next(0, sets.Length);
			int aset = sets[sss];

			int[] helts = {60, 80, 100};
			int ssss = r.Next(0, helts.Length);
			int ahelt = helts[ssss];

			System.Console.WriteLine($"A: ({xxx},{yyy})  Set {aset}  Health:{ahelt}");


			int setToRemove = aset;
			sets = sets.Where(val => val != setToRemove).ToArray();

			int heltToRemove = ahelt;
			helts = helts.Where(val => val != heltToRemove).ToArray();



			int bx = r.Next(2, 22);
			int by = r.Next(1, 21);

			sss = r.Next(0, sets.Length);
			int bset = sets[sss];

			ssss = r.Next(0, helts.Length);
			int bhelt = helts[ssss];

			System.Console.WriteLine($"B: ({bx-12},{11-by})  Set {bset}  Health:{bhelt}");

			setToRemove = bset;
			sets = sets.Where(val => val != setToRemove).ToArray();

			heltToRemove = bhelt;
			helts = helts.Where(val => val != heltToRemove).ToArray();

			int cx = r.Next(2, 22);
			int cy = r.Next(1, 21);
			while ((cx == bx) && (cy == by))
			{
				cx = r.Next(2, 22);
				cy = r.Next(1, 21);
			}

			sss = r.Next(0, sets.Length);
			int cset = sets[sss];

			ssss = r.Next(0, helts.Length);
			int chelt = helts[ssss];

			System.Console.WriteLine($"C: ({cx-12},{11-cy})  Set {cset}  Health:{chelt}");

			string[,] array2D = new string[,] {{"   ", " +", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "^", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "+", "\n"}, {" 10", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  9", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  8", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  7", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  6", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  5", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  4", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  3", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  2", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  1", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  0", "|", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "+", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", ">", "\n"}, {" -1", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -2", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -3", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -4", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -5", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -6", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -7", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -8", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -9", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"-10", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"   ", "+", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "+", "\n"}, {"   ", " ", "0", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", " ", "\n"}};
			array2D[y, x] = "A";
			array2D[by, bx] = "B";
			array2D[cy, cx] = "C";
			
			foreach (string tup in array2D)
			{
				System.Console.Write(tup);
				System.Console.Write(" ");
				
			}

			int ab = uzaklık(x, y, bx, by);
			int ac = uzaklık(x, y, cx, cy);
			int bc = uzaklık(cx, cy, bx, by);

			int apuan = 0;
			int bpuan = 0;
			int cpuan = 0;
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			if ((ab > 15) && (ac > 15) && (bc > 15))
			{
				System.Console.WriteLine(" Too distant, no attack");
			}
			else
			{
				if ((ab < ac) && (ab < bc))
				{
					System.Console.WriteLine(" Round 1: A-B");
					Console.WriteLine("");
					if ((aset == 1) && (bset == 3)) // A kazanır
					{
						bhelt = 0;
						apuan = puan(ab, ahelt) + apuan;
						Console.WriteLine($" A: Survivor     Health:{ahelt-25}   Score:{apuan}");
						Console.WriteLine($" B: Defeated     Health:0   Score:{bpuan}");
						Console.WriteLine($" C: Non-fighter  Health:{chelt}   Score:{cpuan}");
						ab = 20;
						bc = 20;
						ahelt = ahelt-25;
					}
					else if ((bset == 1) && (aset == 3)) // B kazanır
					{
						ahelt = 0;
						bpuan = puan(ab, bhelt) + bpuan;
						Console.WriteLine($" A: Defeated     Health:0   Score:{apuan}");
						Console.WriteLine($" B: Survivor     Health:{bhelt-25}   Score:{bpuan}");
						Console.WriteLine($" C: Non-fighter  Health:{chelt}   Score:{cpuan}");
						ab = 20;
						ac = 20;
						bhelt = bhelt-25;
					}

					else if (bset>aset) // B kazanır
					{
						ahelt = 0;
						bpuan = puan(ab, bhelt) + bpuan;
						Console.WriteLine($" A: Defeated     Health:0   Score:{apuan}");
						Console.WriteLine($" B: Survivor     Health:{bhelt-25}   Score:{bpuan}");
						Console.WriteLine($" C: Non-fighter  Health:{chelt}   Score:{cpuan}");
						ab = 20;
						ac = 20;
						bhelt = bhelt-25;
					}
					
					else // A kazanır
					{
						bhelt = 0;
						apuan = puan(ab, ahelt) + apuan;
						Console.WriteLine($" A: Survivor     Health:{ahelt-25}   Score:{apuan}");
						Console.WriteLine($" B: Defeated     Health:0   Score:{bpuan}");
						Console.WriteLine($" C: Non-fighter  Health:{chelt}   Score:{cpuan}");
						ab = 20;
						bc = 20;
						ahelt = ahelt-25;
					}

				}
				else if ((ac < ab) && (ac < bc))
				{
					System.Console.WriteLine(" Round 1: A-C");
					Console.WriteLine("");
					if ((aset == 1) && (cset == 3)) // A kazanır
					{
						chelt = 0;
						apuan = puan(ac, ahelt) + apuan;
						Console.WriteLine($" A: Survivor     Health:{ahelt-25}   Score:{apuan}");
						Console.WriteLine($" B: Non-fighter  Health:{bhelt}   Score:{bpuan}");
						Console.WriteLine($" C: Defeated     Health:0   Score:{cpuan}");
						ac = 20;
						bc = 20;
						ahelt = ahelt-25;
					}
					else if ((cset == 1) && (aset == 3)) // C kazanır
					{
						ahelt = 0;
						cpuan = puan(ac, chelt) + cpuan;
						Console.WriteLine($" A: Defeated     Health:0   Score:{apuan}");
						Console.WriteLine($" B: Non-fighter  Health:{bhelt}   Score:{bpuan}");
						Console.WriteLine($" C: Survivor     Health:{chelt-25}   Score:{cpuan}");
						ac = 20;
						ab = 20;
						chelt = chelt-25;
					}

					else if (cset>aset) // C kazanır
					{
						ahelt = 0;
						cpuan = puan(ac, chelt) + cpuan;
						Console.WriteLine($" A: Defeated     Health:0   Score:{apuan}");
						Console.WriteLine($" B: Non-fighter  Health:{bhelt}   Score:{bpuan}");
						Console.WriteLine($" C: Survivor     Health:{chelt-25}   Score:{cpuan}");
						ac = 20;
						ab = 20;
						chelt = chelt-25;
					}
					
					else // A kazanır
					{
						chelt = 0;
						apuan = puan(ac, ahelt) + apuan;
						Console.WriteLine($" A: Survivor     Health:{ahelt-25}   Score:{apuan}");
						Console.WriteLine($" B: Non-fighter  Health:{bhelt}   Score:{bpuan}");
						Console.WriteLine($" C: Defeated     Health:0   Score:{cpuan}");
						ac = 20;
						bc = 20;
						ahelt = ahelt-25;
					}
				}
				else if ((bc < ab) && (bc < ac))
				{
					System.Console.WriteLine(" Round 1: B-C");
					Console.WriteLine("");
					if ((bset == 1) && (cset == 3)) // B kazanır
					{
						chelt = 0;
						bpuan = puan(bc, bhelt) + bpuan;
						Console.WriteLine($" A: Non-fighter  Health:{ahelt}   Score:{apuan}");
						Console.WriteLine($" B: Survivor     Health:{bhelt-25}   Score:{bpuan}");
						Console.WriteLine($" C: Defeated     Health:0   Score:{cpuan}");
						bc = 20;
						ac = 20;
						bhelt = bhelt-25;
					}
					else if ((cset == 1) && (bset == 3)) // C kazanır
					{
						bhelt = 0;
						cpuan = puan(bc, chelt) + cpuan;
						Console.WriteLine($" A: Non-fighter  Health:{ahelt}   Score:{apuan}");
						Console.WriteLine($" B: Defeated     Health:0   Score:{bpuan}");
						Console.WriteLine($" C: Survivor     Health:{chelt-25}   Score:{cpuan}");
						bc = 20;
						ab = 20;
						chelt = chelt-25;
					}

					else if (cset>bset) // C kazanır
					{
						bhelt = 0;
						cpuan = puan(bc, chelt) + cpuan;
						Console.WriteLine($" A: Non-fighter  Health:{ahelt}   Score:{apuan}");
						Console.WriteLine($" B: Defeated     Health:0   Score:{bpuan}");
						Console.WriteLine($" C: Survivor     Health:{chelt-25}   Score:{cpuan}");
						bc = 20;
						ab = 20;
						chelt = chelt-25;
					}
					
					else // B kazanır
					{
						chelt = 0;
						bpuan = puan(bc, bhelt) + bpuan;
						Console.WriteLine($" A: Non-fighter  Health:{ahelt}   Score:{apuan}");
						Console.WriteLine($" B: Survivor     Health:{bhelt-25}   Score:{bpuan}");
						Console.WriteLine($" C: Defeated     Health:0   Score:{cpuan}");
						bc = 20;
						ac = 20;
						bhelt = bhelt-25;
					}
				}
				Console.WriteLine("");
				Console.WriteLine("");
				if ((ab > 15) && (ac > 15) && (bc > 15))
			{
				System.Console.WriteLine(" Too distant, no attack");
			}
			else
			{
				if ((ab < ac) && (ab < bc))
				{
					System.Console.WriteLine(" Round 2: A-B");
					Console.WriteLine("");
					if ((aset == 1) && (bset == 3)) // A kazanır
					{
						apuan = puan(ab, ahelt) + apuan;
						Console.WriteLine($" A: Survivor     Health:{ahelt-25}   Score:{apuan}");
						Console.WriteLine($" B: Defeated     Health:0   Score:{bpuan}");
						Console.WriteLine($" C: Non-fighter  Health:{chelt}   Score:{cpuan}");
					}
					else if ((bset == 1) && (aset == 3)) // B kazanır
					{
						bpuan = puan(ab, bhelt) + bpuan;
						Console.WriteLine($" A: Defeated     Health:0   Score:{apuan}");
						Console.WriteLine($" B: Survivor     Health:{bhelt-25}   Score:{bpuan}");
						Console.WriteLine($" C: Non-fighter  Health:{chelt}   Score:{cpuan}");
					}

					else if (bset>aset) // B kazanır
					{
						bpuan = puan(ab, bhelt) + bpuan;
						Console.WriteLine($" A: Defeated     Health:0   Score:{apuan}");
						Console.WriteLine($" B: Survivor     Health:{bhelt-25}   Score:{bpuan}");
						Console.WriteLine($" C: Non-fighter  Health:{chelt}   Score:{cpuan}");
					}
					
					else // A kazanır
					{
						apuan = puan(ab, ahelt) + apuan;
						Console.WriteLine($" A: Survivor     Health:{ahelt-25}   Score:{apuan}");
						Console.WriteLine($" B: Defeated     Health:0   Score:{bpuan}");
						Console.WriteLine($" C: Non-fighter  Health:{chelt}   Score:{cpuan}");
					}

				}
				else if ((ac < ab) && (ac < bc))
				{
					System.Console.WriteLine(" Round 2: A-C");
					Console.WriteLine("");
					if ((aset == 1) && (cset == 3)) // A kazanır
					{
						apuan = puan(ac, ahelt) + apuan;
						Console.WriteLine($" A: Survivor     Health:{ahelt-25}   Score:{apuan}");
						Console.WriteLine($" B: Non-fighter  Health:{bhelt}   Score:{bpuan}");
						Console.WriteLine($" C: Defeated     Health:0   Score:{cpuan}");
					}
					else if ((cset == 1) && (aset == 3)) // C kazanır
					{
						cpuan = puan(ac, chelt) + cpuan;
						Console.WriteLine($" A: Defeated     Health:0   Score:{apuan}");
						Console.WriteLine($" B: Non-fighter  Health:{bhelt}   Score:{bpuan}");
						Console.WriteLine($" C: Survivor     Health:{chelt-25}   Score:{cpuan}");
					}

					else if (cset>aset) // C kazanır
					{
						cpuan = puan(ac, chelt) + cpuan;
						Console.WriteLine($" A: Defeated     Health:0   Score:{apuan}");
						Console.WriteLine($" B: Non-fighter  Health:{bhelt}   Score:{bpuan}");
						Console.WriteLine($" C: Survivor     Health:{chelt-25}   Score:{cpuan}");
					}
					
					else // A kazanır
					{
						apuan = puan(ac, ahelt) + apuan;
						Console.WriteLine($" A: Survivor     Health:{ahelt-25}   Score:{apuan}");
						Console.WriteLine($" B: Non-fighter  Health:{bhelt}   Score:{bpuan}");
						Console.WriteLine($" C: Defeated     Health:0   Score:{cpuan}");
					}
				}
				else if ((bc < ab) && (bc < ac))
				{
					System.Console.WriteLine(" Round 2: B-C");
					Console.WriteLine("");
					if ((bset == 1) && (cset == 3)) // B kazanır
					{
						bpuan = puan(bc, bhelt) + bpuan;
						Console.WriteLine($" A: Non-fighter  Health:{ahelt}   Score:{apuan}");
						Console.WriteLine($" B: Survivor     Health:{bhelt-25}   Score:{bpuan}");
						Console.WriteLine($" C: Defeated     Health:0   Score:{cpuan}");
					}
					else if ((cset == 1) && (bset == 3)) // C kazanır
					{
						cpuan = puan(bc, chelt) + cpuan;
						Console.WriteLine($" A: Non-fighter  Health:{ahelt}   Score:{apuan}");
						Console.WriteLine($" B: Defeated     Health:0   Score:{bpuan}");
						Console.WriteLine($" C: Survivor     Health:{chelt-25}   Score:{cpuan}");
					}

					else if (cset>bset) // C kazanır
					{
						cpuan = puan(bc, chelt) + cpuan;
						Console.WriteLine($" A: Non-fighter  Health:{ahelt}   Score:{apuan}");
						Console.WriteLine($" B: Defeated     Health:0   Score:{bpuan}");
						Console.WriteLine($" C: Survivor     Health:{chelt-25}   Score:{cpuan}");
					}
					
					else // B kazanır
					{
						bpuan = puan(bc, bhelt) + bpuan;
						Console.WriteLine($" A: Non-fighter  Health:{ahelt}   Score:{apuan}");
						Console.WriteLine($" B: Survivor     Health:{bhelt-25}   Score:{bpuan}");
						Console.WriteLine($" C: Defeated     Health:0   Score:{cpuan}");
					}
				}
				
			}
			Console.WriteLine("");
			if ((apuan > bpuan)&&(apuan > cpuan))
			{
				Console.WriteLine($" A has the maximum score ({apuan})");
			}
			else if ((bpuan > apuan)&&(bpuan > cpuan))
			{
				Console.WriteLine($" B has the maximum score ({bpuan})");
			}
			else if ((cpuan > apuan)&&(cpuan > bpuan))
			{
				Console.WriteLine($" C has the maximum score ({cpuan})");
			}
			else if (apuan == bpuan)
			{
				Console.WriteLine($" A and B has the same maximum score ({apuan})");
			}
			else if (apuan == cpuan)
			{
				Console.WriteLine($" A and C has the same maximum score ({apuan})");
			}
			else if (bpuan == cpuan)
			{
				Console.WriteLine($" B and C has the same maximum score ({bpuan})");
			}

			}

    	}

		static int uzaklık(int x1, int y1, int x2, int y2)
        {   
            return Math.Abs(x1-x2) + Math.Abs(y1-y2);
        }

		static int puan(int manhat, int can)
        {   
            return 10*manhat + (100 - can);
        }
	}
}