﻿using System;
using System.Text;

namespace CSharpMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Salam Samir";
            //Console.WriteLine(ReverseText(text));

            #region Class
            #region Anonimous object
            //var stu1 = new
            //{
            //    name="Ferrux",
            //    surname="Eliyev",
            //    age=19
            //};

            //var stu2 = new
            //{
            //    name = "Gunay",
            //    surname = "Abbasova",
            //    age = 21
            //};

            //Console.WriteLine($"{stu1.name} {stu1.surname} {stu1.age}");
            //Console.WriteLine($"{stu2.name} {stu2.surname} {stu2.age}");
            #endregion
            //instance
            //Student stu1 = new Student();
            Student stu2 = new Student();
            //stu1.Age = 21;
            //stu1.Detail();
            stu2.Detail();

            //Group group1 = new Group();
            //group1.groupName = "BP201";
            //group1.maxStuCount = 16;
            //Console.WriteLine(group1.Info());
            #endregion
        }

        #region Homework
        //static StringBuilder ReverseText(string text)
        //{
        //    int index = 0;
        //    StringBuilder newText = new StringBuilder();
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == ' ' || i == text.Length - 1)
        //        {
        //            if (i == text.Length - 1)
        //            {
        //                i += 1;
        //            }
        //            ReverseAndMerge(newText, text, i - 1, index);
        //            AddSpace(newText, text, i);
        //            index = i + 1;
        //        }
        //    }
        //    return newText;
        //}

        //static void ReverseAndMerge(StringBuilder result, string text, int endIndex, int initIndex)
        //{
        //    for (int j = endIndex; j >= initIndex; j--)
        //    {
        //        result.Append(text[j]);
        //    }
        //}

        //static void AddSpace(StringBuilder result, string text, int index)
        //{
        //    if (index != text.Length)
        //        result.Append(' ');
        //}
        #endregion

    }


}
