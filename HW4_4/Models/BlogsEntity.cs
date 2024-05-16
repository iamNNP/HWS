namespace HW4_4.Models;
using System.Collections.Generic;

public class BlogsEntity
{
    public string Article { get; set;}
    public List<string> Paragraphs { get; set;}
    public string ImagePath { get; set;}
    public List<string> Tags { get; set;}
}