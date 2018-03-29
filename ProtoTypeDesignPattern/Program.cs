using System;
using System.Collections.Generic;

namespace ProtoTypeDesignPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            ColorController colorController = new ColorController();
            colorController["yellow"] = new Color(255, 255, 0);
            colorController["orange"] = new Color(255, 255, 0);
            colorController["purple"] = new Color(255, 255, 0);

            //user adds personalized color
            colorController["sunny"] = new Color(255, 123, 0);
            colorController["tasty"] = new Color(255, 123, 0);
            colorController["rainy"] = new Color(255, 123, 0);

            //User clones selected colors
            Color c1 = colorController["yellow"].Clone() as Color;

            Console.ReadKey();
        }
    }

    internal class Color : ColorProtoType
    {
        private int _orange;
        private int _purple;
        private int _yellow;

        public Color(int yellow, int orange, int purple)
        {
            _yellow = yellow;
            _orange = orange;
            _purple = purple;
        }

        //crate a shallow copy
        public override ColorProtoType Clone()
        {
            Console.WriteLine("RGB color is cloned to{0,3},{1,3},{2,3}", _yellow, _orange, _purple);

            return MemberwiseClone() as ColorProtoType;
        }
    }

    internal class ColorController
    {
        private Dictionary<string, ColorProtoType> _colors = new Dictionary<string, ColorProtoType>();

        public ColorProtoType this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }

    internal abstract class ColorProtoType
    {
        public abstract ColorProtoType Clone();
    }
}