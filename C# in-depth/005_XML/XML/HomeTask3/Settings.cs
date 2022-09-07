using System;

namespace HomeTask3
{
    internal struct Settings
    {
        public ConsoleColor ForegroundColor { get; }
        public ConsoleColor BackgroundColor { get; }
        public int СursorSize { get; }

        public Settings(ConsoleColor foregroundColor, ConsoleColor backgroundColor, int cursorSize)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
            СursorSize = cursorSize;
        }
    }
}
