// Adrián Navarro Gabino

using System;
using System.IO;

class PCXViewer
{
	static void Main(string[] args)
	{
		string inputName;
		
		if(args.Length > 0)
		{
			inputName = args[0];
		}
		else
		{
			Console.Write("File name: ");
			inputName = Console.ReadLine();
		}
		
		if(!File.Exists(inputName))
		{
			Console.WriteLine("File not found");
		}
		else
		{
			try
			{
				FileStream input = File.OpenRead(inputName);
				byte[] data = new byte[input.Length];
				
				int read = input.Read(data, 0, (int)input.Length);
				
				if(data[0] != 10)
				{
					Console.WriteLine("It's not a PCX");
				}
				else
				{
					Console.WriteLine("It seems a valid PCX");
					
					if(data[2] == 0)
					{
						Console.WriteLine("Not a compressed image");
					}
					else if(data[2] == 1)
					{
						Console.WriteLine("It's a compressed file");
						
						if(data[3] != 8)
						{
							Console.WriteLine("Not a 256 colors image");
						}
						else
						{
							Console.WriteLine("Bits per pixel: " + data[3]);
							
							short xMin = (short)(data[4] + data[5] * 256);
							short yMin = (short)(data[6] + data[7] * 256);
							short xMax = (short)(data[8] + data[9] * 256);
							short yMax = (short)(data[10] + data[11] * 256);
							
							short width = (short)(xMax - xMin + 1);
							short height = (short)(yMax - yMin + 1);
							Console.WriteLine("Width: " + width);
							Console.WriteLine("Height: " + height);
							
							if(data[66] != width)
							{
								Console.WriteLine("Width error");
							}
							else
							{
								Console.WriteLine("Bytes per line: " + data[66]);
								
								string symbol = ".";
								
								int count = 0;
								
								for(byte i = 128; i < data.Length; i++)
								{
									int times = 1;
										
									if(data[i] < 192)
									{
										if(i != 128 && data[i - 1] >= 192)
										{
											times = data[i-1] - 192;
										}
										else
										{	
											if(data[i] <= 49)
												symbol = "#";
											else if(data[i] <= 99)
												symbol = "=";
											else if(data[i] <= 149)
												symbol = "-";
											else if(data[i] <= 199)
												symbol = ".";
												
											for(byte j = 0; j < times; j++)
											{
												Console.Write(symbol);
												count++;
												if(count % width == 0)
													Console.WriteLine();
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch(PathTooLongException)
			{
				Console.WriteLine("Path too long");
			}
			catch(IOException)
			{
				Console.WriteLine("IO exception");
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
