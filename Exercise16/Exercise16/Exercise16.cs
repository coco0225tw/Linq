﻿// See https://aka.ms/new-console-template for more information

void Exercise16()
{
    var folderFiles = Directory.GetFiles("D:/mine/Linq/Exercise16");
    
		
    var size = folderFiles.Select(file =>new FileInfo(file).Length).Average(); //compute average
    size = Math.Round(size / 10, 1);
    Console.WriteLine($"The Average file size is {size} MB");
}
Exercise16();